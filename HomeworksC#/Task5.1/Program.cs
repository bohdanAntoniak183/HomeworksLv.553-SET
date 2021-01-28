using System;
using System.Collections.Generic;

namespace Task5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> flyables = new List<IFlyable>
            {
                new Bird("BirdName1", true),
                new Bird("BirdName1", false),
                new Plane(11564, true),
                new Plane(25896, false)
            };

            foreach (IFlyable flyable in flyables)
            {
                flyable.Fly();
            }
        }
    }
}
