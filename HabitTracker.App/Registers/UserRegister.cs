using HabitTracker.App.Bases;
using HabitTracker.App.Infra;
using HabitTracker.App.Others;
using HabitTracker.Domain.Bases;
using HabitTracker.Domain.Entities;
using HabitTracker.Service.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace HabitTracker.App.Registers
{
    public partial class UserRegister : BaseForm
    {
        private IBaseService<User> _userService;
        int wasSaved = 0;
        public bool IsAlteration { get; set; }

        public UserRegister(IBaseService<User> userService)
        {
            _userService = userService;

            InitializeComponent();
        }

        public void LoadUserData()
        {
            if (IsAlteration)
            {
                lblTitle_RegisterUser.Text = "Edição Usuário";
                btnRegister.Text = "Salvar";
                lklblLogin.Visible = false;
                btnDelete.Visible = true;
                ObjectToForm(MainForm.User);
            }
        }
        private void FormToObject(User user, int op)
        {
            user.Name = txtName.Text;
            user.Login = txtLogin.Text;
            if (txtEmail.Text == txtConfEmail.Text)
            {
                user.Email = txtEmail.Text;
            }
            if (txtPassword.Text == txtConfPassword.Text)
            {
                user.Password = txtPassword.Text;
            }
            user.Active = true;
            if (op == 1)
            {
                user.RegisterDate = DateTime.Now;
            }
            user.LoginDate = DateTime.Now;
        }

        private void ObjectToForm(User user)
        {
            txtName.Text = user.Name.ToString();
            txtLogin.Text = user.Login.ToString();
            txtEmail.Text = user.Email.ToString();
            txtConfEmail.Text = user.Email.ToString();
            txtPassword.Text = user.Password.ToString();
            txtConfPassword.Text = user.Password.ToString();
        }

        protected void Save()
        {
            try
            {
                if (IsAlteration == true)
                {
                    var user = MainForm.User;
                    FormToObject(user, 2);
                    _userService.Update<User, User, UserValidator>(user);
                    wasSaved = 2;
                }
                else
                {
                    var user = new User();
                    FormToObject(user, 1);
                    _userService.Add<User, User, UserValidator>(user);
                    wasSaved = 1;
                }
            }
            catch (Exception ex)
            {
                wasSaved = 0;
                MessageBox.Show(ex.Message, @"HabitTrack", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void Delete()
        {
            try
            {
                DialogResult res = MessageBox.Show("Deseja realmente deletar?", 
                    "HabitTracker", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    _userService.Delete(MainForm.User.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"HabitTrack", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowForm<TForm>() where TForm : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TForm>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = MainForm.ActiveForm;
                cad.Show();
            }
        }

        private void lklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ShowForm<Login>();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Save();
            if (wasSaved == 1)
            {
                this.Close();
                ShowForm<Login>();
            }
            if (wasSaved == 2)
            {
                if (this.MdiParent is MainForm main)
                {
                    main.Update_lblUser(txtLogin.Text);
                }
                this.Close();
            }
        }

        private void chbPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = chbPassword.Checked ? false : true;
        }

        private void chbConfPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtConfPassword.UseSystemPasswordChar = chbConfPassword.Checked ? false : true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();

            var openPanels = Application.OpenForms.OfType<BasePanelHabit>().ToList();
            foreach (var panel in openPanels)
            {
                panel.Close();
            }
            if (this.MdiParent is MainForm main)
            {
                main.btnConfig.Visible = false;
                main.btnRegHabit.Visible = false;
                main.Update_lblUser("");
            }

            this.Close();
            ShowForm<Login>();

        }
    }
}