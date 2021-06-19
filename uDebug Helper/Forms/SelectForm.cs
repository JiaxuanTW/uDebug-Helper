using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using uDebug.API;
using uDebug_Helper.Utils;

namespace uDebug_Helper.Forms
{
    public partial class SelectForm : Form
    {
        private Problem problem;
        private string answer;

        public SelectForm()
        {
            InitializeComponent();
        }

        public void UpdateList()
        {
            listView1.Clear();
            textBox1.Text = "Select a input...";

            Client client = new Client();
            int problemNumber = Convert.ToInt32(
                DataLoader.LoadFromAppData("problem_number.settings"));
            problem = client.GetProblem(Judge.UVa, problemNumber);

            // Add input list to listView1
            for (int i = 0; i < problem.Inputs.Count(); i++)
            {
                ListViewItem item = new ListViewItem(problem.Inputs[i].User);
                listView1.Items.Add(item);
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.Items[e.ItemIndex].Selected)
            {
                Console.WriteLine(listView1.Items[e.ItemIndex].Text);
                string inputs = problem.GetInput(problem.Inputs[e.ItemIndex]).Replace("\n", Environment.NewLine);
                textBox1.Text = inputs;
                answer = problem.GetOutput(problem.Inputs[e.ItemIndex]);
            }
        }

        private void btn_compare_Click(object sender, EventArgs e)
        {
            DataLoader.SaveToAppData("input.txt", textBox1.Text);
            DataLoader.SaveToAppData("answer.txt", answer);
            if (DataLoader.LoadFromAppData("compiler_path.settings") == null)
            {
                MessageBox.Show("Compiler path is null");
                return;
            }
            Compile();
            MainForm mainForm = (MainForm)ParentForm;
            mainForm.SwitchChildForm(MainForm.ChildForm.CompareForm);
        }

        private void Compile()
        {
            string appDataFolderPath = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData);
            string compilerPath = DataLoader.LoadFromAppData("compiler_path.settings");
            string cppFilePath = appDataFolderPath + "\\uDebug Helper\\main.cpp";
            string exeFilePath = appDataFolderPath + "\\uDebug Helper\\main.exe";
            string inputFilePath = appDataFolderPath + "\\uDebug Helper\\input.txt";
            string outputFilePath = appDataFolderPath + "\\uDebug Helper\\output.txt";

            if (compilerPath == null)
            {
                MessageBox.Show("Compiler path is null");
                return;
            }

            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            //p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;

            p.Start();
            p.StandardInput.WriteLine("\"" + compilerPath + "\" -o \"" + exeFilePath + "\" \"" + cppFilePath + "\"");
            p.StandardInput.WriteLine("\"" + exeFilePath + "\" <\"" + inputFilePath + "\"> \"" + outputFilePath + "\"");
            p.StandardInput.WriteLine("exit");

            p.WaitForExit();
            p.Close();
        }
    }
}
