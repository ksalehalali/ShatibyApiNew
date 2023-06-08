namespace ShatibyApi.Models.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string? Name_EN { get; set; }
        public string Name_AR { get; set; }
        public int Ege { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public DateTime JoinDate { get; set; }
        public string Notes { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public double Salary { get; set; }
        public Guid UserID { get; set; }
    }
}
