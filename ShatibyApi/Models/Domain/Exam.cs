namespace ShatibyApi.Models.Domain
{
    public class Exam
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid CircleId { get; set; }
        public Circle Circle { get; set; }
       // public Guid SemesterId { get; set; }
        //public Semester Semester { get; set; }
        //public Guid TeacherId { get; set; }
        //public Teacher Teacher { get; set; }

        //public Guid ExamTypeId { get; set; }
        //public ExamType ExamType { get; set; }

        //public Guid LevelId { get; set; }
        //public Level Level { get; set; }
        public Guid UserID { get; set; }
    }
}
