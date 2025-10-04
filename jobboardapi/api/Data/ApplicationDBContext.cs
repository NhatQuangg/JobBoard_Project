using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<CandidateProfile> CandidateProfiles { get; set; }
        // public DbSet<EmployerProfile> EmployerProfiles { get; set; }
        // public DbSet<Message> Messages { get; set; }
        // public DbSet<Interview> Interviews { get; set; }
        // public DbSet<Application> Applications { get; set; }
        // public DbSet<JobPosting> JobPostings { get; set; }
        // public DbSet<JobCategory> JobCategories { get; set; }
        // public DbSet<JobCategory_Posting> JobCategory_Postings { get; set; }
        // public DbSet<SavedJob> SavedJobs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // GLOBAL: Tắt cascade delete cho tất cả relationships để tránh multiple cascade paths
            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }
        }
    }
}