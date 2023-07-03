using System;

namespace ComplexCodeExample
{
    class Program
    {
        static void Main()
        {
            // Declare and initialize variables
            int number1 = 10;
            int number2 = 5;
            
            // Perform arithmetic operations
            int sum = number1 + number2;
            int difference = number1 - number2;
            int product = number1 * number2;
            int quotient = number1 / number2;
            
            // Output the results
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            
            // Use conditional statements
            if (number1 > number2)
            {
                Console.WriteLine("Number1 is greater than Number2");
            }
            else if (number1 < number2)
            {
                Console.WriteLine("Number1 is less than Number2");
            }
            else
            {
                Console.WriteLine("Number1 is equal to Number2");
            }
            
            // Use a loop
            Console.WriteLine("Printing numbers from 1 to 5:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
