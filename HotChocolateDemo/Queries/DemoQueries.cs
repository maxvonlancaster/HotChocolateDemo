using HotChocolateDemo.Entities;

namespace HotChocolateDemo.Queries
{
    public class DemoQueries
    {
        public List<Book> GetBooks([Service] DemoContext demoContext)
        {
            return demoContext.Books.ToList();
        }

        public Book? GetBook([Service] DemoContext demoContext, int id)
        {
            return demoContext.Books.FirstOrDefault(x => x.Id == id);
        }

        public List<Author> GetAuthors([Service] DemoContext demoContext)
        {
            return demoContext.Authors.ToList();
        }

        public Author? GetAuthor([Service] DemoContext demoContext, int id)
        {
            return demoContext.Authors.FirstOrDefault(x => x.Id == id);
        }
    }
}
