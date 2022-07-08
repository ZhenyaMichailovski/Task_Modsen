using Microsoft.EntityFrameworkCore;
using Task.DataAccess.Entities;

namespace Task.DataAccess
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Event> Brigades { get; set; }
        public DbSet<EventOrganizer> Customers { get; set; }
        public DbSet<Organizer> Employees { get; set; }
        public DbSet<Place> Feedbacks { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().ToTable("Events");
            modelBuilder.Entity<EventOrganizer>().ToTable("EventOrganizers");
            modelBuilder.Entity<Organizer>().ToTable("Organizers");
            modelBuilder.Entity<Place>().ToTable("Places");

            base.OnModelCreating(modelBuilder);
        }
    }
}
