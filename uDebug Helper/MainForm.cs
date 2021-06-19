using System;
using System.Windows.Forms;

namespace uDebug_Helper
{
    public partial class MainForm : Form
    {
        private Form activeForm;
        private Forms.LoadForm loadForm = new Forms.LoadForm();
        private Forms.SelectForm selectForm = new Forms.SelectForm();
        private Forms.CompareForm compareForm = new Forms.CompareForm();

        public enum ChildForm
        {
            LoadForm,
            SelectForm,
            CompareForm
        }

        public MainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
            btn_select.Enabled = false;
            btn_compare.Enabled = false;

            SwitchChildForm(ChildForm.LoadForm);
        }

        public void SwitchChildForm(ChildForm childForm)
        {
            Form form = new Forms.LoadForm();
            switch (childForm)
            {
                case ChildForm.LoadForm:
                    btn_select.Enabled = false;
                    btn_compare.Enabled = false;
                    form = loadForm;
                    break;
                case ChildForm.SelectForm:
                    btn_select.Enabled = true;
                    btn_compare.Enabled = false;
                    form = selectForm;
                    selectForm.UpdateList();
                    break;
                case ChildForm.CompareForm:
                    btn_select.Enabled = true;
                    btn_compare.Enabled = true;
                    form = compareForm;
                    compareForm.Compare();
                    break;
            }

            if (activeForm != null)
            {
                activeForm.Visible = false;
            }
            activeForm = form;
            form.MdiParent = this;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(form);
            childFormPanel.Tag = form;
            form.BringToFront();
            form.Visible = true;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            SwitchChildForm(ChildForm.LoadForm);
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            SwitchChildForm(ChildForm.SelectForm);
        }

        private void btn_compare_Click(object sender, EventArgs e)
        {
            SwitchChildForm(ChildForm.CompareForm);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Forms.SettingsForm settingsForm = new Forms.SettingsForm();
            settingsForm.ShowDialog();
        }
    }
}
