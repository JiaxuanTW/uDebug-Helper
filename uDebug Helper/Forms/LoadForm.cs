using FastColoredTextBoxNS;
using System;
using System.Windows.Forms;
using uDebug.API;
using uDebug_Helper.Utils;

namespace uDebug_Helper.Forms
{
    public partial class LoadForm : Form
    {
        private FastColoredTextBox codeEditor = new FastColoredTextBox();

        public LoadForm()
        {
            InitializeComponent();

            panel_main.Controls.Add(codeEditor);
            codeEditor.Dock = DockStyle.Fill;
            codeEditor.Font = new System.Drawing.Font("Consolas", 14);
            codeEditor.Language = Language.CSharp;
            codeEditor.Text = DataLoader.LoadFromAppData("main.cpp");
            codeEditor.TextChanged += CodeEditor_TextChanged;

            problems_select.Text = DataLoader.LoadFromAppData("problem_number.settings");
        }

        private void CodeEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataLoader.SaveToAppData("main.cpp", codeEditor.Text);
        }

        private void problems_select_TextChanged(object sender, EventArgs e)
        {
            DataLoader.SaveToAppData("problem_number.settings", problems_select.Text);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)ParentForm;
            try
            {
                Client client = new Client();
                client.GetProblem(Judge.UVa, Convert.ToInt32(problems_select.Text));
                mainForm.SwitchChildForm(MainForm.ChildForm.SelectForm);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Problem Not Found");
            }
        }
    }
}
