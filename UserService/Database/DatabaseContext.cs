using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database.Entity;

namespace UserService.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Login> login { get; set; }
        //protected override void onConfiguring(DbContextOptionsBuilder optionsBuilder )
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FFU2RK8\\SQLEXPRESS;
        //                                Database=apiDB;User ID=priti;Password=priti123;
        //                                MultipleActiveResultSets=true;");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Priti",
                    Address = "Singapore",
                    Contact = "1235", FirstName="pritpalkaur", LastName="hunjan"                   
                },
                new User
                {
                    Id = 2,
                    Name = "Srinivas",
                    Address = "Singapore",
                    Contact = "12356", FirstName="Srinivas", LastName="kolluru"
                }

            );
        }
    }
}
