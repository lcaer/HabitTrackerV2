using HabitTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Repository.Mapping
{
    public class ScheduleMap : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.ToTable("Schedule");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Date)
                .IsRequired();

            /*builder.Property(prop => prop.NumRep)
                .IsRequired();

           /builder.Property(prop => prop.TypeRep)
                .IsRequired();*/

            builder.Property(prop => prop.Reminder)
                .IsRequired();
        }
    }
}