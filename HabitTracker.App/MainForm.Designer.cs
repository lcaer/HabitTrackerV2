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
            HabitBasePanel = new Panel();
            StreakPanel = new Panel();
            btnConfStreak = new Button();
            cbStreak = new ComboBox();
            lblDate = new Label();
            lblStreakDone = new Label();
            flpHabitStreak = new FlowLayoutPanel();
            panel3 = new Panel();
            HabitTitlePanel = new Panel();
            lblName = new Label();
            lblDesc = new Label();
            label1 = new Label();
            label2 = new Label();
            panelUser.SuspendLayout();
            HabitBasePanel.SuspendLayout();
            StreakPanel.SuspendLayout();
            panel3.SuspendLayout();
            HabitTitlePanel.SuspendLayout();
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
            // HabitBasePanel
            // 
            HabitBasePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            HabitBasePanel.BackColor = Color.FromArgb(229, 243, 229);
            HabitBasePanel.Controls.Add(StreakPanel);
            HabitBasePanel.Controls.Add(flpHabitStreak);
            HabitBasePanel.Controls.Add(panel3);
            HabitBasePanel.Location = new Point(3, 63);
            HabitBasePanel.Name = "HabitBasePanel";
            HabitBasePanel.Size = new Size(785, 207);
            HabitBasePanel.TabIndex = 9;
            HabitBasePanel.Visible = false;
            // 
            // StreakPanel
            // 
            StreakPanel.BackColor = Color.FromArgb(208, 221, 208);
            StreakPanel.Controls.Add(btnConfStreak);
            StreakPanel.Controls.Add(cbStreak);
            StreakPanel.Controls.Add(lblDate);
            StreakPanel.Controls.Add(lblStreakDone);
            StreakPanel.Dock = DockStyle.Bottom;
            StreakPanel.Location = new Point(0, 171);
            StreakPanel.Name = "StreakPanel";
            StreakPanel.Size = new Size(785, 36);
            StreakPanel.TabIndex = 9;
            // 
            // btnConfStreak
            // 
            btnConfStreak.BackColor = Color.FromArgb(229, 243, 229);
            btnConfStreak.Dock = DockStyle.Right;
            btnConfStreak.FlatAppearance.BorderColor = Color.FromArgb(155, 184, 153);
            btnConfStreak.FlatStyle = FlatStyle.Flat;
            btnConfStreak.Font = new Font("Sitka Display", 12F);
            btnConfStreak.Location = new Point(627, 0);
            btnConfStreak.Name = "btnConfStreak";
            btnConfStreak.Size = new Size(158, 36);
            btnConfStreak.TabIndex = 48;
            btnConfStreak.Text = "Confirmar";
            btnConfStreak.UseVisualStyleBackColor = false;
            btnConfStreak.Click += btnConfStreak_Click;
            // 
            // cbStreak
            // 
            cbStreak.BackColor = Color.FromArgb(229, 243, 229);
            cbStreak.ForeColor = Color.FromArgb(101, 92, 86);
            cbStreak.FormattingEnabled = true;
            cbStreak.Items.AddRange(new object[] { "Sim", "Não" });
            cbStreak.Location = new Point(347, 4);
            cbStreak.Name = "cbStreak";
            cbStreak.Size = new Size(120, 29);
            cbStreak.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.FromArgb(208, 221, 208);
            lblDate.Font = new Font("Sitka Display", 12F);
            lblDate.ForeColor = Color.FromArgb(101, 92, 86);
            lblDate.Location = new Point(3, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(49, 29);
            lblDate.TabIndex = 46;
            lblDate.Text = "Data";
            // 
            // lblStreakDone
            // 
            lblStreakDone.AutoSize = true;
            lblStreakDone.BackColor = Color.FromArgb(208, 221, 208);
            lblStreakDone.Font = new Font("Sitka Display", 12F);
            lblStreakDone.ForeColor = Color.FromArgb(101, 92, 86);
            lblStreakDone.Location = new Point(251, 0);
            lblStreakDone.Name = "lblStreakDone";
            lblStreakDone.Size = new Size(90, 29);
            lblStreakDone.TabIndex = 47;
            lblStreakDone.Text = "Foi Feito?";
            // 
            // flpHabitStreak
            // 
            flpHabitStreak.BackColor = Color.FromArgb(229, 243, 229);
            flpHabitStreak.Dock = DockStyle.Fill;
            flpHabitStreak.Location = new Point(0, 36);
            flpHabitStreak.Name = "flpHabitStreak";
            flpHabitStreak.Size = new Size(785, 171);
            flpHabitStreak.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(208, 221, 208);
            panel3.Controls.Add(HabitTitlePanel);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(785, 36);
            panel3.TabIndex = 1;
            // 
            // HabitTitlePanel
            // 
            HabitTitlePanel.BackColor = Color.FromArgb(208, 221, 208);
            HabitTitlePanel.Controls.Add(lblName);
            HabitTitlePanel.Controls.Add(lblDesc);
            HabitTitlePanel.Dock = DockStyle.Top;
            HabitTitlePanel.Location = new Point(0, 0);
            HabitTitlePanel.Name = "HabitTitlePanel";
            HabitTitlePanel.Size = new Size(785, 36);
            HabitTitlePanel.TabIndex = 48;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(208, 221, 208);
            lblName.Font = new Font("Sitka Display", 12F);
            lblName.ForeColor = Color.FromArgb(101, 92, 86);
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 29);
            lblName.TabIndex = 46;
            lblName.Text = "Nome";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.BackColor = Color.FromArgb(208, 221, 208);
            lblDesc.Font = new Font("Sitka Display", 12F);
            lblDesc.ForeColor = Color.FromArgb(101, 92, 86);
            lblDesc.Location = new Point(251, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(90, 29);
            lblDesc.TabIndex = 47;
            lblDesc.Text = "Descrição";
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 252, 239);
            ClientSize = new Size(800, 450);
            Controls.Add(HabitBasePanel);
            Controls.Add(panelUser);
            IsMdiContainer = true;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Controls.SetChildIndex(panelUser, 0);
            Controls.SetChildIndex(HabitBasePanel, 0);
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            HabitBasePanel.ResumeLayout(false);
            StreakPanel.ResumeLayout(false);
            StreakPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            HabitTitlePanel.ResumeLayout(false);
            HabitTitlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label lblUser;
        public Panel panelUser;
        public FlowLayoutPanel flpHabitStreak;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Panel StreakPanel;
        private Label lblDate;
        private Label lblStreakDone;
        private Label lblName;
        private Label lblDesc;
        private ComboBox cbStreak;
        private Button btnConfStreak;
        public Panel HabitTitlePanel;
        public Panel HabitBasePanel;
    }
}
