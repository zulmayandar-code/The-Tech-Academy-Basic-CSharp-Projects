using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message, as required by the assignment (must be the first line printed)
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for the package weight and read their input
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // If the weight exceeds 50, the package cannot be shipped; show an error and end the program
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Ends the program immediately
            }

            // Prompt the user for the package width and read their input
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt the user for the package height and read their input
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            // Prompt the user for the package length and read their input
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // Add up the three dimensions to check the combined size limit
            double dimensionTotal = width + height + length;

            // If the total of the dimensions exceeds 50, the package is too big to ship; show an error and end
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Ends the program immediately
            }

            // Calculate the shipping quote:
            // 1) Multiply height, width, and length together to get the volume
            // 2) Multiply the volume by the weight
            // 3) Divide that result by 100 to get the final quote
            double quote = (height * width * length * weight) / 100;

            // Display the final quote to the user, formatted as a dollar amount with two decimal places
            Console.WriteLine("Your estimated total for shipping this package is: ${0:F2}", quote);

            // Thank the user before the program ends
            Console.WriteLine("Thank you!");
        }
    }
}
