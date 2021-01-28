using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Individual_Task_Variant_7
{
    [XmlInclude(typeof(Student))]
    [XmlInclude(typeof(Employee))]
    public class Person
    {
        //Define a class Person which contains:
        //Properties TaxNumber, Firstname, Lastname, Birthdate
        //Constructor with parameters
        //Input() and output() methods for input/output from/to console
        //Method GetAge() calculating the person’s age in full years
        //Overridden ToString() method

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort TaxNumber { get; set; }
        public DateTime BirthDate { get; set; }

        public Person() : this(0, "Unknown", "Unknown", new DateTime())
        {

        }

        public Person (ushort taxNumber, string firstName, string lastName, DateTime birthDate)
        {
            TaxNumber = taxNumber;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public virtual void Input()
        {
            InputFirstName();
            InputLastName();
            InputBirthDate();
            InputTaxNumber();
        }

        public virtual void Output()
        {
            Console.WriteLine(ToString());
        }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        public override string ToString()
        {
            return "\nFirst name: " + FirstName + "\nLast name: " + LastName +
                "\nBirth date: " + BirthDate.ToString("d") + "\nTax number: " + TaxNumber + "\n";
        }

        private void InputFirstName()
        {
            string enterFirstNameMessage = "Enter the first name of person: ";

            FirstName = InputString(enterFirstNameMessage);
        }

        private void InputLastName()
        {
            string enterLastNameMessage = "Enter the last name of person: ";

            LastName = InputString(enterLastNameMessage);
        }

        private void InputBirthDate()
        {
            string enterBirthDateMessage = "Enter person's birth date (in YYYY.MM.DD format): ";

            BirthDate = InputDate(enterBirthDateMessage);
        }

        private void InputTaxNumber()
        {
            string enterTaxNumberMessage = "Enter the person's tax number: ";

            TaxNumber = InputInteger(enterTaxNumberMessage);
        }
        
        protected string InputString(string message)
        {
            string tempString;

            do
            {
                Console.Write(message);
                tempString = Console.ReadLine();

                if (ValidateString(tempString))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nEntered value isn't correct! Please, try again!\n");
                }
            }
            while (true);

            return tempString;
        }

        protected DateTime InputDate(string message)
        {
            string tempDate;

            do
            {
                Console.Write(message);
                tempDate = Console.ReadLine();

                if (ValidateDate(tempDate))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nEntered date incorrect! Please, try again.\n");
                }
            }
            while (true);

            return DateTime.Parse(tempDate);
        }

        protected ushort InputInteger(string message)
        {
            string tempInteger;

            do
            {
                Console.Write(message);
                tempInteger = Console.ReadLine();

                if (ValidateInteger(tempInteger))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nEntered number incorrect! Please, try again.\n");
                }
            }
            while (true);

            return UInt16.Parse(tempInteger);
        }

        protected bool IsStringContainsNumberOrSpecialCharacters(string str)
        {
            foreach(char character in str)
            {
                if ( !( Char.IsLetter(character) ) && (character != ' ') )
                {
                    return true;
                }
            }

            return false;
        }
        
        protected bool ValidateInteger(string value)
        {
            ushort tempInteger;
            return UInt16.TryParse(value, out tempInteger);
        }

        protected bool ValidateString(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return false;
            }
            else if (IsStringContainsNumberOrSpecialCharacters(value))
            {
                return false;
            }
            else return true;
        }

        protected bool ValidateDate(string value)
        {
            DateTime date;
            return DateTime.TryParse(value, out date);
        }

        public class Comparer : IComparer<Person>
        {
            public int Compare(Person firstPerson, Person lastPerson)
            {
                if (firstPerson.LastName.CompareTo(lastPerson.LastName) == 0)
                {
                    return firstPerson.FirstName.CompareTo(lastPerson.FirstName);
                }
                else return firstPerson.LastName.CompareTo(lastPerson.LastName);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                Person person = (Person)obj;
                return FirstName.Equals(person.FirstName) &&
                    LastName.Equals(person.LastName) &&
                    TaxNumber.Equals(person.TaxNumber) &&
                    BirthDate.Equals(person.BirthDate);
            }
            else return false;
        }
    }
}
