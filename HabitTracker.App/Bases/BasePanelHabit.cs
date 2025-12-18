using HabitTracker.Domain.Bases;
using HabitTracker.Domain.Entities;
using Microsoft.VisualBasic.Devices;

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

            InitializeComponent();
            ListHabits();
            //get the habits
            //UpdateContent("Acordar", "Acordar cedo", "12/12/2020"); funciona
            //gravar buttons 

        }

        private List<Habit> GetHabits()
        {
            User user = MainForm.User;
            var habits = _habitService.Get<Habit>().Where(h => h.User.Id == user.Id).ToList();
            return habits;
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
            List<Habit>? habits = GetHabits();
            foreach (Habit habit in habits)
            {
                var schedule = _scheduleService.Get<Schedule>().Where(s => s.Id == habit.Schedule.Id).First();
                //MessageBox.Show("Habit: " + habit.Name + "\nhcount: " + hcount + "\nLocation" + Location.ToString())
                //Location = new Point(Location.X, (Size.Width * hcount));
                int panelSize = PanelSize(habit.GoalStreak.Value, 12, 360);
                PopulateHabitButtons(habit.GoalStreak.Value);
                Size = new Size(781, panelSize);
                UpdateContent(habit.Name, habit.Description, schedule.Date.Value.ToShortDateString());
                hcount++;
            }

        }

        private int PanelSize(int goalStreak, int c, int obj)
        {
            int size = 0, t = 0; // min 100 -  max 408

            

            if (goalStreak > 360 && goalStreak <= 365)
            {
                size = 408;
            }
            if (goalStreak > 0 && goalStreak <= 30)
            {
                size = 100;
            }

            if (goalStreak > 30 && goalStreak <= 360) 
            {
                if (obj >= goalStreak && (obj-goalStreak)<=29)
                {
                    t = 1;
                    size = 72 + (28 * c);
                }
                else
                {
                    size = PanelSize(goalStreak, c - 1, obj - 30);
                }
            }

            //MessageBox.Show("goal: " + goalStreak + " obj: " + obj + " c: " + c +
            //" size: " + size + " obj-goal: " + (obj - goalStreak) + " t: " + t);

            return size;
        }

        private void UpdateContent(string name, string desc, string data)
        {
            lblName.Text = name;
            lblDesc.Text = desc;
            lblDate.Text = data;
        }

        private void btnConfStreak_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
            List<Habit>? habits = GetHabits();
            //habits[panelId].Schedule.Id;
            foreach (Habit habit in habits)
            {
                var schedule = _scheduleService.Get<Schedule>().Where(s => s.Id == habit.Schedule.Id).First();
                MessageBox.Show("sh id: " + schedule.Id);
                lblDate.Text = schedule.Date.Value.AddDays(1).ToShortDateString();

            }
        }

    }
}
