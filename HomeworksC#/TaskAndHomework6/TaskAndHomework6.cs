using System;

namespace TaskAndHomework6
{
    class EnteredNumberNotInRangeException: Exception
    {
        public EnteredNumberNotInRangeException(string message) : base(message)
        {

        }
    }

    class Program
    {
        private static int div(int firstNumber, int secondNumber)
        {
            if ( secondNumber == 0 )
            {
                throw new DivideByZeroException("Division by zero does not exist!");
            }

            return ( firstNumber / secondNumber );
        }

        private static void printInfo(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        private static int readNumber(int start, int end)
        {
            int number;

            try
            {
                Console.Write("\nEnter number in [" + start + ", " + end + "] range: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException ex)
            {
                throw ex;
            }

            if ( ( number < start ) || ( number > end ) )
            {
                throw new EnteredNumberNotInRangeException("Entered number isn't in range [" + start + ", " 
                    + end + "].");
            }
            else
            {
                return number;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number for division: ");
                int firstEnteredNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number for division: ");
                int secondEnteredNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The result of division first and second number is: " 
                    + div(firstEnteredNumber, secondEnteredNumber));
            }
            catch (FormatException ex)
            {
                printInfo(ex);
            }
            catch (DivideByZeroException ex)
            {
                printInfo(ex);
            }
            catch (ArithmeticException ex)
            {
                printInfo(ex);
            }
            catch (Exception ex)
            {
                printInfo(ex);
            }

            const int firstBoundary = 1;
            const int secondBoundary = 100;
            const int countNumbersToWrite = 10;


            for (int i = 0; i < countNumbersToWrite; i++)
            {
                try
                {
                    Console.WriteLine("Your entered number " + readNumber(firstBoundary, secondBoundary) +
                    " is in range [" + firstBoundary + ", " + secondBoundary + "].");
                }
                catch (FormatException ex)
                {
                    printInfo(ex);
                }
                catch (EnteredNumberNotInRangeException ex)
                {
                    printInfo(ex);
                }
                catch (Exception ex)
                {
                    printInfo(ex);
                }
            }
        }
    }
}
