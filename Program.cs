using System;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("   Welcome to the Simple C# Calculator!");
            Console.WriteLine("============================================");
            Console.WriteLine("Learning is fun!");
            Console.WriteLine();

            bool running = true;
            while (running)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Calculate("+");
                        break;
                    case "2":
                        Calculate("-");
                        break;
                    case "3":
                        Calculate("*");
                        break;
                    case "4":
                        Calculate("/");
                        break;
                    case "5":
                        Calculate("%");
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Thanks for using the calculator. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please pick 1-6.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("  1) Add");
            Console.WriteLine("  2) Subtract");
            Console.WriteLine("  3) Multiply");
            Console.WriteLine("  4) Divide");
            Console.WriteLine("  5) Modulus (remainder)");
            Console.WriteLine("  6) Exit");
            Console.Write("Your choice: ");
        }

        static void Calculate(string op)
        {
            double a = ReadNumber("Enter the first number: ");
            double b = ReadNumber("Enter the second number: ");
            double result = 0;

            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Error: cannot divide by zero.");
                        return;
                    }
                    result = a / b;
                    break;
                case "%":
                    if (b == 0)
                    {
                        Console.WriteLine("Error: cannot divide by zero.");
                        return;
                    }
                    result = a % b;
                    break;
            }

            Console.WriteLine($"Result: {a} {op} {b} = {result}");
        }

        static double ReadNumber(string prompt)
        {
            double value;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("That is not a valid number. Try again: ");
            }
            return value;
        }
    }
}
