using System.ComponentModel.DataAnnotations.Schema;

namespace HotChocolateDemo.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public virtual Author? Author { get; set; }

        [ForeignKey(nameof(Author))]
        public int AuthorId { get; set; }
    }
}
