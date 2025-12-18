using HabitTracker.App.Infra;
using HabitTracker.Domain.Bases;
using HabitTracker.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

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

            MdiParent = MainForm.ActiveForm;
        }

        public static void GenerateWindows(IBaseService<Habit> habitService, IBaseService<Schedule> scheduleService)
        {
            User user = MainForm.User;
            var habits = habitService.Get<Habit>().Where(h => h.User.Id == user.Id).ToList();

            int offsetY = 0;
            bool isFirst = true;

            foreach (Habit habit in habits)
            {
                BasePanelHabit habitWindow = new BasePanelHabit(habitService, scheduleService);

                habitWindow.ApplyHabitData(habit);
                habitWindow.StartPosition = FormStartPosition.Manual;
                if(isFirst == true)
                {
                    habitWindow.Location = new Point(50, 10);
                    isFirst = false;
                    offsetY += (habitWindow.Size.Height + 20);
                }
                else
                {
                    habitWindow.Location = new Point(50, offsetY);
                    offsetY += (habitWindow.Size.Height + 10);
                }
                
                habitWindow.Show();
            }
        }

        private void ApplyHabitData(Habit habit)
        {
            var schedule = _scheduleService.Get<Schedule>().FirstOrDefault(s => s.Id == habit.Schedule.Id);
            if (schedule == null) return;

            int panelHeight = PanelSize(habit.GoalStreak.Value, 12, 360);

            this.Size = new Size(781, panelHeight);
            this.Text = "Habit: " + habit.Name;

            UpdateContent(habit.Name, habit.Description, schedule.Date.Value.ToShortDateString());
            PopulateHabitButtons(habit.GoalStreak.Value);
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
                btn.Tag = i;
                btn.Text = "";
                btn.Enabled = false;
                btn.BackColor = Color.FromArgb(208, 221, 208);
                btn.ForeColor = Color.FromArgb(229, 243, 229);
                btn.FlatStyle = FlatStyle.Flat;

                flpHabitStreak.Controls.Add(btn);
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

            return size;
        }

        private void UpdateContent(string name, string desc, string data)
        {
            lblName.Text = name;
            lblDesc.Text = desc;
            lblDate.Text = data;
        }

        private List<Habit> GetHabits()
        {
            User user = MainForm.User;
            var habits = _habitService.Get<Habit>().Where(h => h.User.Id == user.Id).ToList();
            return habits;
        }
        private void btnConfStreak_Click(object sender, EventArgs e)
        {
            //int count = 0;
            bool wasChecked = chStreak.Checked;
            List<Habit>? habits = GetHabits();

            foreach (Habit habit in habits)
            {
                var schedule = _scheduleService.Get<Schedule>().Where(s => s.Id == habit.Schedule.Id).First();
                DateTime newDate = schedule.Date.Value.AddDays(1);
                lblDate.Text = newDate.ToShortDateString();
            }

            foreach (Control control in flpHabitStreak.Controls)
            {
                if (control is Button btn)
                {
                    if (btn.BackColor == Color.FromArgb(208, 221, 208))
                    {
                        if (wasChecked == false)
                        {
                            btn.BackColor = Color.FromArgb(162, 85, 75);
                            break;
                        }
                        else
                        {
                            btn.BackColor = Color.FromArgb(155, 184, 153);
                            break;
                        }
                    }

                }
            }
        }
    }
}
