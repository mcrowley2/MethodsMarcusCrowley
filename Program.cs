using System;

namespace MethodsMarcusCrowley
{
    class Program
    {
        // Create method to use for the *Main* block below
        static void MyMessage(int arithmetic)
        {
            // Use try-catch method to handle *DivideByZeroException* error
            try // Enter code first
            {
                Random randomNumbers = new Random(); // Declare variable for randomizing numbers

                // Declare variables for two numbers and determine each of their ranges in number selection
                // If parenthesis is closed with no range (), all numbers are randomized; If there's a range (min, max),
                // random number will be selected within that range
                int number1 = randomNumbers.Next();
                int number2 = randomNumbers.Next(); 

                // Declare variables and formulas for the four arithmetic operations
                int add = number1 + number2; // Declare variable for sum
                int subtract = number1 - number2; // Declare variable for difference
                int multiply = number1 * number2; // Declare variable for product
                int divide = number1 / number2; // Declare variable for quotient

                // Declare variables for written messages inside console
                string sum = "The sum of " + number1 + " and " + number2 + " is: " + add; // Adding
                string difference = "The difference of " + number1 + " and " + number2 + " is: " + subtract; // Subtracting
                string product = "The product of " + number1 + " and " + number2 + " is: " + multiply; // Multiplying
                string quotient = "The quotient of " + number1 + " and " + number2 + " is: " + divide; // Dividing

                // Write if-else statement to organize each operation with their own parameter value for *MyMessage* method
                if (arithmetic == 0) // If adding two numbers
                {
                    Console.WriteLine(sum); // Message for string *sum* displays
                }
                else if (arithmetic == 1) // If subtracting two numbers
                {
                    Console.WriteLine(difference); // Message for string *difference* displays
                }
                else if (arithmetic == 2) // If multiplying two numbers
                {
                    Console.WriteLine(product); // Message for string *product* displays
                }
                else if (arithmetic == 3) // If dividing two numbers
                {
                    Console.WriteLine(quotient); // Message for string *quotient* displays
                }
                else // If parameter is outside values 0-3
                {
                    Console.WriteLine("Parameter does not match any of the four operations"); // Message displays if parameter value is outside 0-3
                }
            }
            catch(DivideByZeroException ex) // Prevents app from terminating when dividing by zero
            {
                Console.WriteLine(ex); // Message displays if attempting to divide by zero
            }
        }
        // Use the *Main* block below to call the *MyMessage* method above
        static void Main(string[] args)
        {
            Console.WriteLine("Marcus David Crowley"); // Full name will display on the first line of console
            MyMessage(0); // Call method by one of its parameter values
        }
    }
}
