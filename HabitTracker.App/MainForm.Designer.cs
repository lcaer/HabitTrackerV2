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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblUser = new Label();
            panelUser = new Panel();
            btnConfig = new Button();
            btnRegHabit = new Button();
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
            panelUser.Controls.Add(btnConfig);
            panelUser.Controls.Add(lblUser);
            panelUser.Dock = DockStyle.Bottom;
            panelUser.Location = new Point(0, 415);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(800, 35);
            panelUser.TabIndex = 3;
            // 
            // btnConfig
            // 
            btnConfig.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Image = (Image)resources.GetObject("btnConfig.Image");
            btnConfig.ImageAlign = ContentAlignment.MiddleRight;
            btnConfig.Location = new Point(765, 1);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(32, 34);
            btnConfig.TabIndex = 12;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Visible = false;
            btnConfig.Click += bntConfig_Click;
            // 
            // btnRegHabit
            // 
            btnRegHabit.FlatAppearance.BorderSize = 0;
            btnRegHabit.FlatStyle = FlatStyle.Flat;
            btnRegHabit.Image = (Image)resources.GetObject("btnRegHabit.Image");
            btnRegHabit.Location = new Point(841, 72);
            btnRegHabit.Name = "btnRegHabit";
            btnRegHabit.Size = new Size(50, 50);
            btnRegHabit.TabIndex = 10;
            btnRegHabit.UseVisualStyleBackColor = true;
            btnRegHabit.Visible = false;
            btnRegHabit.Click += btnRegHabit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 252, 239);
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegHabit);
            Controls.Add(panelUser);
            IsMdiContainer = true;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Controls.SetChildIndex(panelUser, 0);
            Controls.SetChildIndex(btnRegHabit, 0);
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label lblUser;
        public Panel panelUser;
        public Button btnConfig;
        public Button btnRegHabit;
    }
}
