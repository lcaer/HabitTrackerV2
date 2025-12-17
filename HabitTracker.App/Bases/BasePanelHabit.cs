namespace HabitTracker.App.Bases
{
    public partial class BasePanelHabit : Form
    {
        public BasePanelHabit()
        {
            InitializeComponent();
            PopulateHabitButtons();
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
    }
}
