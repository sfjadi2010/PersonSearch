using Microsoft.EntityFrameworkCore;
using PersonSearch.Models;

namespace PersonSearch.Context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
