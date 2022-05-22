using ServiceInjection.Models;
using Microsoft.EntityFrameworkCore;

namespace ServiceInjection.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<User> User { get; set; }
    }
}
