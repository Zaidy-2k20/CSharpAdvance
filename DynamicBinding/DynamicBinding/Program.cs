using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBinding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = "Mosh"; 
            obj.GetHashCode();

            //// with reflection if i want to call this method
            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
            //methodInfo.Invoke(null, null);

            //// this will throw compile time error as Optimize is not present in object class
            //object excelObject = "Zaid";
            //excelObject.Optimize();

            //// Using Dynamic
            //dynamic excelObject = "Zaid";
            //excelObject.Optimize();


            dynamic name = "Zaid";
            name = 10;
        }
    }
}
