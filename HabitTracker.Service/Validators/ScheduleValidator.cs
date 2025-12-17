using FluentValidation;
using HabitTracker.Domain.Entities;

namespace HabitTracker.Service.Validators
{
    public class ScheduleValidator : AbstractValidator<Schedule>
    {
        public ScheduleValidator()
        {
            RuleFor(c => c.Date)
                .NotEmpty();
            /*RuleFor(c => c.NumRep)
                .NotEmpty().GreaterThan(0);
            RuleFor(c => c.TypeRep)
                .NotEmpty().InclusiveBetween(1, 3);*/
            RuleFor(c => c.Reminder)
               .NotEmpty();

        }
    }
}