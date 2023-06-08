namespace ShatibyApi.Models.Domain
{
    public class ExamType
    {
        public Guid Id { get; set; }
        public string Name_EN { get; set; }
        public string Name_AR { get; set; }

        public double Degree { get; set; }
        public Guid UserID { get; set; }

    }
}
