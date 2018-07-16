using System;
using System.Linq;

namespace CalculateAreaAndParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Varibles to hold length and width from user input
            double length;
            double width;

            // Loop to keep the program running until otherwise specified
            bool runProgram = true;
            while (runProgram)
            {
                
                // Greet the user
                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

                // Ask for Length input
                Console.Write("Enter Length : ");

                // Convert the string into a double
                length = Convert.ToDouble(Console.ReadLine());

                // Ask for Width input
                Console.Write("Enter Width : ");

                // Convert string to double
                width = Convert.ToDouble(Console.ReadLine());

                // create a variable to store the area calculation
                var area = length * width;

                // create a varibale to store the perimeter calculation
                var perimeter = (length + width) * 2;

                // Display results/answers
                Console.WriteLine($"Area : {area}");
                Console.WriteLine($"Parameter : {perimeter}");

                // Ask if the user would like to run the program again
                Console.WriteLine("Continue? (y/n)");
                string runAgain = Console.ReadLine();

                // Validate resonse to run again -- checks first letter of any response to make sure it is Y
                if (runAgain?.ToLower().FirstOrDefault() != 'y')
                {
                    // If user doesnt want to run again end program
                    runProgram = false;
                }
            }
        }
    }
}
