namespace HabitTracker.App.Others
{
    partial class Login
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
            btnEnter = new ReaLTaiizor.Controls.HopeRoundButton();
            lklblRegisterUser = new LinkLabel();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblUser = new Label();
            txtUser = new TextBox();
            lblTitle_loginPanel = new Label();
            chbPassword = new CheckBox();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEnter.BorderColor = Color.FromArgb(48, 52, 55);
            btnEnter.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnEnter.DangerColor = Color.FromArgb(245, 108, 108);
            btnEnter.DefaultColor = Color.FromArgb(48, 52, 55);
            btnEnter.Font = new Font("Sitka Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.FromArgb(208, 221, 208);
            btnEnter.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnEnter.InfoColor = Color.FromArgb(208, 221, 208);
            btnEnter.Location = new Point(272, 295);
            btnEnter.Name = "btnEnter";
            btnEnter.PrimaryColor = Color.FromArgb(48, 52, 55);
            btnEnter.Size = new Size(109, 45);
            btnEnter.SuccessColor = Color.FromArgb(103, 194, 58);
            btnEnter.TabIndex = 40;
            btnEnter.Text = "Entrar";
            btnEnter.TextColor = Color.FromArgb(208, 221, 208);
            btnEnter.WarningColor = Color.FromArgb(230, 162, 60);
            btnEnter.Click += btnEnter_Click;
            // 
            // lklblRegisterUser
            // 
            lklblRegisterUser.ActiveLinkColor = Color.FromArgb(155, 184, 153);
            lklblRegisterUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lklblRegisterUser.AutoSize = true;
            lklblRegisterUser.DisabledLinkColor = Color.FromArgb(101, 92, 86);
            lklblRegisterUser.Font = new Font("Sitka Display", 12F);
            lklblRegisterUser.ForeColor = Color.FromArgb(101, 92, 86);
            lklblRegisterUser.LinkColor = Color.FromArgb(101, 92, 86);
            lklblRegisterUser.Location = new Point(90, 355);
            lklblRegisterUser.Name = "lklblRegisterUser";
            lklblRegisterUser.Size = new Size(256, 29);
            lklblRegisterUser.TabIndex = 35;
            lklblRegisterUser.TabStop = true;
            lklblRegisterUser.Text = "Se não tiver login, clique aqui!";
            lklblRegisterUser.VisitedLinkColor = Color.FromArgb(101, 92, 86);
            lklblRegisterUser.LinkClicked += lklblRegisterUser_LinkClicked;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Sitka Display", 12F);
            lblPassword.ForeColor = Color.FromArgb(101, 92, 86);
            lblPassword.Location = new Point(72, 210);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(62, 29);
            lblPassword.TabIndex = 38;
            lblPassword.Text = "Senha";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.FromArgb(208, 221, 208);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Sitka Display", 12F);
            txtPassword.ForeColor = Color.FromArgb(101, 92, 86);
            txtPassword.Location = new Point(72, 242);
            txtPassword.MinimumSize = new Size(0, 25);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(309, 26);
            txtPassword.TabIndex = 39;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Sitka Display", 12F);
            lblUser.ForeColor = Color.FromArgb(101, 92, 86);
            lblUser.Location = new Point(72, 135);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(76, 29);
            lblUser.TabIndex = 36;
            lblUser.Text = "Usuário";
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUser.BackColor = Color.FromArgb(208, 221, 208);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Sitka Display", 12F);
            txtUser.ForeColor = Color.FromArgb(101, 92, 86);
            txtUser.Location = new Point(72, 167);
            txtUser.MinimumSize = new Size(0, 25);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(309, 26);
            txtUser.TabIndex = 37;
            // 
            // lblTitle_loginPanel
            // 
            lblTitle_loginPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle_loginPanel.AutoSize = true;
            lblTitle_loginPanel.Font = new Font("Sitka Text", 15F);
            lblTitle_loginPanel.Location = new Point(189, 88);
            lblTitle_loginPanel.Name = "lblTitle_loginPanel";
            lblTitle_loginPanel.Size = new Size(81, 36);
            lblTitle_loginPanel.TabIndex = 34;
            lblTitle_loginPanel.Text = "Login";
            lblTitle_loginPanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chbPassword
            // 
            chbPassword.AutoSize = true;
            chbPassword.FlatAppearance.BorderSize = 0;
            chbPassword.Font = new Font("Sitka Display", 10F);
            chbPassword.ForeColor = Color.FromArgb(101, 92, 86);
            chbPassword.Location = new Point(241, 213);
            chbPassword.Name = "chbPassword";
            chbPassword.RightToLeft = RightToLeft.No;
            chbPassword.Size = new Size(140, 28);
            chbPassword.TabIndex = 41;
            chbPassword.Text = "Mostrar Senha?";
            chbPassword.UseVisualStyleBackColor = true;
            chbPassword.CheckedChanged += chbPassword_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 418);
            Controls.Add(chbPassword);
            Controls.Add(btnEnter);
            Controls.Add(lklblRegisterUser);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblUser);
            Controls.Add(txtUser);
            Controls.Add(lblTitle_loginPanel);
            Name = "Login";
            Text = "Login";
            Controls.SetChildIndex(lblTitle_loginPanel, 0);
            Controls.SetChildIndex(txtUser, 0);
            Controls.SetChildIndex(lblUser, 0);
            Controls.SetChildIndex(txtPassword, 0);
            Controls.SetChildIndex(lblPassword, 0);
            Controls.SetChildIndex(lklblRegisterUser, 0);
            Controls.SetChildIndex(btnEnter, 0);
            Controls.SetChildIndex(chbPassword, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HopeRoundButton btnEnter;
        private LinkLabel lklblRegisterUser;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblUser;
        private TextBox txtUser;
        private Label lblTitle_loginPanel;
        private CheckBox chbPassword;
    }
}