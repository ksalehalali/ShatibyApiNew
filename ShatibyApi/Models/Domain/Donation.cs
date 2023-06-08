namespace ShatibyApi.Models.Domain
{
    public class Donation
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public Guid? TheDonorId { get; set; }

        public string TheDonor { get; set; }
    }
}
