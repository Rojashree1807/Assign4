﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is positive, negative, or zero
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            // Use the conditional operator to check if the number is even or odd
            string evenOrOdd = (number % 2 == 0) ? "even" : "odd";
            Console.WriteLine("The number is " + evenOrOdd + ".");
            Console.ReadKey();
        }
    }
}
