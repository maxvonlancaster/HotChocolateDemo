using HotChocolateDemo.Entities;
using HotChocolateDemo.Models;

namespace HotChocolateDemo.Mutations
{
    public class DemoMutations
    {
        public async Task<int> AddBook(
            BookInputType book,
            [Service] DemoContext demoContext)
        {
            var entity = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                AuthorId = book.AuthorId,
            };
            demoContext.Books.Add(entity);
            await demoContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<int> AddAuthor(
            Author author,
            [Service] DemoContext demoContext)
        {
            demoContext.Authors.Add(author);
            await demoContext.SaveChangesAsync();
            return author.Id;
        }

        public async Task<bool> UploadFileAsync(UploadFileInput input)
        {
            var fileName = input.File.Name;
            var fileSize = input.File.Length;

            await using Stream stream = input.File.OpenReadStream();

            // We can now work with standard stream functionality of .NET
            // to handle the file.

            return true;
        }

        public async Task<bool> UploadFileNewAsync(IFile file)
        {
            var fileName = file.Name;
            var fileSize = file.Length;

            await using Stream stream = file.OpenReadStream();

            // We can now work with standard stream functionality of .NET
            // to handle the file.

            return true;
        }
    }

    public sealed record UploadFileInput {
        public IFile File { get; set; }
        public int Id { get; set; }
    }
}
