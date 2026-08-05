using System;

namespace MathOperationsApp
{
    // A simple class that contains one method for performing a math operation
    class MathOperations
    {
        // This method takes two integers as parameters.
        // It performs a math operation on the first integer (doubles it),
        // then displays the second integer to the screen.
        public void PerformOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer (in this case, doubling it)
            int result = firstNumber * 2;

            // Display the result of the math operation performed on the first integer
            Console.WriteLine("The first number ({0}) doubled is: {1}", firstNumber, result);

            // Display the second integer to the screen, as required
            Console.WriteLine("The second number is: {0}", secondNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate (create an instance of) the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method, passing in two numbers by position
            // (firstNumber = 5, secondNumber = 10, based on parameter order)
            Console.WriteLine("Calling the method with numbers passed by position:");
            mathOps.PerformOperation(5, 10);

            // Add a blank line for readability between the two calls
            Console.WriteLine();

            // Call the method again, this time specifying the parameters by name
            // This makes it clear which value is going to which parameter,
            // regardless of the order they are written in
            Console.WriteLine("Calling the method with parameters specified by name:");
            mathOps.PerformOperation(secondNumber: 20, firstNumber: 7);

            // Keep the console window open until the user presses a key
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
