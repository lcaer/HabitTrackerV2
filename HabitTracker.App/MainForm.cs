using HabitTracker.App.Bases;
using HabitTracker.App.Infra;
using HabitTracker.App.Others;
using HabitTracker.App.Registers;
using HabitTracker.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace HabitTracker.App
{
    public partial class MainForm : BaseForm
    {
        public static User User { get; set; }

        public MainForm()
        {
            InitializeComponent();
            SetMdiBackColor();
            ShowForm<Login>();
        }

        public void Update_lblUser(string username)
        {
            lblUser.Text = $"User: {username}";
        }

        private void SetMdiBackColor()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient mdiClient)
                {
                    mdiClient.BackColor = Color.FromArgb(239, 252, 239);
                    break;
                }
            }
        }

        private void btnRegHabit_Click(object sender, EventArgs e)
        {
            ShowForm<HabitRegister>();
        }

        private void bntConfig_Click(object sender, EventArgs e)
        {
            ShowForm<UserRegister>();
        }

        private void ShowForm<TForm>() where TForm : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TForm>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
