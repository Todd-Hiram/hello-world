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
            //Use two WriteLine statements that display as output the two variables 
            //from the previous step using proper labels such as "My name is ..." and "I am from ...".
            string fullName = "Hiram Todd";
            string state = "Arizona";

            Console.WriteLine("My name is {0}", fullName);
            Console.WriteLine("and I am from {0}.", state );
        }
    }
}
