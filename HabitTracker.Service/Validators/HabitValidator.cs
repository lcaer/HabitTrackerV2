using FluentValidation;
using HabitTracker.Domain.Entities;

namespace HabitTracker.Service.Validators
{
    public class HabitValidator : AbstractValidator<Habit>
    {
        public HabitValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Nome do Hábito obrigatório!");
            RuleFor(c => c.Description)
                .MaximumLength(100);
            RuleFor(c => c.Streak)
                .NotEmpty().GreaterThanOrEqualTo(0);
            RuleFor(c => c.GoalStreak)
               .NotEmpty().GreaterThanOrEqualTo(0);
            RuleFor(c => c.Color)
                .NotEmpty().MaximumLength(7);
            RuleFor(c => c.User)
                .NotEmpty();
            RuleFor(c => c.Schedule)
                .NotEmpty();

        }
    }
}