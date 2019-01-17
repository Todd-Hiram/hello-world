using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTodd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output the current date but not the current time.
            string date = DateTime.Now.ToString("M/d/yyyy");

            Console.WriteLine("The current date is {0}", date);
        }
    }
}
