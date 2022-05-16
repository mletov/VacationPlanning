using ApplicationTier.API.OrganizationStructure.Model;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace ApplicationTier.API.OrganizationStructure
{
    public class SchoolDBContext : DbContext
    {


        public DbSet<Student> Students { get; set; } = null!;

        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                    new Student { Id = 1, Name = "Иванов" },
                    new Student { Id = 2, Name = "Петров" },
                    new Student { Id = 3, Name = "Сидоров" }
            );
        }
    }


}
