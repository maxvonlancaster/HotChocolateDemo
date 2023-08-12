using Microsoft.EntityFrameworkCore;

namespace HotChocolateDemo.Entities
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
