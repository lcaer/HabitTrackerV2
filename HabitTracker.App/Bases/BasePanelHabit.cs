using HabitTracker.App.Others;
using HabitTracker.Domain.Bases;
using HabitTracker.Domain.Entities;
using HabitTracker.Service.Validators;

namespace HabitTracker.App.Bases
{
    public partial class BasePanelHabit : Form
    {
        private IBaseService<Habit> _habitService;
        private IBaseService<Schedule> _scheduleService;
        public BasePanelHabit(IBaseService<Habit> habitService, IBaseService<Schedule> scheduleService)
        {
            _habitService = habitService;
            _scheduleService = scheduleService;
            ListHabits();
            //get the habits
            //UpdateContent("Acordar", "Acordar cedo", "12/12/2020"); funciona
            //gravar buttons 

        }

        private void PopulateHabitButtons(int streakGoal)
        {
            flpHabitStreak.Controls.Clear();
            int buttonSize = 20;

            if (streakGoal == 0) { streakGoal = 30; }

            for (int i = 0; i < streakGoal; i++)
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

        private void ListHabits()
        {
            int hcount = 1;
            User user = MainForm.User;
            var habits = _habitService.Get<Habit>().Where(h => h.User.Id == user.Id).ToList();
            foreach (Habit habit in habits)
            {
                var schedule = _scheduleService.Get<Schedule>().Where(s => s.Id == habit.Schedule.Id).First();
                MessageBox.Show("Habit: " + habit.Name + "\nhcount: " + hcount + "\nLocation" + Location.ToString());
                //Location = new Point(Location.X, (Size.Width * hcount));
                InitializeComponent();
                PopulateHabitButtons(/*habit.GoalStreak.Value*/365);
                UpdateContent(habit.Name, habit.Description, schedule.Date.Value.Date.ToString());
                hcount++;
            }

        }

        private void UpdateContent(string name, string desc, string data)
        {
            lblName.Text = name;
            lblDesc.Text = desc;
            lblDate.Text = data;
        }

        private void btnConfStreak_Click(object sender, EventArgs e)
        {

        }

        private void flpHabitStreak_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
