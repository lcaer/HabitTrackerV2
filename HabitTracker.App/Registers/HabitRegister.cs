using HabitTracker.App.Bases;
using HabitTracker.Domain.Bases;
using HabitTracker.Domain.Entities;
using HabitTracker.Service.Validators;

namespace HabitTracker.App.Registers
{
    public partial class HabitRegister : BaseForm
    {
        private IBaseService<Habit> _habitService;
        private IBaseService<Schedule> _scheduleService;
        int wasSaved = 0;
        public bool IsAlteration { get; set; }
        public Habit SelectedHabit { get; set; }
        public HabitRegister(
            IBaseService<Habit> habitService, 
            IBaseService<Schedule> scheduleService)
        {
            _habitService = habitService;
            _scheduleService = scheduleService;
            InitializeComponent();
        }

        public void LoadHabitData()
        {
            if (IsAlteration)
            {
                lblTitle_RegisterHabit.Text = "Edição Usuário";
                btnRegister.Text = "Salvar";
                ObjectToForm(SelectedHabit);
            }
        }

        private void ObjectToForm(Habit habit)
        {
            txtName.Text = habit.Name.ToString();
            txtDescription.Text = habit.Description.ToString();
            txtColor.Text = habit.Color.ToString();
            nudGoalStreak.Value = habit.GoalStreak.Value;
            datePicker.Enabled = false;
        }
        private void FormToObject(Habit habit, Schedule schedule, int op)
        {
            habit.User = MainForm.User;
            habit.Name = txtName.Text;
            habit.Description = txtDescription.Text;
            habit.Streak = 0;
            habit.GoalStreak = (int)nudGoalStreak.Value;
            habit.Color = txtColor.Text;
            if (op == 1)
            {

                habit.Schedule = schedule;
                habit.Schedule.Date = datePicker.Date.AddHours(12);
                habit.Schedule.InitialDate = habit.Schedule.Date.Value;
                habit.Schedule.Status = [];
                habit.Schedule.Reminder = habit.Schedule.Date.Value.AddHours(-1);
            }
        }

        protected void Save()
        {
            try
            {
                if (IsAlteration == true)
                {
                    var habit = SelectedHabit;
                    var schedule = SelectedHabit.Schedule;
                    FormToObject(habit, schedule, 2);
                    _scheduleService.Update<Schedule, Schedule, ScheduleValidator>(schedule);
                    _habitService.Update<Habit, Habit, HabitValidator>(habit);
                    wasSaved = 1;
                }
                else
                {
                    var habit = new Habit();
                    var schedule = new Schedule();
                    var user = new User();

                    FormToObject(habit, schedule, 1);
                    _scheduleService.Add<Schedule, Schedule, ScheduleValidator>(schedule);
                    _habitService.Add<Habit, Habit, HabitValidator>(habit);
                    wasSaved = 1;
                }
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
                BasePanelHabit.GenerateWindows(_habitService, _scheduleService);
            }
        }
    }
}