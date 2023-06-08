namespace ShatibyApi.Models.Domain
{
    public class Attendance
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        //public Guid LessonId { get; set; }
        //public Lesson Lesson { get; set; }

        //public Guid StudentId { get; set; }
        //public Student Student { get; set; }

        //public Guid TeacherId { get; set; }
        public Guid UserID { get; set; }

    }
}
