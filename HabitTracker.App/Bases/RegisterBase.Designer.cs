namespace HabitTracker.App.Bases
{
    partial class RegisterBase
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
            tabControlRegister = new ReaLTaiizor.Controls.AirTabPage();
            tabPageRegister = new TabPage();
            panel1 = new Panel();
            btnSave = new ReaLTaiizor.Controls.HopeRoundButton();
            btnCancel = new ReaLTaiizor.Controls.HopeRoundButton();
            tabPageList = new TabPage();
            panel2 = new Panel();
            btnNew = new ReaLTaiizor.Controls.HopeRoundButton();
            btnDelete = new ReaLTaiizor.Controls.HopeRoundButton();
            btnEdit = new ReaLTaiizor.Controls.HopeRoundButton();
            dataGridViewList = new DataGridView();
            tabControlRegister.SuspendLayout();
            tabPageRegister.SuspendLayout();
            panel1.SuspendLayout();
            tabPageList.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).BeginInit();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Alignment = TabAlignment.Left;
            tabControlRegister.BaseColor = Color.FromArgb(239, 252, 239);
            tabControlRegister.Controls.Add(tabPageRegister);
            tabControlRegister.Controls.Add(tabPageList);
            tabControlRegister.Dock = DockStyle.Fill;
            tabControlRegister.Font = new Font("Sitka Display", 12F);
            tabControlRegister.ItemSize = new Size(30, 115);
            tabControlRegister.Location = new Point(0, 57);
            tabControlRegister.Multiline = true;
            tabControlRegister.Name = "tabControlRegister";
            tabControlRegister.NormalTextColor = Color.FromArgb(101, 92, 86);
            tabControlRegister.SelectedIndex = 0;
            tabControlRegister.SelectedTabBackColor = Color.FromArgb(208, 221, 208);
            tabControlRegister.SelectedTextColor = Color.FromArgb(48, 52, 55);
            tabControlRegister.ShowOuterBorders = false;
            tabControlRegister.Size = new Size(800, 393);
            tabControlRegister.SizeMode = TabSizeMode.Fixed;
            tabControlRegister.SquareColor = Color.FromArgb(155, 184, 153);
            tabControlRegister.TabCursor = Cursors.Arrow;
            tabControlRegister.TabIndex = 1;
            // 
            // tabPageRegister
            // 
            tabPageRegister.BackColor = Color.FromArgb(208, 221, 208);
            tabPageRegister.Controls.Add(panel1);
            tabPageRegister.Location = new Point(119, 4);
            tabPageRegister.Name = "tabPageRegister";
            tabPageRegister.Padding = new Padding(3);
            tabPageRegister.Size = new Size(677, 385);
            tabPageRegister.TabIndex = 0;
            tabPageRegister.Text = "Cadastrar";
            tabPageRegister.Click += tabPageRegister_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 325);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 57);
            panel1.TabIndex = 35;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.BorderColor = Color.FromArgb(48, 52, 55);
            btnSave.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSave.DangerColor = Color.FromArgb(245, 108, 108);
            btnSave.DefaultColor = Color.FromArgb(48, 52, 55);
            btnSave.Font = new Font("Sitka Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(208, 221, 208);
            btnSave.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSave.InfoColor = Color.FromArgb(208, 221, 208);
            btnSave.Location = new Point(557, 9);
            btnSave.Name = "btnSave";
            btnSave.PrimaryColor = Color.FromArgb(48, 52, 55);
            btnSave.Size = new Size(109, 43);
            btnSave.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSave.TabIndex = 33;
            btnSave.Text = "Salvar";
            btnSave.TextColor = Color.FromArgb(208, 221, 208);
            btnSave.WarningColor = Color.FromArgb(230, 162, 60);
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.BorderColor = Color.FromArgb(48, 52, 55);
            btnCancel.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCancel.DangerColor = Color.FromArgb(245, 108, 108);
            btnCancel.DefaultColor = Color.FromArgb(48, 52, 55);
            btnCancel.Font = new Font("Sitka Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(208, 221, 208);
            btnCancel.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCancel.InfoColor = Color.FromArgb(208, 221, 208);
            btnCancel.Location = new Point(428, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.PrimaryColor = Color.FromArgb(48, 52, 55);
            btnCancel.Size = new Size(123, 43);
            btnCancel.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancelar";
            btnCancel.TextColor = Color.FromArgb(208, 221, 208);
            btnCancel.WarningColor = Color.FromArgb(230, 162, 60);
            btnCancel.Click += btnCancel_Click;
            // 
            // tabPageList
            // 
            tabPageList.BackColor = Color.FromArgb(208, 221, 208);
            tabPageList.Controls.Add(panel2);
            tabPageList.Controls.Add(dataGridViewList);
            tabPageList.Location = new Point(119, 4);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(677, 385);
            tabPageList.TabIndex = 1;
            tabPageList.Text = "Consultar";
            tabPageList.Enter += tabPageList_Enter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 324);
            panel2.Name = "panel2";
            panel2.Size = new Size(671, 58);
            panel2.TabIndex = 38;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNew.BorderColor = Color.FromArgb(48, 52, 55);
            btnNew.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnNew.DangerColor = Color.FromArgb(245, 108, 108);
            btnNew.DefaultColor = Color.FromArgb(48, 52, 55);
            btnNew.Font = new Font("Sitka Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.FromArgb(208, 221, 208);
            btnNew.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnNew.InfoColor = Color.FromArgb(208, 221, 208);
            btnNew.Location = new Point(557, 10);
            btnNew.Name = "btnNew";
            btnNew.PrimaryColor = Color.FromArgb(48, 52, 55);
            btnNew.Size = new Size(108, 43);
            btnNew.SuccessColor = Color.FromArgb(103, 194, 58);
            btnNew.TabIndex = 35;
            btnNew.Text = "Novo";
            btnNew.TextColor = Color.FromArgb(208, 221, 208);
            btnNew.WarningColor = Color.FromArgb(230, 162, 60);
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BorderColor = Color.FromArgb(48, 52, 55);
            btnDelete.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnDelete.DangerColor = Color.FromArgb(245, 108, 108);
            btnDelete.DefaultColor = Color.FromArgb(48, 52, 55);
            btnDelete.Font = new Font("Sitka Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(208, 221, 208);
            btnDelete.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnDelete.InfoColor = Color.FromArgb(208, 221, 208);
            btnDelete.Location = new Point(323, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.PrimaryColor = Color.FromArgb(48, 52, 55);
            btnDelete.Size = new Size(110, 43);
            btnDelete.SuccessColor = Color.FromArgb(103, 194, 58);
            btnDelete.TabIndex = 37;
            btnDelete.Text = "Deletar";
            btnDelete.TextColor = Color.FromArgb(208, 221, 208);
            btnDelete.WarningColor = Color.FromArgb(230, 162, 60);
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEdit.BorderColor = Color.FromArgb(48, 52, 55);
            btnEdit.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnEdit.DangerColor = Color.FromArgb(245, 108, 108);
            btnEdit.DefaultColor = Color.FromArgb(48, 52, 55);
            btnEdit.Font = new Font("Sitka Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.FromArgb(208, 221, 208);
            btnEdit.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnEdit.InfoColor = Color.FromArgb(208, 221, 208);
            btnEdit.Location = new Point(440, 10);
            btnEdit.Name = "btnEdit";
            btnEdit.PrimaryColor = Color.FromArgb(48, 52, 55);
            btnEdit.Size = new Size(110, 43);
            btnEdit.SuccessColor = Color.FromArgb(103, 194, 58);
            btnEdit.TabIndex = 36;
            btnEdit.Text = "Editar";
            btnEdit.TextColor = Color.FromArgb(208, 221, 208);
            btnEdit.WarningColor = Color.FromArgb(230, 162, 60);
            btnEdit.Click += btnEdit_Click;
            // 
            // dataGridViewList
            // 
            dataGridViewList.BackgroundColor = Color.FromArgb(208, 221, 208);
            dataGridViewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewList.Dock = DockStyle.Top;
            dataGridViewList.Location = new Point(3, 3);
            dataGridViewList.Name = "dataGridViewList";
            dataGridViewList.RowHeadersWidth = 51;
            dataGridViewList.Size = new Size(671, 317);
            dataGridViewList.TabIndex = 0;
            // 
            // RegisterBase
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlRegister);
            Name = "RegisterBase";
            Text = "RegisterBase";
            Controls.SetChildIndex(tabControlRegister, 0);
            tabControlRegister.ResumeLayout(false);
            tabPageRegister.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabPageList.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AirTabPage tabControlRegister;
        private TabPage tabPageRegister;
        private TabPage tabPageList;
        private DataGridView dataGridViewList;
        private ReaLTaiizor.Controls.HopeRoundButton btnCancel;
        private ReaLTaiizor.Controls.HopeRoundButton btnSave;
        private ReaLTaiizor.Controls.HopeRoundButton btnEdit;
        private ReaLTaiizor.Controls.HopeRoundButton btnNew;
        private ReaLTaiizor.Controls.HopeRoundButton btnDelete;
        private Panel panel1;
        private Panel panel2;
    }
}