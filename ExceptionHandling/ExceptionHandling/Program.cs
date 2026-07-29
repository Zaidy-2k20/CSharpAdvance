using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            StreamReader streamReader = null;
            try
            {
                //var calculator = new Calculator();
                //var result = calculator.Divide(5, 0);

                streamReader = new StreamReader(@"c:\file.zip");
                var content = streamReader.ReadToEnd();
            }
            catch (DivideByZeroException ex)
            {
                // catch block form most specific to generic exception are allowed
                Console.WriteLine("You cannot divide by zero.");
            }
            catch (ArithmeticException ex)
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occured.");
            }
            finally
            {
                if (streamReader != null) 
                    streamReader.Dispose();
            }
            */

            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("Zaid");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
