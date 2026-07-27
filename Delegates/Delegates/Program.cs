using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filter = new PhotoFilter();
            PhotoProcessor.PhotoFilterHandler filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);


            Console.WriteLine();
            Console.WriteLine("Delgates using Action<>");

            var processor2 = new PhotoProcessor();
            var filter2 = new PhotoFilter();
            Action<Photo> filterHandler2 = filter2.ApplyBrightness;
            filterHandler2 += filter2.Resize;
            filterHandler2 += RemoveRedEyeFilter;

            processor2.Process2("photo2.jpg", filterHandler2);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}
