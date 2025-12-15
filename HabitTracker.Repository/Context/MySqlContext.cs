using HabitTracker.Domain.Entities;
using HabitTracker.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace HabitTracker.Repository.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) :
            base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Habit> Habits { get; set; }
        public DbSet<Schedule> Schedules { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Habit>(new HabitMap().Configure);
            modelBuilder.Entity<Schedule>(new ScheduleMap().Configure);
        }
    }
}