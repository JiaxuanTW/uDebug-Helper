using System;
using System.Windows.Forms;

namespace uDebug_Helper
{
    public partial class MainForm : Form
    {
        private Form activeForm;

        public MainForm()
        {
            InitializeComponent();
            //var inputs = new string[3];
            //var client = new Client();
            //var problem = client.GetProblem(Judge.UVa, 100);
            //inputs[0] = problem.GetInput(problem.Inputs[9]).Replace("\n", Environment.NewLine);
        }

        private void OpenChildForm(Form childForm, object buttonSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.LoadForm(), sender);
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SelectForm(), sender);
        }

        private void btn_compare_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CompareForm(), sender);
        }
    }
}
