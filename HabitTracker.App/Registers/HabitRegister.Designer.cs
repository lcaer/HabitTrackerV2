namespace HabitTracker.App.Registers
{
    partial class HabitRegister
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
            lblColor = new Label();
            txtColor = new TextBox();
            nudGoalStreak = new NumericUpDown();
            lblGoalStreak = new Label();
            lblName = new Label();
            txtName = new TextBox();
            btnRegister = new ReaLTaiizor.Controls.HopeRoundButton();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblTitle_RegisterHabit = new Label();
            datePicker = new ReaLTaiizor.Controls.HopeDatePicker();
            lblDate = new Label();
            ((System.ComponentModel.ISupportInitialize)nudGoalStreak).BeginInit();
            SuspendLayout();
            // 
            // lblColor
            // 
            lblColor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Sitka Display", 12F);
            lblColor.ForeColor = Color.FromArgb(101, 92, 86);
            lblColor.Location = new Point(74, 401);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(42, 29);
            lblColor.TabIndex = 76;
            lblColor.Text = "Cor";
            // 
            // txtColor
            // 
            txtColor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtColor.BackColor = Color.FromArgb(208, 221, 208);
            txtColor.BorderStyle = BorderStyle.None;
            txtColor.Font = new Font("Sitka Display", 12F);
            txtColor.ForeColor = Color.FromArgb(101, 92, 86);
            txtColor.Location = new Point(74, 433);
            txtColor.MinimumSize = new Size(0, 25);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(189, 26);
            txtColor.TabIndex = 77;
            // 
            // nudGoalStreak
            // 
            nudGoalStreak.BackColor = Color.FromArgb(208, 221, 208);
            nudGoalStreak.BorderStyle = BorderStyle.None;
            nudGoalStreak.Font = new Font("Microsoft Yi Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudGoalStreak.ForeColor = Color.FromArgb(101, 92, 86);
            nudGoalStreak.Location = new Point(307, 433);
            nudGoalStreak.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            nudGoalStreak.Name = "nudGoalStreak";
            nudGoalStreak.Size = new Size(80, 24);
            nudGoalStreak.TabIndex = 75;
            nudGoalStreak.TextAlign = HorizontalAlignment.Center;
            // 
            // lblGoalStreak
            // 
            lblGoalStreak.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblGoalStreak.AutoSize = true;
            lblGoalStreak.Font = new Font("Sitka Display", 12F);
            lblGoalStreak.ForeColor = Color.FromArgb(101, 92, 86);
            lblGoalStreak.Location = new Point(307, 401);
            lblGoalStreak.Name = "lblGoalStreak";
            lblGoalStreak.Size = new Size(47, 29);
            lblGoalStreak.TabIndex = 74;
            lblGoalStreak.Text = "Dias";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Sitka Display", 12F);
            lblName.ForeColor = Color.FromArgb(101, 92, 86);
            lblName.Location = new Point(74, 135);
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 29);
            lblName.TabIndex = 72;
            lblName.Text = "Nome";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.BackColor = Color.FromArgb(208, 221, 208);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Sitka Display", 12F);
            txtName.ForeColor = Color.FromArgb(101, 92, 86);
            txtName.Location = new Point(74, 167);
            txtName.MinimumSize = new Size(0, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(309, 26);
            txtName.TabIndex = 73;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegister.BorderColor = Color.FromArgb(48, 52, 55);
            btnRegister.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnRegister.DangerColor = Color.FromArgb(245, 108, 108);
            btnRegister.DefaultColor = Color.FromArgb(48, 52, 55);
            btnRegister.Font = new Font("Sitka Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.FromArgb(208, 221, 208);
            btnRegister.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnRegister.InfoColor = Color.FromArgb(208, 221, 208);
            btnRegister.Location = new Point(580, 482);
            btnRegister.Name = "btnRegister";
            btnRegister.PrimaryColor = Color.FromArgb(48, 52, 55);
            btnRegister.Size = new Size(132, 43);
            btnRegister.SuccessColor = Color.FromArgb(103, 194, 58);
            btnRegister.TabIndex = 71;
            btnRegister.Text = "Cadastrar";
            btnRegister.TextColor = Color.FromArgb(208, 221, 208);
            btnRegister.WarningColor = Color.FromArgb(230, 162, 60);
            btnRegister.Click += btnRegister_Click;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Sitka Display", 12F);
            lblDescription.ForeColor = Color.FromArgb(101, 92, 86);
            lblDescription.Location = new Point(74, 216);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(90, 29);
            lblDescription.TabIndex = 69;
            lblDescription.Text = "Descrição";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.BackColor = Color.FromArgb(208, 221, 208);
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Sitka Display", 12F);
            txtDescription.ForeColor = Color.FromArgb(101, 92, 86);
            txtDescription.Location = new Point(78, 248);
            txtDescription.MinimumSize = new Size(0, 25);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(309, 126);
            txtDescription.TabIndex = 70;
            // 
            // lblTitle_RegisterHabit
            // 
            lblTitle_RegisterHabit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle_RegisterHabit.AutoSize = true;
            lblTitle_RegisterHabit.Font = new Font("Sitka Text", 15F);
            lblTitle_RegisterHabit.Location = new Point(307, 82);
            lblTitle_RegisterHabit.Name = "lblTitle_RegisterHabit";
            lblTitle_RegisterHabit.Size = new Size(202, 36);
            lblTitle_RegisterHabit.TabIndex = 68;
            lblTitle_RegisterHabit.Text = "Cadastro Hábito";
            lblTitle_RegisterHabit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // datePicker
            // 
            datePicker.BackColor = Color.FromArgb(208, 221, 208);
            datePicker.BorderColor = Color.FromArgb(208, 221, 208);
            datePicker.Date = new DateTime(2025, 12, 17, 0, 0, 0, 0);
            datePicker.DayNames = "DSTQQSS";
            datePicker.DaysTextColor = Color.FromArgb(48, 52, 55);
            datePicker.DayTextColorA = Color.FromArgb(101, 92, 86);
            datePicker.DayTextColorB = Color.FromArgb(147, 158, 147);
            datePicker.Font = new Font("Sitka Display", 12F);
            datePicker.HeaderFormat = "{1} de {0}";
            datePicker.HeaderTextColor = Color.FromArgb(48, 49, 51);
            datePicker.HeadLineColor = Color.FromArgb(48, 49, 51);
            datePicker.HoverColor = Color.FromArgb(155, 184, 153);
            datePicker.Location = new Point(457, 167);
            datePicker.Name = "datePicker";
            datePicker.NMColor = Color.FromArgb(48, 49, 51);
            datePicker.NMHoverColor = Color.FromArgb(155, 184, 153);
            datePicker.NYColor = Color.FromArgb(48, 49, 51);
            datePicker.NYHoverColor = Color.FromArgb(155, 184, 153);
            datePicker.PMColor = Color.FromArgb(48, 49, 51);
            datePicker.PMHoverColor = Color.FromArgb(155, 184, 153);
            datePicker.PYColor = Color.FromArgb(48, 49, 51);
            datePicker.PYHoverColor = Color.FromArgb(155, 184, 153);
            datePicker.SelectedBackColor = Color.FromArgb(155, 184, 153);
            datePicker.SelectedTextColor = Color.FromArgb(48, 52, 55);
            datePicker.Size = new Size(250, 270);
            datePicker.TabIndex = 78;
            datePicker.ValueTextColor = Color.FromArgb(48, 52, 55);
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Sitka Display", 12F);
            lblDate.ForeColor = Color.FromArgb(101, 92, 86);
            lblDate.Location = new Point(457, 135);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(49, 29);
            lblDate.TabIndex = 79;
            lblDate.Text = "Data";
            // 
            // HabitRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 243, 229);
            ClientSize = new Size(800, 571);
            Controls.Add(lblDate);
            Controls.Add(datePicker);
            Controls.Add(lblColor);
            Controls.Add(txtColor);
            Controls.Add(nudGoalStreak);
            Controls.Add(lblGoalStreak);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(btnRegister);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblTitle_RegisterHabit);
            Name = "HabitRegister";
            Text = "HabitRegister";
            Controls.SetChildIndex(lblTitle_RegisterHabit, 0);
            Controls.SetChildIndex(txtDescription, 0);
            Controls.SetChildIndex(lblDescription, 0);
            Controls.SetChildIndex(btnRegister, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(lblName, 0);
            Controls.SetChildIndex(lblGoalStreak, 0);
            Controls.SetChildIndex(nudGoalStreak, 0);
            Controls.SetChildIndex(txtColor, 0);
            Controls.SetChildIndex(lblColor, 0);
            Controls.SetChildIndex(datePicker, 0);
            Controls.SetChildIndex(lblDate, 0);
            ((System.ComponentModel.ISupportInitialize)nudGoalStreak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblColor;
        private TextBox txtColor;
        private NumericUpDown nudGoalStreak;
        private Label lblGoalStreak;
        private Label lblName;
        private TextBox txtName;
        private ReaLTaiizor.Controls.HopeRoundButton btnRegister;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblTitle_RegisterHabit;
        private ReaLTaiizor.Controls.HopeDatePicker datePicker;
        private Label lblDate;
    }
}