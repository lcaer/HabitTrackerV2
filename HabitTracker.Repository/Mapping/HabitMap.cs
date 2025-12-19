using HabitTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Repository.Mapping
{
    public class HabitMap : IEntityTypeConfiguration<Habit>
    {
        public void Configure(EntityTypeBuilder<Habit> builder)
        {
            builder.ToTable("Habit");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(prop => prop.Description)
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Streak)
                .IsRequired();

            builder.Property(prop => prop.GoalStreak)
                .IsRequired();

            builder.Property(prop => prop.Color)
                .IsRequired();

            builder.HasOne(prop => prop.User)
                   .WithMany()
                   .HasForeignKey("UserId")
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(prop => prop.Schedule)
                /*.WithOne().HasForeignKey<Habit>("SchedulId")
                .OnDelete(DeleteBehavior.Cascade)*/;
        }
    }
}