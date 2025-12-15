using HabitTrack.Domain.Bases;

namespace HabitTrack.Domain.Entities
{
    public class Habit : BaseEntity<int>
    {
        public Habit() { }

        public Habit(int id, string name, string description,
            int streak, int goalStreak, string color, User user, Schedule schedule) : base(id)
        {
            Name = name;
            Description = description;
            Streak = streak;
            GoalStreak = goalStreak;
            Color = color;
            User = user;
            Schedule = schedule;
        }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Streak { get; set; }
        public int? GoalStreak { get; set; }
        public string? Color { get; set; }
        public User User { get; set; }
        public Schedule Schedule { get; set; }
    }
}