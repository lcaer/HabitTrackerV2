using HabitTracker.Domain.Bases;

namespace HabitTracker.Domain.Entities
{
    public class Schedule : BaseEntity<int>
    {
        public Schedule() { }

        public Schedule(int id, DateTime date, /*int numRep,
            int typeRep,*/ List<bool> status, DateTime reminder) : base(id)
        {
            Date = date;
            //NumRep = numRep;
            //TypeRep = typeRep;
            Status = status;
            Reminder = reminder;
        }

        public DateTime? Date { get; set; }
        //public int? NumRep { get; set; }
        //public int? TypeRep { get; set; }
        public List<bool>? Status { get; set; }
        public DateTime? Reminder { get; set; }
    }
}