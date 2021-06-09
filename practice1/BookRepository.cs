using System.Collections.Generic;

namespace practice1
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title="Raman", Price = 6},
                new Book() {Title="Karan", Price = 7},
                new Book() {Title="Aish", Price = 27}
            };
        }
    }
}
