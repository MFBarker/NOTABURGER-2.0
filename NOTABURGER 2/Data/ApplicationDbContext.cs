using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NOTABURGER_2.Models;

namespace NOTABURGER_2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Employees { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<MenuItem> SecretMenuItems { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}