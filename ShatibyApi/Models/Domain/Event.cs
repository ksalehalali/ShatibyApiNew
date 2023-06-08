namespace ShatibyApi.Models.Domain
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Name_EN { get; set; }
        public string Name_AR { get; set; }
        public string Description_EN { get; set; }
        public string Description_AR { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }

    }
}
