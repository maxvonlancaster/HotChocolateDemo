namespace HotChocolateDemo.Models
{
    public sealed record BookInputType
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int AuthorId { get; set; }
    }
}
