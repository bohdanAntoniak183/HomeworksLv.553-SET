using System;

namespace Homework2
{
    enum HTTPError
    {
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        Conflict = 409,
        Gone = 410,
        Locked = 423,
    }

    struct Dog
    {
        public string name;
        public uint mark;
        public uint age;

        public override string ToString()
        {
            return "\nDog name is " + name + ", his mark is " + mark + ", he is " + age + " years old.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const float firstBoundaryValue = -5;
            const float lastBoundaryValue = 5;

            Console.Write("Enter first float number: ");
            float firstFloatNumber = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second float number: ");
            float secondFloatNumber = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter third float number: ");
            float thirdFloatNumber = (float)Convert.ToDouble(Console.ReadLine());

            bool areNumbersBelongToTheRange = ( ( firstFloatNumber >= firstBoundaryValue ) && ( firstFloatNumber <= lastBoundaryValue ) ) 
                && ( ( secondFloatNumber >= firstBoundaryValue ) && ( secondFloatNumber <= lastBoundaryValue ) ) 
                && ( ( thirdFloatNumber >= firstBoundaryValue ) && ( thirdFloatNumber <= lastBoundaryValue ) );

            Console.WriteLine("\nAll numbers belong to the range [-5; 5]: " + areNumbersBelongToTheRange);

            Console.Write("\nEnter first integer number: ");
            int firstIntegerNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer number: ");
            int secondIntegerNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third integer number: ");
            int thirdIntegerNumber = Convert.ToInt32(Console.ReadLine());

            int maxIntegerNumber = Math.Max(Math.Max(firstIntegerNumber, secondIntegerNumber), thirdIntegerNumber);
            int minIntegerNumber = Math.Min(Math.Min(firstIntegerNumber, secondIntegerNumber), thirdIntegerNumber);

            Console.WriteLine("\nMax number of integer numbers: " + maxIntegerNumber);
            Console.WriteLine("Min number of integer numbers: " + minIntegerNumber);

            Console.Write("\nEnter the number of HTTP error: ");
            int numberOfHTTPError = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nName of HTTP error: " + (HTTPError)numberOfHTTPError);

            Dog myDog;
            myDog.name = "Barbos";
            myDog.mark = 15;
            myDog.age = 3;

            Console.WriteLine(myDog.ToString());
        }
    }
}
