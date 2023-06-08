
using Microsoft.EntityFrameworkCore;
using ShatibyApi.Models.Domain;
using ShatibyApi.Models.DTO;

namespace ShatibyApi.API.Data
{
    public class ShatibyDBContext: DbContext
    {
        public ShatibyDBContext(DbContextOptions<ShatibyDBContext> dbContextOptions):base(dbContextOptions) 
        {
            
        }

        public DbSet<Image> Images { get; set; }
 
        public DbSet<ImagesUrls> imagesUrls { get; set; }
        public DbSet<Level> levels { get; set; }
        public DbSet<Attendance> attendances { get; set; }
        public DbSet<Circle> circles { get; set; }
        public DbSet<Donation> donations { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<EmployeeSalary> employeeSalaries { get; set; }
        public DbSet<Event> events { get; set; }
        public DbSet<Exam> exams { get; set; }
        public DbSet<ExamType> examTypes { get; set; }
        public DbSet<Expense> expenses { get; set; }
        public DbSet<Grade> grades { get; set; }
        public DbSet<Lesson> lessons { get; set; }
        public DbSet<LessonTime> lessonTimes { get; set; }
        public DbSet<Semester> semesters { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<StudentExam> studentExams { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<TeacherSalary> teacherSalaries { get; set; }
        public DbSet<Year> years { get; set; }
       // public DbSet<CircleTeacher> circleTeachers { get; set; }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            // seed data for levels

            var levels = new List<Level>()
            {
                new Level()
                {
                    Id=Guid.Parse("51257a5e-ecdb-4935-a2f7-750b0bafe5a7") ,
                    Name_EN= "Achievers",
                   Name_AR="الفائقون",
                   Description_AR="وصف",
                   Description_EN= "Description",
                   Years=2,
                   
                },

                     new Level()
                {
                    Id=Guid.Parse("9d3e3322-a82a-4c53-be47-70ba4d1f56d5") ,
                    Name_EN= "The Distinguished",
                   Name_AR="المتميزون",
                   Description_AR="وصف",
                   Description_EN= "Description",
                   Years=2,
                },
            };

            modelBuilder.Entity<Level>().HasData(levels);

            // seed data for exam/type

            var exams = new List<ExamType>()
            {
                new ExamType()
                {
                    Id=Guid.Parse("5a700e51-8107-4fb5-98a2-b59508f4ea08") ,
                   Name_AR="الامتحان الشفوي",
                   Name_EN="Oral examination",
                   Degree=50,
                   UserID=Guid.Parse("cc300768-d7a0-41b4-b784-d9ec669a9b77") ,

                },
                 new ExamType()
                {
                    Id=Guid.Parse("1b8215e3-89c6-4a18-8735-210df4092ef7") ,
                   Name_AR="الامتحان الكتابي",
                   Name_EN="Written examination",
                   Degree=50,
                   UserID=Guid.Parse("a11d8662-ae8e-479e-9f72-fa0771ba924f") ,

                },
                  new ExamType()
                {
                    Id=Guid.Parse("77facf2c-6456-480e-9adc-5229257eec52") ,
                   Name_AR="الامتحان النهائي",
                   Name_EN="Final exam",
                   Degree=50,
                   UserID=Guid.Parse("272aaf1c-92bd-415f-bf7f-1bd8348a634c") ,

                },


            };

            modelBuilder.Entity<ExamType>().HasData(exams);

            //// seed data for  semesters

            var semesters = new List<Semester>()
            {
                new Semester()
                {
                    Id=Guid.NewGuid() ,
                   Name_AR="الفصل الاول",
                   Name_EN="First Semester",

                },
                new Semester()
                {
                    Id=Guid.NewGuid() ,
                   Name_AR="الفصل الاول",
                   Name_EN="Second Semester",

                },
                 new Semester()
                {
                    Id=Guid.NewGuid() ,
                   Name_AR="الفصل التكميلي",
                   Name_EN="Supplementary semester",

                },




            };

            modelBuilder.Entity<Semester>().HasData(semesters);


            //// seed data for  semesters

            var years = new List<Year>()
            {
                new Year()
                {
                    Id=Guid.NewGuid() ,
                   Name_AR="السنة الاولى",
                   Name_EN="First year",
                   Order_of_theyear=1

                },
                 new Year()
                {
                    Id=Guid.NewGuid() ,
                   Name_AR="السنة االثانية",
                   Name_EN="Second year",
                   Order_of_theyear=2

                },
                  new Year()
                {
                    Id=Guid.NewGuid() ,
                   Name_AR="السنة الثالثة",
                   Name_EN="Third year",
                   Order_of_theyear=3

                },
                   new Year()
                {
                    Id=Guid.NewGuid() ,
                   Name_AR="السنة الرابعة",
                   Name_EN="Fourth year",
                   Order_of_theyear=4

                },
                    new Year()
                {
                    Id=Guid.NewGuid() ,
                   Name_AR="السنة الخامسة",
                   Name_EN="Fifth year",
                   Order_of_theyear=5

                },
                     new Year()
                {
                    Id=Guid.NewGuid() ,
                   Name_AR="السنة السادسة",
                   Name_EN="Sixth year",
                   Order_of_theyear=6

                },
                      new Year()
                {
                    Id=Guid.NewGuid() ,
                   Name_AR="السنة السابعة",
                   Name_EN="Seventh year",
                   Order_of_theyear=7

                },
                       new Year()
                {
                    Id=Guid.NewGuid() ,
                   Name_AR="السنة الثامنة",
                   Name_EN="Eighth year",
                   Order_of_theyear=8

                },





            };

            modelBuilder.Entity<Year>().HasData(years);

            // seed data for  semesters

            //var semesters = new List<Semester>()
            //{
            //    new Semester()
            //    {
            //        Id=Guid.NewGuid() ,
            //       Name_AR="الفصل الاول",
            //       Name_EN="First Semester",

            //    },
            //    new Semester()
            //    {
            //        Id=Guid.NewGuid() ,
            //       Name_AR="الفصل الاول",
            //       Name_EN="Second Semester",

            //    },
            //     new Semester()
            //    {
            //        Id=Guid.NewGuid() ,
            //       Name_AR="الفصل التكميلي",
            //       Name_EN="Supplementary semester",

            //    },




            //};

            //modelBuilder.Entity<Semester>().HasData(semesters);

        }
    }
}
