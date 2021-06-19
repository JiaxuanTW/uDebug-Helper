using System;
using System.Windows.Forms;
using uDebug_Helper.Utils;

namespace uDebug_Helper.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            textBox1.Text = DataLoader.LoadFromAppData("compiler_path.settings");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Select Compiler",
                InitialDirectory = "C:\\",
                Filter = "Executable Files (*.exe)|*.exe"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fileDialog.FileName;
                DataLoader.SaveToAppData("compiler_path.settings", fileDialog.FileName);
            }
        }
    }
}
