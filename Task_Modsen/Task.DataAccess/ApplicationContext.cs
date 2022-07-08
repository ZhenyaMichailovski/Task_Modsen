using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            modelBuilder.Entity<Brigade>().ToTable("Brigade");
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Feedback>().ToTable("Feedback");
            modelBuilder.Entity<JobPosition>().ToTable("JobPosition");
            modelBuilder.Entity<Manager>().ToTable("Manager");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderTask>().ToTable("OrderTask");
            modelBuilder.Entity<Specialization>().ToTable("Specialization");
            modelBuilder.Entity<Task>().ToTable("Task");

            base.OnModelCreating(modelBuilder);
        }
    }
}
