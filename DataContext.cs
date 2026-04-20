using Microsoft.EntityFrameworkCore;
using BuggyApp.Models;

namespace BuggyApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}
