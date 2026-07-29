using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = null;  //this will give error becaue value type in not nullable
            Nullable<DateTime> date = null;

            // Shorthand for nullabel is [valueType ?]
            DateTime? date2 = null;

            Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            //Console.WriteLine("Value: " + date.Value);  // this line will throw error as it is trying to get the value of null object and throw InvalidOperationException


            Console.WriteLine();
            DateTime? date3 = new DateTime(2014, 1, 1);
            //DateTime date4 = date3;  // cant asign DateTime object to nullable DateTime object  (value type cannot be converted into nullable)
            DateTime date4 = date3.GetValueOrDefault();
            DateTime? date5 = date4;
            Console.WriteLine(date4);
            Console.WriteLine(date5.GetValueOrDefault());


            Console.WriteLine();
            /*
            DateTime? date6 = null;
            DateTime date7;

            if (date6 != null)
                date7 = date6.GetValueOrDefault();
            else
                date7 = DateTime.Today;

            Console.WriteLine(date7);
            */

            // Null Coalescing Operator: same thing can be achieved
            DateTime? date6 = null;
            DateTime date7 = date6 ?? DateTime.Today;
            DateTime date8 = (date6 != null) ? date6.GetValueOrDefault() : DateTime.Today;
            Console.WriteLine(date7);
            Console.WriteLine(date8);


        }
    }
}
