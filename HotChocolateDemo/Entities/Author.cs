namespace HotChocolateDemo.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime Birth { get; set; }

        public virtual ICollection<Book>? Books { get; set; }
    }
}
