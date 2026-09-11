
using System;

// Create a class named MathOperations.
// This class will contain a method that performs a math operation.
class MathOperations
{
    // Create a void method named Calculate.
    // The method accepts two integer parameters: number1 and number2.
    // It performs a math operation on the first number.
    // It then displays the second number to the console.
    public void Calculate(int number1, int number2)
    {
        // Multiply the first integer by 2 and store the result.
        int result = number1 * 2;

        // Display the result of the math operation on the first integer.
        Console.WriteLine("The result of the math operation is: " + result);

        // Display the second integer that was passed to the method.
        Console.WriteLine("The second number is: " + number2);
    }
}

// Create the main program class.
class Program
{
    // The Main method is where the console application starts running.
    static void Main(string[] args)
    {
        // Instantiate the MathOperations class by creating a new object.
        MathOperations math = new MathOperations();

        // Call the Calculate method and pass two numbers as arguments.
        // The first number is 10 and the second number is 5.
        math.Calculate(10, 5);

        // Call the Calculate method again.
        // This time, specify the parameters by their names.
        math.Calculate(number1: 20, number2: 8);

        // Pause the console so the user can see the output before the program closes.
        Console.ReadLine();
    }
}
```
