using System;

namespace HomeworkCS.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int addition = a + b;
            Console.WriteLine("\nAddition of \"a\" and \"b\" numbers: {0:d}\n", addition);

            int subtraction = a - b;
            Console.WriteLine("Subtraction of \"a\" and \"b\" numbers: {0:d}\n", subtraction);

            int multiplication = a * b;
            Console.WriteLine("Multiplication of \"a\" and \"b\" numbers: {0:d}\n", multiplication);

            int division = a / b;
            Console.WriteLine("Division of \"a\" and \"b\" numbers: {0:d}\n", division);

            Console.WriteLine("How are you?\n");

            Console.Write("Enter your answer: ");
            string answer = Console.ReadLine();

            Console.WriteLine("\nYou are " + answer + ".");

            Console.Write("\nEnter first character: ");
            char firstCharacter = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second character: ");
            char secondCharacter = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter third character: ");
            char thirdCharacter = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\nYou enter " + firstCharacter + ", " + secondCharacter + ", " + thirdCharacter + ".");

            Console.Write("\nEnter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            bool areBothNumbersPositive = (firstNumber > 0) && (secondNumber > 0);

            Console.WriteLine("\nBoth numbers are positive: " + areBothNumbersPositive);
        }
    }
}
