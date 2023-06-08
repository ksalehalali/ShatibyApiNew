namespace ShatibyApi.Models.Domain
{
    public class LessonTime
    {
        public Guid Id { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public Guid UserID { get; set; }

    }
}
