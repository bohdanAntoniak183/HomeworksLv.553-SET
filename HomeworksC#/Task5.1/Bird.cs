using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._1
{
    class Bird : IFlyable
    {
        private string name;
        private bool canFly;

        public Bird(string name, bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }

        public void Fly()
        {
            if (canFly)
            {
                Console.WriteLine("Bird " + name + " is flying.");
            }
            else
            {
                Console.WriteLine("Bird " + name + " can't fly.");
            }
        }
    }
}
