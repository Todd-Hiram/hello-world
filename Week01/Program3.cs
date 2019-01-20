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
            //Output the number of days until Christmas with an appropriate label.
            DateTime xmas = new DateTime(DateTime.Today.Year, 12, 25);

            int numDays = xmas.DayOfYear - DateTime.Today.DayOfYear;

            Console.WriteLine("There are {0} days until next Christmas!", numDays);
        }
    }
}
