using Microsoft.EntityFrameworkCore;
using NOTABURGER_2.Models;

namespace NOTABURGER_2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; } 
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<MenuItem> MenuItems { get; set; }
    }
}