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
            ExibeFormulario<Login>();
            PopulateHabitButtons();
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

        private void PopulateHabitButtons()
        {
            flpHabitStreak.Controls.Clear();
            int buttonSize = 20;

            for (int i = 0; i < 365; i++)
            {
                Button btn = new Button();
                btn.Width = buttonSize;
                btn.Height = buttonSize;
                btn.Text = "";
                btn.Enabled = false;
                btn.BackColor = Color.FromArgb(155, 184, 153);
                btn.ForeColor = Color.FromArgb(229, 243, 229);
                btn.FlatStyle = FlatStyle.Flat;

                flpHabitStreak.Controls.Add(btn);
            }
        }

        private void btnConfStreak_Click(object sender, EventArgs e)
        {

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
