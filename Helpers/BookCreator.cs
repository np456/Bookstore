using BookStore.Enums;
using BookStore.Models;
using System.Collections.Generic;

namespace BookStore.Helpers
{
    public static class BookCreator
    {
        public static IEnumerable<Book> CustomerOrder ()
        {
            return new List<Book>()
                {
                    new Book {Title = "Unsolved murders", Author = "Emily G. Thompson, Amber Hunt", Genre = Genre.Crime, UnitPrice = 10.99m },
                    new Book {Title = "A Little Love Story", Author = "Roland Merullo", Genre = Genre.Romance, UnitPrice = 2.40m},
                    new Book {Title = "Heresy", Author = "S J Parris", Genre = Genre.Fantasy, UnitPrice = 6.80m },
                    new Book {Title = "Jack the Ripper", Author = "Philip Sugden", Genre = Genre.Crime, UnitPrice = 16.00m},
                    new Book {Title = "The Tolkien Years", Author = "Greg Hildebrandt", Genre = Genre.Fantasy, UnitPrice = 22.90m}
                    
                };
        }
    }
}
