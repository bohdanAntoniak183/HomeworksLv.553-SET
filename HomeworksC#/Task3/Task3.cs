using System;
using System.Collections.Generic;

namespace Task3
{
    enum Drink
    { 
        Coffee,
        Tea,
        Juice,
        Water
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first integer value of the range: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter last integer value of the range: ");
            int b = Convert.ToInt32(Console.ReadLine());

            calculateIntegersAreDividedWithoutRemainder(a, b);

            Console.Write("\nEnter the string: ");
            string input = Console.ReadLine();

            printEachDeterminedCharactersOfString(input);

            Console.Write("\nEnter the drink: ");
            string drink = Console.ReadLine();

            outputTheDrink(drink);

            List<int> enteredPositiveIntegers = enterPositiveIntegers();

            outputArithmeticAverageOfTheList(enteredPositiveIntegers);

            Console.Write("\nEnter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            outputIsTheYearLeap(year);

            Console.Write("\nEnter the number to find the sum of digits: ");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());

            outputSumOfTheDigitsNumber(enteredNumber);

            Console.Write("\nEnter the number to check whether number contains only odd digits: ");
            enteredNumber = Convert.ToInt32(Console.ReadLine());

            outputIsTheNumberContainsOnlyOddDigits(enteredNumber);
        }

        private static void calculateIntegersAreDividedWithoutRemainder(int firstBoundaryOfRange, int lastBoundaryOfRange)
        {
            const int divider = 3;

            int countIntegers = (lastBoundaryOfRange - firstBoundaryOfRange) / divider;

            if ((lastBoundaryOfRange % divider) == 0)
            {
                countIntegers++;
            }

            Console.WriteLine("\nNumber of integers that are divided by " + divider + " without remainder in the range " +
                "[" + firstBoundaryOfRange + ", " + lastBoundaryOfRange + "]: " + countIntegers);
        }

        private static void printEachDeterminedCharactersOfString(string data)
        {
            const int eachNextNumberOfCharacter = 2;

            Console.Write("Each " + eachNextNumberOfCharacter + " character of string: ");

            for (int i = eachNextNumberOfCharacter - 1; i < data.Length; i += eachNextNumberOfCharacter)
            {
                Console.Write(data[i]);
            }

            Console.WriteLine();
        }

        private static void outputTheDrink(string drink)
        {
            Drink enteredDrink = (Drink)Enum.Parse(typeof(Drink), drink, true);
            const uint coffeePrice = 10;
            const uint juicePrice = 5;
            const uint teaPrice = 7;
            const uint waterPrice = 3;

            switch (enteredDrink)
            {
                case Drink.Coffee:
                    printNameAndPriceOfTheDrink(Drink.Coffee, coffeePrice);
                    break;
                case Drink.Juice:
                    printNameAndPriceOfTheDrink(Drink.Juice, juicePrice);
                    break;
                case Drink.Tea:
                    printNameAndPriceOfTheDrink(Drink.Tea, teaPrice);
                    break;
                case Drink.Water:
                    printNameAndPriceOfTheDrink(Drink.Water, waterPrice);
                    break;
            }
        }

        private static void printNameAndPriceOfTheDrink(Drink drink, uint price)
        {
            Console.WriteLine("The price of the " + drink + " is " + price + ".");
        }

        private static List<int> enterPositiveIntegers()
        {
            Console.Write("\nInput positive integer(input negative to end): ");
            int number = Convert.ToInt32(Console.ReadLine());

            List<int> positiveNumbers = new List<int>();

            while (number > 0)
            {
                positiveNumbers.Add(number);

                Console.Write("Input positive integer(input negative to end): ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            return positiveNumbers;
        }

        private static void outputArithmeticAverageOfTheList(List<int> numbers)
        {
            int sumOfNumbers = 0;
            uint countOfNumbers = 0;
            double arithmeticAverage = 0;

            foreach(int number in numbers)
            {
                sumOfNumbers += number;
                countOfNumbers++;
            }

            if (countOfNumbers != 0)
            {
                arithmeticAverage = (double)sumOfNumbers / countOfNumbers;
            }

            Console.WriteLine("\nThe arithmetic average of the entered numbers: " + arithmeticAverage);
        }

        private static void outputIsTheYearLeap(int year)
        {
            if ( ( (year % 400) == 0 ) || ( ( (year % 4) == 0 ) && ( (year % 100) != 0 ) ) )
            { 
                Console.WriteLine("The year " + year + " is a leap.");
            }
            else Console.WriteLine("The year " + year + " isn't leap.");
        }

        private static void outputSumOfTheDigitsNumber(int number)
        {
            number = Math.Abs(number);
            int sumOfTheDigits = 0;
            
            while (number != 0)
            {
                sumOfTheDigits += number % 10;
                number = number / 10;
            }

            Console.WriteLine("Sum of the digits number: " + sumOfTheDigits);
        }

        private static void outputIsTheNumberContainsOnlyOddDigits(int number)
        {
            bool isNumberContainsOnlyOddDigits = true;

            while(isNumberContainsOnlyOddDigits)
            {
                if ( ( (number % 10) % 2) == 0 )
                {
                    isNumberContainsOnlyOddDigits = false;
                }
                else
                {
                    number = number / 10;

                    if ( number == 0 )
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("The number contains only odd digits: " + isNumberContainsOnlyOddDigits);
        }
    }
}
