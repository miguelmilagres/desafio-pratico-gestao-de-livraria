using BookstoreManagement.Enums;

namespace BookstoreManagement.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public Genre Genre { get; set; }
        public double Price { get; set; }
    }
}
