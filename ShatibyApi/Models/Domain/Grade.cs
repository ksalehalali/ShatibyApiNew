namespace ShatibyApi.Models.Domain
{
    public class Grade
    {
        public Guid Id { get; set; }
        //public Guid StudentId { get; set; }
        //public Student Student { get; set; }
        //public Guid ExamId { get; set; }
        //public Exam Exam { get; set; }

        //public Guid TeacherId { get; set; }
        //public Teacher Teacher { get; set; }
        public Guid UserID { get; set; }

        public double Degree { get; set; }


    }
}
