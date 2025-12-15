namespace HabitTracker.App.Bases
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            controlPanel = new Panel();
            btnMinimizeForm = new Button();
            btnMaximizeForm = new Button();
            btnCloseForm = new Button();
            lblTitle_controlPanel = new Label();
            controlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // controlPanel
            // 
            controlPanel.BackColor = Color.FromArgb(155, 184, 153);
            controlPanel.Controls.Add(btnMinimizeForm);
            controlPanel.Controls.Add(btnMaximizeForm);
            controlPanel.Controls.Add(btnCloseForm);
            controlPanel.Controls.Add(lblTitle_controlPanel);
            controlPanel.Dock = DockStyle.Top;
            controlPanel.Location = new Point(0, 0);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(800, 57);
            controlPanel.TabIndex = 0;
            // 
            // btnMinimizeForm
            // 
            btnMinimizeForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizeForm.FlatAppearance.BorderSize = 0;
            btnMinimizeForm.FlatStyle = FlatStyle.Flat;
            btnMinimizeForm.Image = (Image)resources.GetObject("btnMinimizeForm.Image");
            btnMinimizeForm.ImageAlign = ContentAlignment.MiddleRight;
            btnMinimizeForm.Location = new Point(680, 12);
            btnMinimizeForm.Name = "btnMinimizeForm";
            btnMinimizeForm.Size = new Size(32, 34);
            btnMinimizeForm.TabIndex = 9;
            btnMinimizeForm.UseVisualStyleBackColor = true;
            btnMinimizeForm.Click += btnMinimizeForm_Click;
            // 
            // btnMaximizeForm
            // 
            btnMaximizeForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizeForm.FlatAppearance.BorderSize = 0;
            btnMaximizeForm.FlatStyle = FlatStyle.Flat;
            btnMaximizeForm.Image = (Image)resources.GetObject("btnMaximizeForm.Image");
            btnMaximizeForm.ImageAlign = ContentAlignment.MiddleRight;
            btnMaximizeForm.Location = new Point(718, 12);
            btnMaximizeForm.Name = "btnMaximizeForm";
            btnMaximizeForm.Size = new Size(32, 34);
            btnMaximizeForm.TabIndex = 8;
            btnMaximizeForm.UseVisualStyleBackColor = true;
            btnMaximizeForm.Click += btnMaximizeForm_Click;
            // 
            // btnCloseForm
            // 
            btnCloseForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseForm.FlatAppearance.BorderSize = 0;
            btnCloseForm.FlatStyle = FlatStyle.Flat;
            btnCloseForm.Image = (Image)resources.GetObject("btnCloseForm.Image");
            btnCloseForm.ImageAlign = ContentAlignment.MiddleRight;
            btnCloseForm.Location = new Point(756, 12);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(32, 34);
            btnCloseForm.TabIndex = 7;
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Click += btnCloseForm_Click;
            // 
            // lblTitle_controlPanel
            // 
            lblTitle_controlPanel.Dock = DockStyle.Left;
            lblTitle_controlPanel.FlatStyle = FlatStyle.Flat;
            lblTitle_controlPanel.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle_controlPanel.Location = new Point(0, 0);
            lblTitle_controlPanel.Margin = new Padding(0);
            lblTitle_controlPanel.Name = "lblTitle_controlPanel";
            lblTitle_controlPanel.Size = new Size(126, 57);
            lblTitle_controlPanel.TabIndex = 4;
            lblTitle_controlPanel.Text = "HabitTrack";
            lblTitle_controlPanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 252, 239);
            BackgroundImageLayout = ImageLayout.Center;
            CancelButton = btnCloseForm;
            ClientSize = new Size(800, 472);
            ControlBox = false;
            Controls.Add(controlPanel);
            DoubleBuffered = true;
            Font = new Font("Sitka Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(48, 52, 55);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            controlPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel controlPanel;
        private Button btnMaximizeForm;
        private Button btnCloseForm;
        private Label lblTitle_controlPanel;
        private Button btnMinimizeForm;
    }
}