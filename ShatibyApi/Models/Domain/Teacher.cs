namespace ShatibyApi.Models.Domain
{
    public class Teacher
    {
        public Guid Id { get; set; }

        public string Name_EN { get; set; }
        public string? Name_AR { get; set; }
        public int Ege { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public DateTime Rigestered { get; set; }

        //public Guid LevelId { get; set; }
       // public Level Level { get; set; }
        public string Notes { get; set; }
      
        public string Phone { get; set; }
        public string Email { get; set; }
        public int PartsSaved { get; set; }
        public double Salary { get; set; }
        public Guid UserID { get; set; }

    }
}
