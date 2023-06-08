namespace ShatibyApi.Models.Domain
{
    public class Expense
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }

    }
}
