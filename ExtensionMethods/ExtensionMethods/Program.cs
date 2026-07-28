using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);

            Console.WriteLine();

            // using extensions methods instead of creating them
            IEnumerable<int> numbers = new List<int>() { 1, 5, 2, 7, 10, 4, 18 };
            var max = numbers.Max();

            Console.WriteLine(max);
        }
    }
}
