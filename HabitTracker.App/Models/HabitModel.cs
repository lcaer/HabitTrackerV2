namespace HabitTracker.App.Models
{
    public class HabitModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Streak { get; set; }
        public int GoallStreak { get; set; }
        public int IdUser { get; set; }
        public string? Color { get; set; }
        public string? User { get; set; }
        public int IdSchedule { get; set; }
    }
}