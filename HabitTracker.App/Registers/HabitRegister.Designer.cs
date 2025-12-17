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
            lblName = new Label();
            txtName = new TextBox();
            btnRegister = new ReaLTaiizor.Controls.HopeRoundButton();
            lblDescription = new Label();
            lblTitle_RegisterUser = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Sitka Display", 12F);
            lblName.ForeColor = Color.FromArgb(101, 92, 86);
            lblName.Location = new Point(57, 135);
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 29);
            lblName.TabIndex = 59;
            lblName.Text = "Nome";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.BackColor = Color.FromArgb(208, 221, 208);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Sitka Display", 12F);
            txtName.ForeColor = Color.FromArgb(101, 92, 86);
            txtName.Location = new Point(57, 167);
            txtName.MinimumSize = new Size(0, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(309, 26);
            txtName.TabIndex = 60;
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
            btnRegister.Location = new Point(618, 80);
            btnRegister.Name = "btnRegister";
            btnRegister.PrimaryColor = Color.FromArgb(48, 52, 55);
            btnRegister.Size = new Size(132, 43);
            btnRegister.SuccessColor = Color.FromArgb(103, 194, 58);
            btnRegister.TabIndex = 54;
            btnRegister.Text = "Cadastrar";
            btnRegister.TextColor = Color.FromArgb(208, 221, 208);
            btnRegister.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Sitka Display", 12F);
            lblDescription.ForeColor = Color.FromArgb(101, 92, 86);
            lblDescription.Location = new Point(57, 216);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(90, 29);
            lblDescription.TabIndex = 50;
            lblDescription.Text = "Descrição";
            // 
            // lblTitle_RegisterUser
            // 
            lblTitle_RegisterUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle_RegisterUser.AutoSize = true;
            lblTitle_RegisterUser.Font = new Font("Sitka Text", 15F);
            lblTitle_RegisterUser.Location = new Point(57, 80);
            lblTitle_RegisterUser.Name = "lblTitle_RegisterUser";
            lblTitle_RegisterUser.Size = new Size(202, 36);
            lblTitle_RegisterUser.TabIndex = 48;
            lblTitle_RegisterUser.Text = "Cadastro Hábito";
            lblTitle_RegisterUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.FromArgb(208, 221, 208);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Sitka Display", 12F);
            txtEmail.ForeColor = Color.FromArgb(101, 92, 86);
            txtEmail.Location = new Point(57, 248);
            txtEmail.MinimumSize = new Size(0, 25);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 126);
            txtEmail.TabIndex = 51;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 12F);
            label2.ForeColor = Color.FromArgb(101, 92, 86);
            label2.Location = new Point(636, 135);
            label2.Name = "label2";
            label2.Size = new Size(47, 29);
            label2.TabIndex = 63;
            label2.Text = "Dias";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(208, 221, 208);
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.Font = new Font("Microsoft Yi Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.ForeColor = Color.FromArgb(101, 92, 86);
            numericUpDown1.Location = new Point(636, 167);
            numericUpDown1.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(107, 24);
            numericUpDown1.TabIndex = 65;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 12F);
            label1.ForeColor = Color.FromArgb(101, 92, 86);
            label1.Location = new Point(409, 135);
            label1.Name = "label1";
            label1.Size = new Size(42, 29);
            label1.TabIndex = 66;
            label1.Text = "Cor";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(208, 221, 208);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sitka Display", 12F);
            textBox1.ForeColor = Color.FromArgb(101, 92, 86);
            textBox1.Location = new Point(409, 167);
            textBox1.MinimumSize = new Size(0, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 26);
            textBox1.TabIndex = 67;
            // 
            // HabitRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(btnRegister);
            Controls.Add(lblDescription);
            Controls.Add(txtEmail);
            Controls.Add(lblTitle_RegisterUser);
            Name = "HabitRegister";
            Text = "HabitRegister";
            Load += HabitRegister_Load;
            Controls.SetChildIndex(lblTitle_RegisterUser, 0);
            Controls.SetChildIndex(txtEmail, 0);
            Controls.SetChildIndex(lblDescription, 0);
            Controls.SetChildIndex(btnRegister, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(lblName, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(numericUpDown1, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(label1, 0);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private TextBox txtName;
        private ReaLTaiizor.Controls.HopeRoundButton btnRegister;
        private Label lblDescription;
        private Label lblTitle_RegisterUser;
        private TextBox txtEmail;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private TextBox textBox1;
    }
}