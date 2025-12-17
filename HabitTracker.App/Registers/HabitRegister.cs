using HabitTracker.App.Bases;
using HabitTracker.App.Infra;
using HabitTracker.App.Models;
using HabitTracker.App.Others;
using HabitTracker.Domain.Bases;
using HabitTracker.Domain.Entities;
using HabitTracker.Service.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace HabitTracker.App.Registers
{
    public partial class HabitRegister : BaseForm
    {
        private IBaseService<Habit> _habitService;
        private IBaseService<Schedule> _scheduleService;
        private IBaseService<User> _userService;
        int wasSaved = 0;
        public HabitRegister(
            IBaseService<Habit> habitService, 
            IBaseService<Schedule> scheduleService)
        {
            _habitService = habitService;
            _scheduleService = scheduleService;
            InitializeComponent();
        }
        private void FormToObject(Habit habit, Schedule schedule)
        {
            habit.User = MainForm.User;
            habit.Name = txtName.Text;
            habit.Description = txtDescription.Text;
            habit.Streak = 0;
            habit.GoalStreak = (int)nudGoalStrak.Value;
            habit.Color = txtColor.Text;
            habit.Schedule = schedule;
            habit.Schedule.Date = datePicker.Date.AddHours(12);
            habit.Schedule.Reminder = habit.Schedule.Date.Value.AddHours(-1);
        }

        protected void Save()
        {
            try
            {
                var habit = new Habit();
                var schedule = new Schedule();
                var user = new User();

                FormToObject(habit, schedule);
                _scheduleService.Add<Schedule, Schedule, ScheduleValidator>(schedule);
                _habitService.Add<Habit, Habit, HabitValidator>(habit);
                wasSaved = 1;
            }
            catch (Exception ex)
            {
                wasSaved = 0;
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Save();
            if (wasSaved == 1)
            {
                this.Close();
            }
        }
    }
}