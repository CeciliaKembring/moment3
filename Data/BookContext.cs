using Collection.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Book {get; set;}
    }
}
