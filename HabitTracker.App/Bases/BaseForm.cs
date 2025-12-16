using HabitTracker.App.Properties;
using System.Drawing.Printing;

namespace HabitTracker.App.Bases
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }


        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMaximizeForm_Click(object sender, EventArgs e)
        {
            if(this.IsMdiChild == false)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void btnMinimizeForm_Click(object sender, EventArgs e)
        {
            if (this.IsMdiChild == false)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}