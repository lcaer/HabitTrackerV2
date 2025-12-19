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
        private readonly IBaseService<Schedule> _scheduleService;

        public Login(IBaseService<User> userService, 
                     IBaseService<Habit> habitService, 
                     IBaseService<Schedule> scheduleService)
        {
            _userService = userService;
            _habitService = habitService;
            _scheduleService = scheduleService;
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            User user = GetUser(txtUser.Text, txtPassword.Text);

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
                

                if (this.MdiParent is MainForm main)
                {
                    main.Update_lblUser(user.Login);
                }

                var habits = _habitService.Get<Habit>().Where(h => h.User.Id == user.Id).ToList();

                Close();
                
                if (habits.Any())
                {
                    BasePanelHabit.GenerateWindows(_habitService, _scheduleService);
                }
                else
                {
                    ShowForm<HabitRegister>();
                }
            }
        }

        private User? GetUser(string login, string password)
        {
            IsUserRegistered();
            var user = _userService.Get<User>().Where(x => x.Login == login).FirstOrDefault();
            if (user == null)
                return null;
            return user.Password != password ? null : user;
        }
        
        private void IsUserRegistered()
        {
            var users = _userService.Get<User>().ToList();
            if (!users.Any())
            {
                this.Close();
                ShowForm<UserRegister>();
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

        private void lklblRegisterUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ShowForm<UserRegister>();
        }
        
        private void chbPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = chbPassword.Checked ? false : true;
        }
    }
}
