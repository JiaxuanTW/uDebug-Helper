using DiffMatchPatch;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using uDebug_Helper.Utils;

namespace uDebug_Helper.Forms
{
    public partial class CompareForm : Form
    {
        diff_match_patch DIFF = new diff_match_patch();

        List<Diff> diffs;
        List<Chunk> chunklist1;
        List<Chunk> chunklist2;

        Color[] colors1 = new Color[3] { Color.LightGreen, Color.LightSalmon, Color.White };
        Color[] colors2 = new Color[3] { Color.LightSalmon, Color.LightGreen, Color.White };

        public CompareForm()
        {
            InitializeComponent();
        }

        private struct Chunk
        {
            public int startpos;
            public int length;
            public Color BackColor;
        }

        public void Compare()
        {
            richTextBox1.Text = DataLoader.LoadFromAppData("answer.txt");
            richTextBox2.Text = DataLoader.LoadFromAppData("output.txt");

            diffs = DIFF.diff_main(
                richTextBox1.Text.Replace(Environment.NewLine, "\n"), 
                richTextBox2.Text.Replace(Environment.NewLine, "\n"));
            DIFF.diff_cleanupSemanticLossless(diffs);

            chunklist1 = collectChunks(richTextBox1);
            chunklist2 = collectChunks(richTextBox2);

            paintChunks(richTextBox1, chunklist1);
            paintChunks(richTextBox2, chunklist2);

            richTextBox1.SelectionLength = 0;
            richTextBox2.SelectionLength = 0;
        }

        List<Chunk> collectChunks(RichTextBox RTB)
        {
            RTB.Text = "";
            List<Chunk> chunkList = new List<Chunk>();
            foreach (Diff d in diffs)
            {
                if (RTB == richTextBox2 && d.operation == Operation.DELETE) continue;
                if (RTB == richTextBox1 && d.operation == Operation.INSERT) continue;

                Chunk ch = new Chunk();
                int length = RTB.TextLength;
                RTB.AppendText(d.text);
                ch.startpos = length;
                ch.length = d.text.Length;
                ch.BackColor = RTB == richTextBox1 ? colors1[(int)d.operation]
                                                   : colors2[(int)d.operation];
                chunkList.Add(ch);
            }
            return chunkList;
        }

        void paintChunks(RichTextBox RTB, List<Chunk> theChunks)
        {
            foreach (Chunk ch in theChunks)
            {
                RTB.Select(ch.startpos, ch.length);
                RTB.SelectionBackColor = ch.BackColor;
            }
        }

        public static void HighlightLine(RichTextBox richTextBox, int index, Color color)
        {
            richTextBox.SelectAll();
            richTextBox.SelectionBackColor = richTextBox.BackColor;
            var lines = richTextBox.Lines;
            if (index < 0 || index >= lines.Length)
                return;
            var start = richTextBox.GetFirstCharIndexFromLine(index);
            var length = lines[index].Length;
            richTextBox.Select(start, length);
            richTextBox.SelectionBackColor = color;
        }
    }
}
