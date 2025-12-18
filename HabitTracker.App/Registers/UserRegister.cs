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
        public UserRegister(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }
        private void FormToObject(User user)
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
            user.RegisterDate = DateTime.Now;
            user.LoginDate = DateTime.Now;
        }

        protected void Save()
        {
            try
            {
                var user = new User();
                FormToObject(user);
                _userService.Add<User, User, UserValidator>(user);
                wasSaved = 1;
            }
            catch (Exception ex)
            {
                wasSaved = 0;
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            var cad = ConfigureDI.ServicesProvider!.GetService<Login>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = MainForm.ActiveForm;
                cad.Show();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Save();
            if (wasSaved == 1)
            {
                this.Close();
                var cad = ConfigureDI.ServicesProvider!.GetService<Login>();
                if (cad != null && !cad.IsDisposed)
                {
                    cad.MdiParent = MainForm.ActiveForm;
                    cad.Show();
                }
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
    }
}
