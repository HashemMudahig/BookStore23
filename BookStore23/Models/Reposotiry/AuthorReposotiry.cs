
namespace BookStore23.Models.Reposotiry
{
    public class AuthorReposotiry : IbookStoreReposotiry<Author>
    {
        IList<Author>authors;
        public AuthorReposotiry()
        {
            authors = new List<Author>()
                {
                    new Author{id=1,FullName="Hashem"},
                    new Author{id=2,FullName="Khaled "},
                    new Author{id=2,FullName="Mele Chross"},
                };
        }
        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            var  author =find(id);
            authors.Remove(author); 
        }

        public Author find(int id)
        {
            var author=authors.SingleOrDefault(a=>a.id==id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author newAuthor)
        {
            var author=find(id);
            author.FullName = newAuthor.FullName;   
            

        }
    }
}
