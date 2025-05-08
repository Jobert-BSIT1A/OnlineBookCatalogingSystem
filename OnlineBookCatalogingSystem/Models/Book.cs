// Models/Book.cs
namespace OnlineBookCatalogingSystem.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public int PublishYear { get; set; }
        public string? Genre { get; set; }
        public string? CoverImageUrl { get; set; }
    }

}
