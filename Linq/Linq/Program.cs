using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            var cheapbooks = new List<Book>();

            // without using LINQ
            foreach (var book in books)
            {
                if(book.Price < 10)
                    cheapbooks.Add(book);
            }

            foreach (var cheapbook in cheapbooks)
                Console.WriteLine(cheapbook.Title + " " + cheapbook.Price);

            Console.WriteLine();

            // LINQ Query Operators
            var cheapBooks2 =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b;

            // using LINQ
            // LINQ Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);
            foreach (var cheapbook in cheapBooks)
                Console.WriteLine(cheapbook);
            //Console.WriteLine(cheapbook.Title + " " + cheapbook.Price);


            Console.WriteLine();
            var book2 = books.SingleOrDefault(b => b.Title == "ASP.NET MVC+++");
            Console.WriteLine(book2 == null);
            //Console.WriteLine(book2.Title);

            Console.WriteLine();
            //var book3 = books.First(b => b.Title == "C# Advanced Topics");
            var book3 = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book3.Title + " " + book3.Price);


            Console.WriteLine();
            var book4 = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book4.Title + " " + book4.Price);


            Console.WriteLine();
            var book5 = books.Skip(2).Take(3);
            foreach (var book in book5)
            {
                Console.WriteLine(book.Title);
            }



            Console.WriteLine();
            var count = books.Count();
            Console.WriteLine(count);


            Console.WriteLine();
            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var totalPrices = books.Sum(b => b.Price);
            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);
            Console.WriteLine(totalPrices);


        }
    }
}
