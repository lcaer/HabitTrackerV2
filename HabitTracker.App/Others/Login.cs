using HabitTracker.App.Bases;
using HabitTracker.App.Infra;
using HabitTracker.App.Registers;
using HabitTracker.Domain.Bases;
using HabitTracker.Domain.Entities;
using HabitTracker.Service.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace HabitTracker.App.Others
{
    public partial class Login : BaseForm
    {
        private readonly IBaseService<User> _userService;
        private readonly IBaseService<Habit> _habitService;

        public Login(IBaseService<User> userService, IBaseService<Habit> habitService)
        {
            _userService = userService;
            _habitService = habitService;
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            User user = ObterUsuario(txtUser.Text, txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Usuário e/ou senha inválida!", "HabitTracker",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!user.Active)
            {
                MessageBox.Show("Usuário inativo!", "HabitTracker",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                user.LoginDate = DateTime.Now;
                user = _userService.Update<User, User, UserValidator>(user);
                MainForm.User = user;
                DialogResult = DialogResult.OK;
                Close();
                var cad = ConfigureDI.ServicesProvider!.GetService<HabitRegister>();
                if (cad != null && !cad.IsDisposed)
                {
                    cad.MdiParent = MainForm.ActiveForm;
                    cad.Show();
                }
            }
        }

        private User? ObterUsuario(string login, string password)
        {
            ChecaExistenciaDeUsuarioCadastrado();
            var user = _userService.Get<User>().Where(x => x.Login == login).FirstOrDefault();
            if (user == null)
                return null;
            return user.Password != password ? null : user;
        }
        private void ChecaExistenciaDeUsuarioCadastrado()
        {
            var users = _userService.Get<User>().ToList();
            if (!users.Any())
            {
                var user = new User
                {
                    Login = "admin",
                    Password = "Admin123!",
                    Name = "Admnistrador",
                    Active = true,
                    RegisterDate = DateTime.Now,
                    Email = "admin@gmail.com"
                };
                _userService.Add<User, User, UserValidator>(user);
            }
        }

        private void lklblRegisterUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            var cad = ConfigureDI.ServicesProvider!.GetService<UserRegister>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = MainForm.ActiveForm;
                cad.Show();
            }
        }
    }
}
