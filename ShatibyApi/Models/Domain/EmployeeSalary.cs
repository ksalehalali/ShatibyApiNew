namespace ShatibyApi.Models.Domain
{
    public class EmployeeSalary
    {

        public Guid Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        //public Guid EmployeeId { get; set; }
        //public Employee Employee { get; set; }
    }
}
