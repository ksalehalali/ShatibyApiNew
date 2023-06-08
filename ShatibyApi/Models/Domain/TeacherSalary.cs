namespace ShatibyApi.Models.Domain
{
    public class TeacherSalary
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        //public Guid TeacherId { get; set; }
        //public Teacher Teacher { get; set; }
    }
}
