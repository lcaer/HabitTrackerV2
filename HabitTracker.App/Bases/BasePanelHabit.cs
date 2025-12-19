using HabitTracker.App.Infra;
using HabitTracker.App.Registers;
using HabitTracker.Domain.Bases;
using HabitTracker.Domain.Entities;
using HabitTracker.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace HabitTracker.App.Bases
{
    public partial class BasePanelHabit : Form
    {
        private IBaseService<Habit> _habitService;
        private IBaseService<Schedule> _scheduleService;
        private Habit _habit;
        public BasePanelHabit(IBaseService<Habit> habitService, IBaseService<Schedule> scheduleService)
        {
            _habitService = habitService;
            _scheduleService = scheduleService;

            InitializeComponent();
            MdiParent = MainForm.ActiveForm;

            if (this.MdiParent is MainForm main)
            {
                main.btnRegHabit.Visible = true;
            }
        }

        public static void GenerateWindows(IBaseService<Habit> habitService, IBaseService<Schedule> scheduleService)
        {
            var openPanels = Application.OpenForms.OfType<BasePanelHabit>().ToList();
            foreach (var panel in openPanels)
            {
                panel.Close();
            }

            User user = MainForm.User;
            var habits = habitService.Get<Habit>().Where(h => h.User.Id == user.Id).ToList();

            int offsetY = 0;
            bool isFirst = true;

            foreach (Habit habit in habits)
            {
                BasePanelHabit habitWindow = new BasePanelHabit(habitService, scheduleService);

                habitWindow.ApplyHabitData(habit);
                habitWindow.StartPosition = FormStartPosition.Manual;
                if (isFirst == true)
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
            _habit = habit;
            var schedule = _scheduleService.Get<Schedule>().FirstOrDefault(s => s.Id == habit.Schedule.Id);
            if (schedule == null) return;

            int panelHeight = PanelSize(habit.GoalStreak.Value, 12, 360);

            this.Size = new Size(781, panelHeight);

            UpdateContent(habit.Name, habit.Description, schedule.Date.Value.ToShortDateString());
            PopulateHabitButtons(habit.GoalStreak.Value);

            List<bool> statusArray = GetStatus();
            FillButtons(true, statusArray, 2);
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
                btn.Enabled = false;
                btn.BackColor = Color.FromArgb(208, 221, 208);
                btn.ForeColor = Color.FromArgb(229, 243, 229);
                btn.FlatStyle = FlatStyle.Flat;

                flpHabitStreak.Controls.Add(btn);
            }
        }

        private int PanelSize(int goalStreak, int c, int obj)
        {
            int size = 0; // min 100 -  max 408

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
                if (obj >= goalStreak && (obj - goalStreak) <= 29)
                {
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

        private List<bool> GetStatus()
        {
            List<bool> status = [];

            var schedule = _scheduleService.Get<Schedule>().FirstOrDefault(s => s.Id == _habit.Schedule.Id);
            status = schedule.Status;

            return status;
        }

        private void FillButtons(bool wasChecked, List<bool> statusArray, int op)
        {
            int i = 0;
            foreach (Control control in flpHabitStreak.Controls)
            {
                if (control is Button btn)
                {
                    if (op == 1)
                    {
                        if (btn.BackColor == Color.FromArgb(208, 221, 208))
                        {
                            if (wasChecked == false)
                            {
                                btn.BackColor = Color.FromArgb(162, 85, 75);
                                statusArray.Add(false);
                                break;
                            }
                            else
                            {
                                btn.BackColor = Color.FromArgb(155, 184, 153);
                                statusArray.Add(true);
                                break;
                            }
                        }
                    }
                    if (op == 2)
                    {
                        if (i >= 0 && i < statusArray.Count())
                        {
                            if (statusArray[i] == false)
                            {
                                btn.BackColor = Color.FromArgb(162, 85, 75);
                            }
                            else
                            {
                                btn.BackColor = Color.FromArgb(155, 184, 153);
                            }
                        }
                        else
                        {
                            break;
                        }
                        i++;
                    }
                }
            }
        }

        protected void Delete()
        {
            try
            {
                DialogResult res = MessageBox.Show("Deseja realmente deletar?",
                    "HabitTracker", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    _habitService.Delete(_habit.Id);
                    _scheduleService.Delete(_habit.Schedule.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"HabitTrack", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowForm<TForm>(Action<TForm> configure = null) where TForm : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TForm>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = MainForm.ActiveForm;
                configure?.Invoke(cad);
                cad.Show();
            }
        }

        private void btnConfStreak_Click(object sender, EventArgs e)
        {
            bool wasChecked = chStreak.Checked;
            List<bool> statusArray = GetStatus();

            FillButtons(wasChecked, statusArray, 1);

            var schedule = _scheduleService.Get<Schedule>().Where(s => s.Id == _habit.Schedule.Id).First();
            DateTime newDate = schedule.Date.Value.AddDays(1);

            if (schedule.InitialDate.Value.AddDays(_habit.GoalStreak.Value) >= newDate)
            {
                schedule.Status = statusArray;
                schedule.Date = newDate;
                _scheduleService.Update<Schedule, Schedule, ScheduleValidator>(schedule);
                _scheduleService.Update<Schedule, Schedule, ScheduleValidator>(schedule);
                lblDate.Text = newDate.ToShortDateString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ShowForm<HabitRegister>(f =>
            {
                f.IsAlteration = true;
                f.SelectedHabit = this._habit;
                f.LoadHabitData();
            });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();

            User user = MainForm.User;
            var habits = _habitService.Get<Habit>().Where(h => h.User.Id == user.Id).ToList();

            var openPanels = Application.OpenForms.OfType<BasePanelHabit>().ToList();
            foreach (var p in openPanels) p.Close();
            ShowForm<HabitRegister>();
            }
        }
    }
}
