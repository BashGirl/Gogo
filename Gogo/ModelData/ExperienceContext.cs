using System;
using Microsoft.EntityFrameworkCore;

namespace Gogo.ModelData
{
    public class ExperienceContext : DbContext
    {
        public DbSet<Experience> experience { get; set; } //DbSet è un tipo che ti permette di fare LINQ

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost;Database=Gogodb;User Id=sa;Password=P@ssw0rd;");
        }
    }
}
