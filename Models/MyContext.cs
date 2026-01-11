using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class MyContext : DbContext
    {
        public MyContext (DbContextOptions<MyContext> options) : base (options) { }

        public DbSet<Book> Books { get; set; }
    }
}
