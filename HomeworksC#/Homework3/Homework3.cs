using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text: ");
            string text = Console.ReadLine();

            outputTheNumberOfReservedCharacters(text);

            Console.Write("\nEnter the number of month: ");
            int numberOfMonth = Convert.ToInt32(Console.ReadLine());

            outputTheNumberOfDaysInTheMonth(numberOfMonth);

            int[] enteredIntegers = enterIntegers();
            outputTheResultOfCalculation(enteredIntegers);
        }

        private static void outputTheNumberOfReservedCharacters(string value)
        {
            char[] characters = { 'a', 'o', 'i', 'e' };
            uint countReservedCharacters = 0;

            foreach (char character in value)
            {
                foreach (char reservedCharacter in characters)
                {
                    if (character == reservedCharacter)
                    {
                        countReservedCharacters++;
                    }
                }
            }

            Console.Write("The number of reserved characters { ");

            foreach (char reservedCharacter in characters)
            {
                Console.Write("\'" + reservedCharacter + "\' ");
            }

            Console.WriteLine("} is " + countReservedCharacters + ".");
        }

        private static void outputTheNumberOfDaysInTheMonth(int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Month  have 31 days.");
                    break;
                case 2:
                    Console.WriteLine("Month have 28 days. In leap year month have 29 days.");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Month have 30 days.");
                    break;
                default:
                    Console.WriteLine("Invalid month number.");
                    break;
            }

        }

        private static int[] enterIntegers()
        {
            const int numberOfIntegers = 10;
            int[] integersArray = new int[numberOfIntegers];

            Console.WriteLine();

            for (int i = 0; i < numberOfIntegers; i++)
            {
                Console.Write("Enter " + (i + 1) + " number: ");
                integersArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            return integersArray;
        }

        private static void outputTheResultOfCalculation(int[] array)
        {
            int halfOfLengthArray = array.Length / 2;
            bool isFirstHalfIsPositive = true;

            for (int i = 0; i < halfOfLengthArray; i++)
            {
                if ( array[i] <= 0 )
                {
                    isFirstHalfIsPositive = false;
                }
            }

            if (isFirstHalfIsPositive)
            {
                Console.WriteLine("\nSum of the first half of integers is: " + calculateSumOfFirstHalfIntegers(array));
            }
            else
            {
                Console.WriteLine("\nProduct of the last half of integers is: " + calculateProductOfLastHalfIntegers(array));
            }
        }

        private static int calculateSumOfFirstHalfIntegers(int[] array)
        {
            int halfOfLengthArray = array.Length / 2;
            int sumOfFirstHalfIntegers = 0;

            for(int i = 0; i < halfOfLengthArray; i++)
            {
                sumOfFirstHalfIntegers += array[i];
            }

            return sumOfFirstHalfIntegers;
        }

        private static int calculateProductOfLastHalfIntegers(int[] array)
        {
            int halfOfLengthArray = array.Length / 2;
            int productOfLastHalfIntegers = 1;

            for (int i = halfOfLengthArray; i < array.Length; i++)
            {
                productOfLastHalfIntegers *= array[i];
            }

            return productOfLastHalfIntegers;
        }
    }
}
