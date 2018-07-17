using System;
using System.Linq;

namespace CalculateAreaAndParameter
{
    class Program
    {
        static void Main(string[] args)
        {

            // Loop to keep the program running until otherwise specified
            bool runProgram = true;

            while (runProgram)
            {
                // Greet user
                GreetUser();
                // User Input and Calculation Variables
                var length = GetLength();
                var width = GetWidth();
                var area = GetArea(length, width);
                var perimeter = GetPerimeter(length, width);
                // Display results
                Console.WriteLine($"Area : {area}");
                Console.WriteLine($"Perimeter : {perimeter}");
                // Ask if the user would like to run the program again
                Console.WriteLine("Continue? (y/n)");
                string runAgain = Console.ReadLine();

                // ask if user wants to run again
                if (runAgain.ToLower() != "y")
                {
                    // If user doesnt want to run again end program
                    runProgram = false;
                }

            }
        }

        public static void GreetUser()
        {
            // Greet the user
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
        }

        private static double GetLength()
        {
            // Ask for Length input
            Console.Write("Enter Length : ");

            // Convert the string into a double and validate that it is a number
            string length = Console.ReadLine();
            if (!(Double.TryParse(length, out double result)))
            {
                Console.WriteLine("Sorry but the input must be a number");
            }
            return result;
        }

        private static double GetWidth()
        {
            // Ask for Length input
            Console.Write("Enter Width : ");

            // Convert the string into a double
            string width = Console.ReadLine();
            if (!(Double.TryParse(width, out double result)))
            {
                Console.WriteLine("Sorry but the input must be a number");
            }
            return result;
        }

        private static double GetArea(double length, double width)
        {
            // Create a variable to store the area calculation
            var area = length * width;
            return area;
        }

        private static double GetPerimeter(double length, double width)
        {
            // Create a varibale to store the perimeter calculation
            var perimeter = (length + width) * 2;
            return perimeter;
        }
    }
}
