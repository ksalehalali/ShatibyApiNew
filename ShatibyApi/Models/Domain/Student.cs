namespace ShatibyApi.Models.Domain
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name_EN { get; set; }
        public string? Name_AR { get; set; }
        public int Ege { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public DateTime Rigestered { get; set; }

        //public Guid LevelId { get; set; }
        //public Level Level { get; set; }
        public string Notes { get; set; }
        //public Guid YearId { get; set; }
        //public Year Year { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Guid UserID { get; set; }

    }
}
