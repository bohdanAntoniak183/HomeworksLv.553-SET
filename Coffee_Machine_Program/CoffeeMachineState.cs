using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Machine_Program
{
    abstract class CoffeeMachineState
    {
        protected CoffeeMachine coffeeMachine;
        protected string message;

        public void SetCoffeeMachine(CoffeeMachine coffeeMachine)
        {
            this.coffeeMachine = coffeeMachine;
        }

        public abstract void DispayState();
    }

    class WaitingState: CoffeeMachineState
    {
        public override void DispayState()
        {
            int temp = 1;

            Console.WriteLine("Select the sort of coffee from which the coffee should be made:");

            foreach (SortsOfCoffee sort in Enum.GetValues(typeof(SortsOfCoffee)))
            {
                Console.WriteLine(temp + ". " + sort + ".");
                temp++;
            }

            Console.Write("Write number of option: ");
        }
    }

    class ResultSelectionState : CoffeeMachineState
    {
        public ResultSelectionState(string message)
        {
            this.message = message;
        }

        public override void DispayState()
        {
            Console.WriteLine(this.message);
        }
    }
}
