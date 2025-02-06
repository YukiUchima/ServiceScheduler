using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace API;

    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>()
        .HasOne(e => e.Person)
        .WithMany()
        .HasForeignKey(e => e.PersonId)
    }
}