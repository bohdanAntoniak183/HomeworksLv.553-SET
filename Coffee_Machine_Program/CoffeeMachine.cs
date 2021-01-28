using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Machine_Program
{
    class CoffeeMachine
    {
        public CoffeeSort[] SortsOfCoffeeIsAvailable { get; }
        public uint BalanceOfSession { get; private set; }
        private CoffeeMachineState coffeeMachineState;

        public CoffeeMachine(params CoffeeSort[] sortsOfCoffeeIsAvailable)
        {
            SortsOfCoffeeIsAvailable = sortsOfCoffeeIsAvailable;
            BalanceOfSession = 0;
        }

        private void TransitionToState(CoffeeMachineState coffeeMachineState)
        {
            this.coffeeMachineState = coffeeMachineState;
            this.coffeeMachineState.SetCoffeeMachine(this);
        }

        private void DisplayState()
        {
            this.coffeeMachineState.DispayState();
        }

        private List<SortsOfCoffee> GetNamesOfSortsThatIsAvailable()
        {
            List<SortsOfCoffee> temp = new List<SortsOfCoffee>();

            foreach (CoffeeSort sort in SortsOfCoffeeIsAvailable)
            {
                temp.Add(sort.sortName);
            }

            return temp;
        }

        class Program
        {
            static void Main(string[] args)
            {
                CoffeeSort arabica = new CoffeeSort(SortsOfCoffee.Arabica, 2);
                CoffeeSort robusta = new CoffeeSort(SortsOfCoffee.Robusta, 5);

                CoffeeMachine coffeeMaker = new CoffeeMachine(arabica, robusta);
                User coffeeLover = new User(5);
                Program.Run(coffeeMaker, coffeeLover);
            }

            private static void Run(CoffeeMachine coffeeMachine, User user)
            {
                CoffeeSort selectedSortOfCoffee = Program.SelectionCoffee(coffeeMachine, user);
            }

            private static CoffeeSort SelectionCoffee(CoffeeMachine coffeeMachine, User user)
            {
                while (true)
                {
                    coffeeMachine.TransitionToState(new WaitingState());
                    coffeeMachine.DisplayState();
                    uint selectedSortOfCoffee = user.SelectSortOfCoffee();

                    if (selectedSortOfCoffee == 0)
                    {
                        coffeeMachine.TransitionToState(new ResultSelectionState("\nYou entered incorrect character! Please, try again.\n"));
                        coffeeMachine.DisplayState();
                        continue;
                    }
                    else if (!Program.IsSelectedSortOfCoffeeInList((SortsOfCoffee)selectedSortOfCoffee, (SortsOfCoffee[]) Enum.GetValues(typeof(SortsOfCoffee))))
                    {
                        coffeeMachine.TransitionToState(new ResultSelectionState("\nYou entered not existing sort of coffee! Please, try again.\n"));
                        coffeeMachine.DisplayState();
                        continue;
                    }
                    else if (!Program.IsSelectedSortOfCoffeeInList((SortsOfCoffee)selectedSortOfCoffee, (SortsOfCoffee[])coffeeMachine.GetNamesOfSortsThatIsAvailable().ToArray()))
                    {
                        coffeeMachine.TransitionToState(new ResultSelectionState("\nYour option isn't available now. Please, choose another option, or come later.\n"));
                        coffeeMachine.DisplayState();
                        continue;
                    }
                    else
                    {
                        coffeeMachine.TransitionToState(new ResultSelectionState("\nYou selected " + (SortsOfCoffee)selectedSortOfCoffee + " sort of coffee. It is available.\n"));
                        coffeeMachine.DisplayState();
                    }

                    foreach (CoffeeSort sort in coffeeMachine.SortsOfCoffeeIsAvailable)
                    {
                        if (sort.sortName == (SortsOfCoffee)selectedSortOfCoffee)
                        {
                            return sort;
                        }
                    }
                }
            }

            private static bool IsSelectedSortOfCoffeeInList(SortsOfCoffee selectedSort, SortsOfCoffee[] list)
            {
                foreach (SortsOfCoffee sort in list)
                {
                    if (selectedSort == sort)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }

    
}
