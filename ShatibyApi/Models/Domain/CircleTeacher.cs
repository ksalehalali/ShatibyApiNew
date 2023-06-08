namespace ShatibyApi.Models.Domain
{
    public class CircleTeacher
    {
        public Guid Id { get; set; }
        public Guid TeacherId { get; set; }
           public Teacher Teacher { get; set; }
        public Guid CircleId { get; set; }
         public Circle Circle { get; set; }
    }
}
