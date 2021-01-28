using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._1
{
    class Plane: IFlyable
    {
        private ushort mark;
        private bool highFly;

        public Plane(ushort mark, bool highFly)
        {
            this.mark = mark;
            this.highFly = highFly;
        }

        public void Fly()
        {
            if (highFly)
            {
                Console.WriteLine("The plane with mark " + mark + " is flying high.");
            }
            else
            {
                Console.WriteLine("The plane with mark " + mark + " is flying, but not high.");
            }
        }
    }
}
