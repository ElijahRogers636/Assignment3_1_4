﻿using System.Text;

namespace Assignment3_1_4
{
    internal class Program
    {
        //  Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        static void Main(string[] args)
        {
            Console.WriteLine("Lets find the quadrent the coordinate point is in!");
            Console.WriteLine("Please enter a value for X-axis point");
            Console.Write("X Point: ");
            double x_axis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter a value for Y-axis point");
            Console.Write("Y Point: ");
            double y_axis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Point: ({x_axis},{y_axis})");

            Console.WriteLine($"This point is in {FindCoordinateQuadrant(x_axis, y_axis)}");
            Console.WriteLine();
            Console.WriteLine($"This point is in {AnotherFindCoordinateQuadrant(x_axis, y_axis)}");
        }

        static string FindCoordinateQuadrant(double inputX_axis, double inputY_axis)
        {

            // If x is pos check for Y else X is negative and check for Y 
            if(inputX_axis < 0)
            {
                if( inputY_axis < 0 )
                {
                    return "Quadrant 3";
                }
                else
                {
                    return "Quadrant 2";
                }
            }
            else
            {
                if (inputY_axis < 0)
                {
                    return "Quadrant 4";
                }
                else
                {
                    return "Quadrant 1";
                }
            }
        }

        // Normalizes the coordinates to 1 or -1, create a string to use in switch statement
        static string AnotherFindCoordinateQuadrant(double inputX_axis, double inputY_axis)
        {
            string coordinates = $"({NormalizeCoordinates(inputX_axis)},{NormalizeCoordinates(inputY_axis)})";

            switch (coordinates)
            {
                case "(1,1)":
                    return "Quadrant 1";
                case "(-1,1)":
                    return "Quadrant 2";
                case "(-1,-1)":
                    return "Quadrant 3";
                case "(1,-1)":
                    return "Quadrant 4";
                default:
                    return "How did you get here?";
            }


        }

        // Nomralizes a number to -1 or 1 based on if a number is negative or positive
        static int NormalizeCoordinates(double num)
        {
            if(num < 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
