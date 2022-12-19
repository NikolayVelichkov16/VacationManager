using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext() : base()
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-TTI2M5B;Database=myDataBase;Uid=myUsername;Pwd=myPassword;");
            //optionsBuilder.UseSqlServer(@"Server=;Database=;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer(@"Server=;Database=;Trusted_Connection=True;");
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamLeader> TeamLeaders { get; set; }
        public DbSet<CEO> CEOs { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<VacationDoc> VacationDocs { get; set; }
    }
}
