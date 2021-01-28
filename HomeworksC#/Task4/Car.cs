using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Car
    {
        private string name;
        private string color;
        private uint price;
        private const string CompanyName = "Renault";

        public Car()
        {
            name = "Unknown";
            color = "Unknown";
            price = 0;
        }

        public Car(string name, string color, uint price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }

        public string Color
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public void Input()
        {
            Console.Write("Enter the name of the car: ");
            name = Console.ReadLine();

            Console.Write("Enter the color of the car: ");
            color = Console.ReadLine();

            Console.Write("Enter the price of the car: ");
            price = Convert.ToUInt32(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("\nThis is a " + name + " car in the " + color + " color. It's price " + price + ".\n");
        }

        public void ChangePrice(double percent)
        {
            percent = percent * 0.01;

            price = Convert.ToUInt32(price * percent);
        }

        public void ChangeColorIfItIsWhite(string color)
        {
            if (this.color.ToLower() == "white")
            {
                this.color = color;
                Console.WriteLine("\nColor of the car " + name + " is changed to " + this.color + ".");
            }
            else
            {
                Console.WriteLine("\nCar " + name + " isn't white, so color wasn't changed.");
            }

        }

        public static bool operator ==(Car firstCar, Car lastCar)
        {
            return ( firstCar.name == lastCar.name) && ( firstCar.price == lastCar.price );
        }

        public static bool operator !=(Car firstCar, Car lastCar)
        {
            return !(firstCar == lastCar);
        }

        public override string ToString()
        {
            return "\nCar name: " + name + "\nColor: " + Color + "\nPrice: " + price;
        }
    }
}
