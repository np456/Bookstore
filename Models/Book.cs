using BookStore.Enums;
// ctrl + r + g
namespace BookStore.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public decimal UnitPrice { get; set; }

        public Book() { }

        public Book(string title, string author, Genre genre, decimal unitPrice)
        {
            title = Title;
            author = Author;
            genre = Genre;
            unitPrice = UnitPrice;
        }

    }
}
