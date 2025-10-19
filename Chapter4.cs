using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        TryDivide(input1, input2);
    }

    static void TryDivide(string input1, string input2)
    {
        try
        {
            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            int result = num1 / num2;

            Console.WriteLine($"The result of {num1} divided by {num2} is {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: One or both of the inputs are not valid numbers.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}
