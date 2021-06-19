
namespace uDebug_Helper.Forms
{
    partial class LoadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_side = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.judge_select = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.problems_select = new System.Windows.Forms.TextBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_side.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.panel_side.Controls.Add(this.label2);
            this.panel_side.Controls.Add(this.judge_select);
            this.panel_side.Controls.Add(this.btn_search);
            this.panel_side.Controls.Add(this.label1);
            this.panel_side.Controls.Add(this.problems_select);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_side.Location = new System.Drawing.Point(582, 0);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(350, 553);
            this.panel_side.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Problems";
            // 
            // judge_select
            // 
            this.judge_select.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.judge_select.Enabled = false;
            this.judge_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.judge_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judge_select.FormattingEnabled = true;
            this.judge_select.ItemHeight = 29;
            this.judge_select.Items.AddRange(new object[] {
            "ACM-ICPC Live Archive",
            "CATS Online Judge",
            "Dev Skill",
            "Facebook Hacker Cup",
            "Google Code Jam",
            "Light Online Judge",
            "Sphere Online Judge",
            "Toph",
            "URI Online Judge",
            "UVa Online Judge"});
            this.judge_select.Location = new System.Drawing.Point(11, 73);
            this.judge_select.Name = "judge_select";
            this.judge_select.Size = new System.Drawing.Size(327, 37);
            this.judge_select.Sorted = true;
            this.judge_select.TabIndex = 3;
            this.judge_select.Text = "UVa Online Judge";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(189)))), ((int)(((byte)(236)))));
            this.btn_search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(0, 508);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(350, 45);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Judges";
            // 
            // problems_select
            // 
            this.problems_select.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.problems_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problems_select.Location = new System.Drawing.Point(11, 162);
            this.problems_select.Name = "problems_select";
            this.problems_select.Size = new System.Drawing.Size(327, 34);
            this.problems_select.TabIndex = 0;
            this.problems_select.TextChanged += new System.EventHandler(this.problems_select_TextChanged);
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(582, 553);
            this.panel_main.TabIndex = 1;
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_side);
            this.Name = "LoadForm";
            this.Text = "LoadForm";
            this.panel_side.ResumeLayout(false);
            this.panel_side.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox problems_select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox judge_select;
        private System.Windows.Forms.Button btn_search;
    }
}