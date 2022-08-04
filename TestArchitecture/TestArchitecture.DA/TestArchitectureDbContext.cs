using Microsoft.EntityFrameworkCore;
using TestArchitecture.DA.Configurations;
using TestArchitecture.DA.Entities;

namespace TestArchitecture.DA
{
    public class TestArchitectureDbContext : DbContext
    {
        public TestArchitectureDbContext(DbContextOptions<TestArchitectureDbContext> options) : base(options)
        {
        }

        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<GithubAccount> GitHubAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LessonConfiguration());
            modelBuilder.ApplyConfiguration(new HomeworkConfiguration());
            modelBuilder.ApplyConfiguration(new MemberConfiguration());
            modelBuilder.ApplyConfiguration(new GithubAccountConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
