namespace HabitTracker.App.Registers
{
    partial class UserRegister
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
            btnRegister = new ReaLTaiizor.Controls.HopeRoundButton();
            lklblLogin = new LinkLabel();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTitle_RegisterUser = new Label();
            lblConfPassword = new Label();
            txtConfPassword = new TextBox();
            lblConfEmail = new Label();
            txtConfEmail = new TextBox();
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            chbPassword = new CheckBox();
            chbConfPassword = new CheckBox();
            SuspendLayout();
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
            btnRegister.Location = new Point(618, 385);
            btnRegister.Name = "btnRegister";
            btnRegister.PrimaryColor = Color.FromArgb(48, 52, 55);
            btnRegister.Size = new Size(132, 43);
            btnRegister.SuccessColor = Color.FromArgb(103, 194, 58);
            btnRegister.TabIndex = 39;
            btnRegister.Text = "Cadastrar";
            btnRegister.TextColor = Color.FromArgb(208, 221, 208);
            btnRegister.WarningColor = Color.FromArgb(230, 162, 60);
            btnRegister.Click += btnRegister_Click;
            // 
            // lklblLogin
            // 
            lklblLogin.ActiveLinkColor = Color.FromArgb(155, 184, 153);
            lklblLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lklblLogin.AutoSize = true;
            lklblLogin.DisabledLinkColor = Color.FromArgb(101, 92, 86);
            lklblLogin.Font = new Font("Sitka Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lklblLogin.ForeColor = Color.FromArgb(101, 92, 86);
            lklblLogin.LinkColor = Color.FromArgb(101, 92, 86);
            lklblLogin.Location = new Point(64, 385);
            lklblLogin.Name = "lklblLogin";
            lklblLogin.Size = new Size(221, 29);
            lklblLogin.TabIndex = 34;
            lklblLogin.TabStop = true;
            lklblLogin.Text = "Se tiver login, clique aqui!";
            lklblLogin.VisitedLinkColor = Color.FromArgb(101, 92, 86);
            lklblLogin.LinkClicked += lklblLogin_LinkClicked;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Sitka Display", 12F);
            lblPassword.ForeColor = Color.FromArgb(101, 92, 86);
            lblPassword.Location = new Point(64, 296);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(62, 29);
            lblPassword.TabIndex = 37;
            lblPassword.Text = "Senha";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.FromArgb(208, 221, 208);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Sitka Display", 12F);
            txtPassword.ForeColor = Color.FromArgb(101, 92, 86);
            txtPassword.Location = new Point(64, 328);
            txtPassword.MinimumSize = new Size(0, 25);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(309, 26);
            txtPassword.TabIndex = 38;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Sitka Display", 12F);
            lblEmail.ForeColor = Color.FromArgb(101, 92, 86);
            lblEmail.Location = new Point(64, 221);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 29);
            lblEmail.TabIndex = 35;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = Color.FromArgb(208, 221, 208);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Sitka Display", 12F);
            txtEmail.ForeColor = Color.FromArgb(101, 92, 86);
            txtEmail.Location = new Point(64, 253);
            txtEmail.MinimumSize = new Size(0, 25);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 26);
            txtEmail.TabIndex = 36;
            // 
            // lblTitle_RegisterUser
            // 
            lblTitle_RegisterUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle_RegisterUser.AutoSize = true;
            lblTitle_RegisterUser.Font = new Font("Sitka Text", 15F);
            lblTitle_RegisterUser.Location = new Point(293, 85);
            lblTitle_RegisterUser.Name = "lblTitle_RegisterUser";
            lblTitle_RegisterUser.Size = new Size(216, 36);
            lblTitle_RegisterUser.TabIndex = 33;
            lblTitle_RegisterUser.Text = "Cadastro Usuário";
            lblTitle_RegisterUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConfPassword
            // 
            lblConfPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblConfPassword.AutoSize = true;
            lblConfPassword.Font = new Font("Sitka Display", 12F);
            lblConfPassword.ForeColor = Color.FromArgb(101, 92, 86);
            lblConfPassword.Location = new Point(433, 296);
            lblConfPassword.Name = "lblConfPassword";
            lblConfPassword.Size = new Size(151, 29);
            lblConfPassword.TabIndex = 42;
            lblConfPassword.Text = "Confirmar Senha";
            // 
            // txtConfPassword
            // 
            txtConfPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtConfPassword.BackColor = Color.FromArgb(208, 221, 208);
            txtConfPassword.BorderStyle = BorderStyle.None;
            txtConfPassword.Font = new Font("Sitka Display", 12F);
            txtConfPassword.ForeColor = Color.FromArgb(101, 92, 86);
            txtConfPassword.Location = new Point(433, 328);
            txtConfPassword.MinimumSize = new Size(0, 25);
            txtConfPassword.Name = "txtConfPassword";
            txtConfPassword.Size = new Size(309, 26);
            txtConfPassword.TabIndex = 43;
            txtConfPassword.UseSystemPasswordChar = true;
            // 
            // lblConfEmail
            // 
            lblConfEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblConfEmail.AutoSize = true;
            lblConfEmail.Font = new Font("Sitka Display", 12F);
            lblConfEmail.ForeColor = Color.FromArgb(101, 92, 86);
            lblConfEmail.Location = new Point(433, 221);
            lblConfEmail.Name = "lblConfEmail";
            lblConfEmail.Size = new Size(148, 29);
            lblConfEmail.TabIndex = 40;
            lblConfEmail.Text = "Confirmar Email";
            // 
            // txtConfEmail
            // 
            txtConfEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtConfEmail.BackColor = Color.FromArgb(208, 221, 208);
            txtConfEmail.BorderStyle = BorderStyle.None;
            txtConfEmail.Font = new Font("Sitka Display", 12F);
            txtConfEmail.ForeColor = Color.FromArgb(101, 92, 86);
            txtConfEmail.Location = new Point(433, 253);
            txtConfEmail.MinimumSize = new Size(0, 25);
            txtConfEmail.Name = "txtConfEmail";
            txtConfEmail.Size = new Size(309, 26);
            txtConfEmail.TabIndex = 41;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Sitka Display", 12F);
            lblLogin.ForeColor = Color.FromArgb(101, 92, 86);
            lblLogin.Location = new Point(433, 140);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(58, 29);
            lblLogin.TabIndex = 46;
            lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLogin.BackColor = Color.FromArgb(208, 221, 208);
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Sitka Display", 12F);
            txtLogin.ForeColor = Color.FromArgb(101, 92, 86);
            txtLogin.Location = new Point(433, 172);
            txtLogin.MinimumSize = new Size(0, 25);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(309, 26);
            txtLogin.TabIndex = 47;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Sitka Display", 12F);
            lblName.ForeColor = Color.FromArgb(101, 92, 86);
            lblName.Location = new Point(64, 140);
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 29);
            lblName.TabIndex = 44;
            lblName.Text = "Nome";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.BackColor = Color.FromArgb(208, 221, 208);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Sitka Display", 12F);
            txtName.ForeColor = Color.FromArgb(101, 92, 86);
            txtName.Location = new Point(64, 172);
            txtName.MinimumSize = new Size(0, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(309, 26);
            txtName.TabIndex = 45;
            // 
            // chbPassword
            // 
            chbPassword.AutoSize = true;
            chbPassword.FlatAppearance.BorderSize = 0;
            chbPassword.Font = new Font("Sitka Display", 10F);
            chbPassword.ForeColor = Color.FromArgb(101, 92, 86);
            chbPassword.Location = new Point(233, 299);
            chbPassword.Name = "chbPassword";
            chbPassword.RightToLeft = RightToLeft.No;
            chbPassword.Size = new Size(140, 28);
            chbPassword.TabIndex = 48;
            chbPassword.Text = "Mostrar Senha?";
            chbPassword.UseVisualStyleBackColor = true;
            chbPassword.CheckedChanged += chbPassword_CheckedChanged;
            // 
            // chbConfPassword
            // 
            chbConfPassword.AutoSize = true;
            chbConfPassword.FlatAppearance.BorderSize = 0;
            chbConfPassword.Font = new Font("Sitka Display", 10F);
            chbConfPassword.ForeColor = Color.FromArgb(101, 92, 86);
            chbConfPassword.Location = new Point(602, 299);
            chbConfPassword.Name = "chbConfPassword";
            chbConfPassword.RightToLeft = RightToLeft.No;
            chbConfPassword.Size = new Size(140, 28);
            chbConfPassword.TabIndex = 49;
            chbConfPassword.Text = "Mostrar Senha?";
            chbConfPassword.UseVisualStyleBackColor = true;
            chbConfPassword.CheckedChanged += chbConfPassword_CheckedChanged;
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 243, 229);
            ClientSize = new Size(800, 450);
            Controls.Add(chbConfPassword);
            Controls.Add(chbPassword);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblConfPassword);
            Controls.Add(txtConfPassword);
            Controls.Add(lblConfEmail);
            Controls.Add(txtConfEmail);
            Controls.Add(btnRegister);
            Controls.Add(lklblLogin);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblTitle_RegisterUser);
            Name = "UserRegister";
            Text = "UserRegister";
            Controls.SetChildIndex(lblTitle_RegisterUser, 0);
            Controls.SetChildIndex(txtEmail, 0);
            Controls.SetChildIndex(lblEmail, 0);
            Controls.SetChildIndex(txtPassword, 0);
            Controls.SetChildIndex(lblPassword, 0);
            Controls.SetChildIndex(lklblLogin, 0);
            Controls.SetChildIndex(btnRegister, 0);
            Controls.SetChildIndex(txtConfEmail, 0);
            Controls.SetChildIndex(lblConfEmail, 0);
            Controls.SetChildIndex(txtConfPassword, 0);
            Controls.SetChildIndex(lblConfPassword, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(lblName, 0);
            Controls.SetChildIndex(txtLogin, 0);
            Controls.SetChildIndex(lblLogin, 0);
            Controls.SetChildIndex(chbPassword, 0);
            Controls.SetChildIndex(chbConfPassword, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel lklblLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblTitle_RegisterUser;
        private Label lblConfPassword;
        private TextBox txtConfPassword;
        private Label lblConfEmail;
        private TextBox txtConfEmail;
        private Label lblLogin;
        private TextBox txtLogin;
        private Label lblName;
        private TextBox txtName;
        private CheckBox chbPassword;
        private CheckBox chbConfPassword;
        private ReaLTaiizor.Controls.HopeRoundButton btnRegister;
    }
}