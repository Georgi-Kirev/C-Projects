﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Area_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result;

            Console.WriteLine("What shape would you like to find the area of? Pleas enter 'r' for rectangle or any other key for circle.");

            answer = Console.ReadLine();

            if (answer == "r")
            {
                Console.WriteLine("Please enter the height of rectangle.");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of the rectangle.");
                float width = float.Parse(Console.ReadLine());

                result = height * width;
                                
            }
            else
            {
                Console.WriteLine("Please enter the radius of the circle");
                float radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * (radius * radius);
            }
            Console.WriteLine("Result is " + result);
            Console.ReadKey();
            
        }
    }
}
