using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int areaOfSquare = a * a;
            int perimetrOfSquare = 4 * a;

            Console.WriteLine("\nArea of square: " + areaOfSquare);
            Console.WriteLine("Perimetr of square: " + perimetrOfSquare);

            string name;
            int age;

            Console.WriteLine("\nWhat is your name?");
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("\nHow old are you, " + name + "?");
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYour name is " + name + ", your age is " + age + ".");

            Console.Write("\nEnter radius of circle: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double lengthOfCircle = 2 * Math.PI * r;
            double areaOfCircle = Math.PI * r * r;
            double volumeOfCircle = (4 / 3) * Math.PI * r * r * r;

            Console.WriteLine("\nLength of circle: " + lengthOfCircle);
            Console.WriteLine("Area of circle: " + areaOfCircle);
            Console.WriteLine("Volume of circle: " + volumeOfCircle);
        }
    }
}
