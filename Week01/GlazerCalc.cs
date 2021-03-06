﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTodd
{
    class GlazerCalc
    {
        static void Main(string[] args)
        {
            //Add the program example from required reading section 2.1 C# Programming Yellow Book by Rob Miles.
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Width Input: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Height Input: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is {0} feet", woodLength);
            Console.WriteLine("The area of glass is {0} square metres", glassArea);
        }
    }
}
