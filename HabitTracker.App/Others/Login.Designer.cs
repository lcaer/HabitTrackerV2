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
            lblTitle_loginPanel = new Label();
            txtUser = new TextBox();
            btnEnter = new ReaLTaiizor.Controls.HopeRoundButton();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lklblRegisterUser = new LinkLabel();
            lblUser = new Label();
            SuspendLayout();
            // 
            // lblTitle_loginPanel
            // 
            lblTitle_loginPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle_loginPanel.AutoSize = true;
            lblTitle_loginPanel.Font = new Font("Sitka Text", 25.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle_loginPanel.Location = new Point(167, 82);
            lblTitle_loginPanel.Name = "lblTitle_loginPanel";
            lblTitle_loginPanel.Size = new Size(140, 62);
            lblTitle_loginPanel.TabIndex = 26;
            lblTitle_loginPanel.Text = "Login";
            lblTitle_loginPanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUser.BackColor = Color.FromArgb(208, 221, 208);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.ForeColor = Color.FromArgb(101, 92, 86);
            txtUser.Location = new Point(77, 195);
            txtUser.MinimumSize = new Size(0, 25);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(309, 25);
            txtUser.TabIndex = 29;
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
            btnEnter.Location = new Point(277, 324);
            btnEnter.Name = "btnEnter";
            btnEnter.PrimaryColor = Color.FromArgb(48, 52, 55);
            btnEnter.Size = new Size(109, 43);
            btnEnter.SuccessColor = Color.FromArgb(103, 194, 58);
            btnEnter.TabIndex = 32;
            btnEnter.Text = "Entrar";
            btnEnter.TextColor = Color.FromArgb(208, 221, 208);
            btnEnter.WarningColor = Color.FromArgb(230, 162, 60);
            btnEnter.Click += btnEnter_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.FromArgb(208, 221, 208);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.FromArgb(101, 92, 86);
            txtPassword.Location = new Point(77, 270);
            txtPassword.MinimumSize = new Size(0, 25);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(309, 25);
            txtPassword.TabIndex = 31;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Sitka Display", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(101, 92, 86);
            lblPassword.Location = new Point(77, 230);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 39);
            lblPassword.TabIndex = 30;
            lblPassword.Text = "Senha";
            // 
            // lklblRegisterUser
            // 
            lklblRegisterUser.ActiveLinkColor = Color.FromArgb(155, 184, 153);
            lklblRegisterUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lklblRegisterUser.AutoSize = true;
            lklblRegisterUser.DisabledLinkColor = Color.FromArgb(101, 92, 86);
            lklblRegisterUser.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lklblRegisterUser.ForeColor = Color.FromArgb(101, 92, 86);
            lklblRegisterUser.LinkColor = Color.FromArgb(101, 92, 86);
            lklblRegisterUser.Location = new Point(85, 388);
            lklblRegisterUser.Name = "lklblRegisterUser";
            lklblRegisterUser.Size = new Size(288, 33);
            lklblRegisterUser.TabIndex = 27;
            lklblRegisterUser.TabStop = true;
            lklblRegisterUser.Text = "Se não tiver login, clique aqui!";
            lklblRegisterUser.VisitedLinkColor = Color.FromArgb(101, 92, 86);
            lklblRegisterUser.LinkClicked += lklblRegisterUser_LinkClicked;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Sitka Display", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(101, 92, 86);
            lblUser.Location = new Point(77, 155);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(100, 39);
            lblUser.TabIndex = 28;
            lblUser.Text = "Usuário";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 450);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle_loginPanel;
        private TextBox txtUser;
        private ReaLTaiizor.Controls.HopeRoundButton btnEnter;
        private TextBox txtPassword;
        private Label lblPassword;
        private LinkLabel lklblRegisterUser;
        private Label lblUser;
    }
}