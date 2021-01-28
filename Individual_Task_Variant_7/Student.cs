using System;

namespace Individual_Task_Variant_7
{
    public class Student : Person
    {
        //Define a descendant class Student that has:
        //Additional properties UniversityName, UniversityAdmissionDate
        //Constructor with parameters
        //Overridden input() and output() methods


        public string UniversityName { get; set; }
        public DateTime UniversityAdmissionDate { get; set; }

        public Student() : this(0, "Unknown", "Unknown", new DateTime(), "Unknown", new DateTime())
        {

        }

        public Student(ushort taxNumber, string firstName, string lastName, DateTime birthDate,
            string universityName, DateTime universityAdmissionDate) : base(taxNumber, firstName, lastName,
                birthDate)
        {
            UniversityName = universityName;
            UniversityAdmissionDate = universityAdmissionDate;
        }

        public override void Input()
        {
            base.Input();
            InputUniversityName();
            InputUniversityAdmissionDate();
        }

        public override void Output()
        {
            Console.WriteLine(ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj is Student)
            {
                Student student = (Student)obj;
                return FirstName.Equals(student.FirstName) &&
                    LastName.Equals(student.LastName) &&
                    TaxNumber.Equals(student.TaxNumber) &&
                    BirthDate.Equals(student.BirthDate) &&
                    UniversityName.Equals(student.UniversityName) &&
                    UniversityAdmissionDate.Equals(student.UniversityAdmissionDate);
            }
            else return false;
        }

        public override string ToString()
        {
            return "\nFirst name: " + FirstName + "\nLast name: " + LastName +
                "\nBirth date: " + BirthDate.ToString("d") + "\nTax number: " + TaxNumber +
                "\nUniversity name: " + UniversityName + "\nUniversity admission date: " +
                UniversityAdmissionDate.ToString("d") + "\n";
        }

        private void InputUniversityName()
        {
            string enterUniversityNameMessage = "Enter the university name of student: ";

            UniversityName = InputString(enterUniversityNameMessage);
        }

        private void InputUniversityAdmissionDate()
        {
            string enterUniversityAdmissionDateMessage = "Enter university student admission date " +
                "(in YYYY.MM.DD format): ";

            UniversityAdmissionDate = InputDate(enterUniversityAdmissionDateMessage);
        }
    }
}
