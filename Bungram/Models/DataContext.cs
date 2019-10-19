using Microsoft.EntityFrameworkCore;

namespace Bungram.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Test> Tests { get; set; }

        public class Test
        {
            public int TestId { get; set; }
            public string TestText { get; set; }
        }
    }
}
