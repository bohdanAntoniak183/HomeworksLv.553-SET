using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car renault = new Car("Renault", "green", 15000);
            Car citroen = new Car("Citroen", "white", 10000);
            Car opel = new Car("Opel", "black", 20000);
            Car newOpel = new Car("Opel", "black", 18000);

            renault.ChangePrice(90);
            citroen.ChangePrice(90);
            opel.ChangePrice(90);

            renault.Print();
            citroen.Print();
            opel.Print();

            renault.ChangeColorIfItIsWhite("blue");
            citroen.ChangeColorIfItIsWhite("blue");

            CompareCars(opel, newOpel);
            CompareCars(renault, citroen);
        }

        private static void CompareCars(Car firstCar, Car lastCar)
        {
            Console.WriteLine("\nNext cars is the same: " + (firstCar == lastCar) +
                "\n" + firstCar.ToString() + "\n" + lastCar.ToString());
        }

    }
}
