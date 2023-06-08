namespace ShatibyApi.Models.Domain
{
    public class StudentExam
    {
        public Guid Id { get; set; }
        //public Guid StudentId { get; set; }
        //public Student Student { get; set; }

        //public Guid ExamId { get; set; }
        //public Exam Exam { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
    }
}
