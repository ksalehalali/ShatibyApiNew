

namespace ShatibyApi.Models.Domain
{
    public class Circle
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Address { get; set; }
        public int LessonsCount { get; set; }
        public Guid LevelId { get; set; }
        public Level Level { get; set; }
        public Guid SemesterId { get; set; }
        public Semester Semester { get; set; }

        public Guid TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Guid UserID { get; set; }

    }
}
