namespace HabitTracker.App.Bases
{
    partial class BasePanelHabit
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
            HabitPanel = new Panel();
            StreakPanel = new Panel();
            chStreak = new ReaLTaiizor.Controls.FoxCheckBox();
            btnConfStreak = new Button();
            lblDate = new Label();
            lblStreakDone = new Label();
            flpHabitStreak = new FlowLayoutPanel();
            HabitTitlePanel = new Panel();
            lblName = new Label();
            lblDesc = new Label();
            HabitPanel.SuspendLayout();
            StreakPanel.SuspendLayout();
            HabitTitlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // HabitPanel
            // 
            HabitPanel.BackColor = Color.FromArgb(229, 243, 229);
            HabitPanel.Controls.Add(StreakPanel);
            HabitPanel.Controls.Add(flpHabitStreak);
            HabitPanel.Controls.Add(HabitTitlePanel);
            HabitPanel.Dock = DockStyle.Fill;
            HabitPanel.Location = new Point(0, 0);
            HabitPanel.Name = "HabitPanel";
            HabitPanel.Size = new Size(781, 408);
            HabitPanel.TabIndex = 10;
            // 
            // StreakPanel
            // 
            StreakPanel.BackColor = Color.FromArgb(208, 221, 208);
            StreakPanel.Controls.Add(chStreak);
            StreakPanel.Controls.Add(btnConfStreak);
            StreakPanel.Controls.Add(lblDate);
            StreakPanel.Controls.Add(lblStreakDone);
            StreakPanel.Dock = DockStyle.Bottom;
            StreakPanel.Location = new Point(0, 372);
            StreakPanel.Name = "StreakPanel";
            StreakPanel.Size = new Size(781, 36);
            StreakPanel.TabIndex = 9;
            // 
            // chStreak
            // 
            chStreak.BackColor = Color.FromArgb(229, 243, 229);
            chStreak.Checked = true;
            chStreak.CheckedBorderColorA = Color.FromArgb(155, 184, 153);
            chStreak.CheckedBorderColorB = Color.FromArgb(155, 184, 153);
            chStreak.CheckedColor = Color.FromArgb(155, 184, 153);
            chStreak.DisabledCheckedBorderColorA = Color.FromArgb(230, 230, 230);
            chStreak.DisabledCheckedBorderColorB = Color.FromArgb(124, 166, 191);
            chStreak.DisabledCheckedColor = Color.FromArgb(125, 183, 216);
            chStreak.DisabledUncheckedBorderColorA = Color.FromArgb(230, 230, 230);
            chStreak.DisabledUncheckedBorderColorB = Color.FromArgb(226, 189, 133);
            chStreak.DisabledUncheckedColor = Color.FromArgb(255, 203, 124);
            chStreak.EnabledCalc = true;
            chStreak.Location = new Point(395, 5);
            chStreak.Name = "chStreak";
            chStreak.Size = new Size(55, 28);
            chStreak.TabIndex = 49;
            chStreak.Text = "foxCheckBox2";
            chStreak.UncheckedBorderColorA = Color.FromArgb(155, 184, 153);
            chStreak.UncheckedBorderColorB = Color.FromArgb(155, 184, 153);
            chStreak.UncheckedColor = Color.FromArgb(155, 184, 153);
            // 
            // btnConfStreak
            // 
            btnConfStreak.BackColor = Color.FromArgb(229, 243, 229);
            btnConfStreak.Dock = DockStyle.Right;
            btnConfStreak.FlatAppearance.BorderColor = Color.FromArgb(155, 184, 153);
            btnConfStreak.FlatStyle = FlatStyle.Flat;
            btnConfStreak.Font = new Font("Sitka Display", 12F);
            btnConfStreak.Location = new Point(623, 0);
            btnConfStreak.Name = "btnConfStreak";
            btnConfStreak.Size = new Size(158, 36);
            btnConfStreak.TabIndex = 48;
            btnConfStreak.Text = "Confirmar";
            btnConfStreak.UseVisualStyleBackColor = false;
            btnConfStreak.Click += btnConfStreak_Click;
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
            lblStreakDone.Location = new Point(299, 0);
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
            flpHabitStreak.Size = new Size(781, 372);
            flpHabitStreak.TabIndex = 8;
            // 
            // HabitTitlePanel
            // 
            HabitTitlePanel.BackColor = Color.FromArgb(208, 221, 208);
            HabitTitlePanel.Controls.Add(lblName);
            HabitTitlePanel.Controls.Add(lblDesc);
            HabitTitlePanel.Dock = DockStyle.Top;
            HabitTitlePanel.Location = new Point(0, 0);
            HabitTitlePanel.Name = "HabitTitlePanel";
            HabitTitlePanel.Size = new Size(781, 36);
            HabitTitlePanel.TabIndex = 1;
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
            // BasePanelHabit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 408);
            Controls.Add(HabitPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BasePanelHabit";
            StartPosition = FormStartPosition.Manual;
            Text = "BasePanelHabit";
            HabitPanel.ResumeLayout(false);
            StreakPanel.ResumeLayout(false);
            StreakPanel.PerformLayout();
            HabitTitlePanel.ResumeLayout(false);
            HabitTitlePanel.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Panel StreakPanel;
        private Button btnConfStreak;
        private Label lblDate;
        private Label lblStreakDone;
        private Panel HabitPanel;
        private FlowLayoutPanel flpHabitStreak;
        private Panel HabitTitlePanel;
        private Label lblName;
        private Label lblDesc;
        private ReaLTaiizor.Controls.FoxCheckBox chStreak;
    }
}