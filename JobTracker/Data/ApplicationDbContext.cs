using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobTracker.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Job> Jobs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Job>().HasData(
                new Job { Id = 1, Location = "Tampa", Title = "Software Engineer" },
                new Job { Id = 2, Location = "Orlando", Title = "Data Scientist" },
                new Job { Id = 3, Location = "Miami", Title = "Product Manager" }
                );
        }
    }
}
