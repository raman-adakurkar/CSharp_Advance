using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Syntax for LambdaExpression:
            // args => expression (eg. number => number * number;);
            Func<int, int> Square = number => number * number;
            Console.WriteLine(Square(5));

            var books = new BookRepository().GetBooks();
            var result = books.FindAll(book => book.Price < 10);
            
            foreach(var r in result)
            {
                Console.WriteLine(r.Title);
            }

        }
    }
}
