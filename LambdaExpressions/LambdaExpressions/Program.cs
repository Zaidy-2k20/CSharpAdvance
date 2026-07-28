using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(5));
            // args => expresssion
            //number => number*number

            // () => ...
            // x => ...
            // (x,y,z) => ...

            //Func<int, int> square = Square;
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(6));


            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            var result = multiplier(10);
            Console.WriteLine(result);

            /*
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
            */

            // This can be achieved uisng Lambda Expression as well
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(b => b.Price < 10);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        // Predicate -> a delegate that takes and argument and return bool
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }

        static int Square(int number)
        {
            return number * number;
        }
    }
}
