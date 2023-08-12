using HotChocolateDemo.Entities;

namespace HotChocolateDemo.Mutations
{
    public class DemoMutations
    {
        public async Task<int> AddBook(
            Book book,
            [Service] DemoContext demoContext)
        {
            demoContext.Books.Add(book);
            await demoContext.SaveChangesAsync();
            return book.Id;
        }

        public async Task<int> AddAuthor(
            Author author,
            [Service] DemoContext demoContext)
        {
            demoContext.Authors.Add(author);
            await demoContext.SaveChangesAsync();
            return author.Id;
        }
    }
}
