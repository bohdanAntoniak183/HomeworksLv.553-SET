using System;

namespace Individual_Task_Variant_7
{
    public class Employee : Person
    {
        //Define a descendant class Employee that has:
        //Additional properties EmploymentDate, Wage
        //Constructor with parameters
        //Overridden input() and output() methods

        public DateTime EmploymentDate { get; set; }
        public ushort Wage { get; set; }

        public Employee() : this(0, "Unknown", "Unknown", new DateTime(), new DateTime(), 0)
        {

        }

        public Employee(ushort taxNumber, string firstName, string lastName, DateTime birthDate,
            DateTime employmentDate, ushort wage) : base(taxNumber, firstName, lastName, birthDate)
        {
            EmploymentDate = employmentDate;
            Wage = wage;
        }

        public override void Input()
        {
            base.Input();
            InputEmploymentDate();
            InputWage();
        }

        public override void Output()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return "\nFirst name: " + FirstName + "\nLast name: " + LastName +
                "\nBirth date: " + BirthDate.ToString("d") + "\nTax number: " + TaxNumber +
                "\nEmployment date: " + EmploymentDate.ToString("d") + "\nWage: " + Wage + "\n";
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                Employee employee = (Employee)obj;
                return FirstName.Equals(employee.FirstName) &&
                    LastName.Equals(employee.LastName) &&
                    TaxNumber.Equals(employee.TaxNumber) &&
                    BirthDate.Equals(employee.BirthDate) &&
                    EmploymentDate.Equals(employee.EmploymentDate) &&
                    Wage.Equals(employee.Wage);
            }
            else return false;
        }

        private void InputEmploymentDate()
        {
            string enterEmploymentDateMessage = "Enter person's employment date (in YYYY.MM.DD format): ";

            EmploymentDate = InputDate(enterEmploymentDateMessage);
        }

        private void InputWage()
        {
            string enterWageMessage = "Enter employee`s wage: ";

            Wage = InputInteger(enterWageMessage);
        }
    }
}
