using BookStore23.Models;
using Microsoft.EntityFrameworkCore;


namespace BookStore23.Data
{
    public class BookStoreDbContext:DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options) // then define all these 
        {

        }
        public DbSet<Author> Authors { get; set; }// these are the the tables in the database will named like this 
        public DbSet<Book> Books { get; set; }
        public DbSet<user> Users { get; set; }// using CTL+. to get the red line out 
    }
}
