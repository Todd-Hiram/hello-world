﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            
            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();

            /*
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = "";

            foreach (char item in firstNameArray)
            {
                result += item;
            }

            result += " ";

            foreach (char item in lastNameArray)
            {
                result += item;
            }

            result += " ";

            foreach (char item in cityArray)
            {
                result += item;
            }

            Console.WriteLine("Results: " + result);
            */

            //Console.ReadLine("Results: ");

            //ReverseString(firstName);
            //ReverseString(LastName);
            //ReverseString(city);

            //Console.ReadLine();

            //string reversedFirstName = ReverseString(firstName);
            //string reversedLastName = ReverseString(LastName);
            //string reversedCity = ReverseString(city);

            //Console.Write(String.Format("{0} {1} {2}", 
            //                            reversedFirstName, 
            //                            reversedLastName, 
            //                            reversedCity));

            DisplayResult(reversedFirstName(firstName), reversedLastName(LastName), reversedCity(city));
            Console.ReadLine();

            DisplayResult(reversedFirstName(firstName), reversedLastName(LastName), reversedCity(city));
            Console.ReadLine();
        }

        //Added coding
        //private static void ReverseString(string message)
        //{
        //    //string message = "Hello world!";

        //    char[] messageArray = message.ToCharArray();
        //    Array.Reverse(messageArray);

        //foreach (char item in messageArray)
        //{
        //    Console.Write(item);
        //}
        //Console.Write(" ");

        private static string ReverseString(string message)
        {

            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedCity)
        {
            Console.ReadLine("Results: ");
            Console.Write(String.Format("{0} {1} {2}", 
                                        reversedFirstName,
                                        reversedLastName,
                                        reversedCity));
        }

        private static void DisplayResult(string message)
        {
            Console.ReadLine("Results: ");
            Console.Write(message);
        }
    }
}
