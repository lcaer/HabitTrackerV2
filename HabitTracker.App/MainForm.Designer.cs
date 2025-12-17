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
            panelUser.SuspendLayout();
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 252, 239);
            ClientSize = new Size(800, 450);
            Controls.Add(panelUser);
            IsMdiContainer = true;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Controls.SetChildIndex(panelUser, 0);
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Label lblUser;
        public Panel panelUser;
    }
}
