namespace HabitTracker.App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUser = new Label();
            panelUser = new Panel();
            panel2 = new Panel();
            flpHabitBase = new FlowLayoutPanel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panelUser.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Sitka Display", 12F);
            lblUser.Location = new Point(3, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(62, 29);
            lblUser.TabIndex = 2;
            lblUser.Text = "User: ";
            // 
            // panelUser
            // 
            panelUser.BackColor = Color.FromArgb(155, 184, 153);
            panelUser.Controls.Add(lblUser);
            panelUser.Dock = DockStyle.Bottom;
            panelUser.Location = new Point(0, 415);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(800, 35);
            panelUser.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(229, 243, 229);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(flpHabitBase);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(3, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(785, 207);
            panel2.TabIndex = 9;
            // 
            // flpHabitBase
            // 
            flpHabitBase.BackColor = Color.FromArgb(229, 243, 229);
            flpHabitBase.Dock = DockStyle.Fill;
            flpHabitBase.Location = new Point(0, 36);
            flpHabitBase.Name = "flpHabitBase";
            flpHabitBase.Size = new Size(785, 171);
            flpHabitBase.TabIndex = 8;
            flpHabitBase.Paint += flpHabitBase_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(208, 221, 208);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(785, 36);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(208, 221, 208);
            label1.Font = new Font("Sitka Display", 12F);
            label1.ForeColor = Color.FromArgb(101, 92, 86);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 29);
            label1.TabIndex = 46;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(208, 221, 208);
            label2.Font = new Font("Sitka Display", 12F);
            label2.ForeColor = Color.FromArgb(101, 92, 86);
            label2.Location = new Point(251, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 29);
            label2.TabIndex = 47;
            label2.Text = "Descrição";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(208, 221, 208);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 36);
            panel1.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(208, 221, 208);
            label3.Font = new Font("Sitka Display", 12F);
            label3.ForeColor = Color.FromArgb(101, 92, 86);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 29);
            label3.TabIndex = 46;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(208, 221, 208);
            label4.Font = new Font("Sitka Display", 12F);
            label4.ForeColor = Color.FromArgb(101, 92, 86);
            label4.Location = new Point(251, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 29);
            label4.TabIndex = 47;
            label4.Text = "Descrição";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(208, 221, 208);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 171);
            panel4.Name = "panel4";
            panel4.Size = new Size(785, 36);
            panel4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(208, 221, 208);
            label5.Font = new Font("Sitka Display", 12F);
            label5.ForeColor = Color.FromArgb(101, 92, 86);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 29);
            label5.TabIndex = 46;
            label5.Text = "Data";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(208, 221, 208);
            label6.Font = new Font("Sitka Display", 12F);
            label6.ForeColor = Color.FromArgb(101, 92, 86);
            label6.Location = new Point(251, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 29);
            label6.TabIndex = 47;
            label6.Text = "Foi Feito?";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 252, 239);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panelUser);
            IsMdiContainer = true;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Controls.SetChildIndex(panelUser, 0);
            Controls.SetChildIndex(panel2, 0);
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Label lblUser;
        public Panel panelUser;
        private Panel panel2;
        public FlowLayoutPanel flpHabitBase;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Panel panel4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Label label3;
        private Label label4;
    }
}
