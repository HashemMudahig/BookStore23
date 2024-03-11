
using System.Diagnostics;

namespace BookStore23.Models.Reposotiry
{
    public class BookReposotiry : IbookStoreReposotiry<Book>//':' this is for implemention
    {
       List<Book> books;
        public BookReposotiry()// ctor this short for create a new constructor
        {
            books = new List<Book>()
          {
              new Book
              {
                  id = 1, Title="C# progarmming", Description="No description"
              },
                 new Book
              {
                  id = 2, Title="ASP.Net Core ", Description="Introduction of ASP.Net Core"
              },
                    new Book
              {
                  id = 3, Title="EntityFramWork", Description="Princple of Dtat Base "
              },

          };
        }
        public void Add(Book entity)
        {
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book=find(id);
            books.Remove(book);
        }

        public Book find(int id)
        {
            var book = books.SingleOrDefault(b => b.id == id);
            return book;
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(int id, Book newBook)
        {
           var Book=find(id);
            Book.Title=newBook.Title;   
            Book.Description=newBook.Description;
            Book.Author=newBook.Author; 
        }
    }
}
