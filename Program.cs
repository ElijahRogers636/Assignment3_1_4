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
        }

        static string FindCoordinateQuadrant(double inputX_axis, double inputY_axis)
        {
            // Check if both point X and Y are 0 if so return domain (0,0)
            if (inputX_axis != 0 || inputY_axis != 0)
            {
                // Check if x is pos or neg then check y symbol.
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
            else
            {
                return "Domain (0,0)";
            }
        }
    }
}
