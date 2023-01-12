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
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-5DQ22TU\SQLEXPRESS;Database=VacationManager;Trusted_Connection=True;");
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
