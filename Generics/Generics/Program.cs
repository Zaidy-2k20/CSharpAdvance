using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book();

            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            /*
            Above we have two types of List on for int and other for Book object 
            to avoid this we can use generic list
            */
            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(new Book());


            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", new Book());


            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
            Console.WriteLine();
            
            // Using the class without setting the integer. i.e nullable integer
            var number2 = new Nullable<int>();
            Console.WriteLine("Has Value ?" + number2.HasValue);
            Console.WriteLine("Value: " + number2.GetValueOrDefault());

        }
    }
}
