using System;

namespace Task2
{
    enum TestCaseStatus
    {
        Pass,
        Fail,
        Blocked,
        WB,
        Unexecuted
    }

    struct RGB
    {
        public byte red;
        public byte green;
        public byte blue;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            bool isNumbersRepresentDayAndMonth = ( (0 < day) && (day <= 31) ) && ( (0 < month) && (month <= 12) );
            Console.WriteLine("\nEntered numbers can represent the day and month: " + isNumbersRepresentDayAndMonth);

            Console.Write("Enter double number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            double fractionalPartOfNumber = number - Math.Floor(number);
            int firstNumberAfterPoint = Convert.ToInt32(Math.Floor(fractionalPartOfNumber * 10));
            int secondNumberAfterPoint = Convert.ToInt32(Math.Floor(fractionalPartOfNumber * 100) % 10);
            int sumOfNumbersAfterPoint = firstNumberAfterPoint + secondNumberAfterPoint;

            Console.WriteLine("\nSum of first and second number after point: {0} + {1} = {2}", firstNumberAfterPoint, secondNumberAfterPoint, sumOfNumbersAfterPoint);

            Console.Write("\nEnter the time of day(in hours): ");
            int h = Convert.ToInt32(Console.ReadLine());

            if (h < 0)
            {
                Console.WriteLine("\nIncorrect!");
            }
            else if (h < 6)
            {
                Console.WriteLine("\nGood night!");
            }
            else if (h < 12)
            {
                Console.WriteLine("\nGood morning!");
            }
            else if (h < 18)
            {
                Console.WriteLine("\nGood afternoon!");
            }
            else if (h < 24)
            {
                Console.WriteLine("\nGood evening!");
            }
            else Console.WriteLine("\nIncorrect!");

            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine("\nTest case status : " + test1Status);

            RGB white;
            white.red = 0;
            white.blue = 0;
            white.green = 0;

            RGB black;
            black.red = 255;
            black.blue = 255;
            black.green = 255;
        }
    }
}
