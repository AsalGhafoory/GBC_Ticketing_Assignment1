using Microsoft.EntityFrameworkCore;

namespace GBC_Ticketing.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Yoga" },
                new Category { CategoryId = 2, Name = "Pilates" },
                new Category { CategoryId = 3, Name = "Boxing" },
                new Category { CategoryId = 4, Name = "Padel" },
                new Category { CategoryId = 5, Name = "Tennis" }
            );
        }
    }
}
