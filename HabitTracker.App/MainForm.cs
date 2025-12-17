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
            ExibeFormulario<Login>();
        }

        public void Update_lblUser(string username)
        {
            lblUser.Text = $"User: {username}";
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
