namespace HabitTracker.App.Models
{
    public class ScheduleModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int NumRep { get; set; }
        public int TypeRep { get; set; }
        public DateTime Reminder { get; set; }
    }
}