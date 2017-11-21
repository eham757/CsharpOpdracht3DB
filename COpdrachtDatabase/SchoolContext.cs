using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace COpdrachtDatabase
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CsharpOpdracht3DB.COpdrachtDataBase.NewDb;Trusted_Connection=True;");
        }
    }
}
