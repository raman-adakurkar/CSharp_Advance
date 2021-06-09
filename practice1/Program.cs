using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            books.Add(new Book() { Title = "Adakurkar", Price = 30 });

            //Adding New Book
            Console.WriteLine("Enter Title : ");
            var t = Console.ReadLine();
            Console.WriteLine("Enter Price : ");
            var p = float.Parse(Console.ReadLine());
            books.Add(new Book() { Title = t, Price = p });

            foreach (var b in books)
            {
                Console.WriteLine("Title : " + b.Title + ", Price : " + b.Price);
            }

            var cheapbooks = books.FindAll(b => b.Price < 50);
            foreach(var c in cheapbooks)
            {
                Console.WriteLine(c.Title);
            }
        }
    }
}
