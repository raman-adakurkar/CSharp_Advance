using System.Collections.Generic;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Books> GetBooks()
        {
            return new List<Books>
            {
                new Books() {Title = "Raman", Price=6},
                new Books() {Title = "Laxman", Price=16},
                new Books() {Title = "Adakurkar", Price=27}
            };
        }
    }
}
