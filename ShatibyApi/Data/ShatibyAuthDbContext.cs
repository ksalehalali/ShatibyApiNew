using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ShatibyApi.API.Data
{
    public class ShatibyAuthDbContext:IdentityDbContext
    {
        public ShatibyAuthDbContext(DbContextOptions<ShatibyAuthDbContext> options) :base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "011a681d-feb1-42a6-81ff-6bf39079b95a";
            var writerRoleId = "fb593a65-4c06-40f9-b5de-1f137f17a64c";
            var superAdmin = "7e03a396-3fc0-4684-bfd7-a0a489138a77";
            var studentRoleId = "496f8eb6-2f74-46ea-9912-7e6bfa102c96";
            var teacherRoleId = "a2b6e849-d860-42d9-ab92-59b7bdc68488";
            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = studentRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name= "Student",
                    NormalizedName="Student".ToUpper(),
                },
                new IdentityRole
                {
                    Id = teacherRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name= "Teacher",
                    NormalizedName="Teacher".ToUpper(),
                },
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name= "Reader",
                    NormalizedName="Reader".ToUpper(),
                },
                  new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp = writerRoleId,
                    Name= "Writer",
                    NormalizedName="Writer".ToUpper(),
                },

                    new IdentityRole
                {
                    Id = superAdmin,
                    ConcurrencyStamp = superAdmin,
                    Name= "SuperAdmin",
                    NormalizedName="SuperAdmin".ToUpper(),
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);

        }
    }
}
