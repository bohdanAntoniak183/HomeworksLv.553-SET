using System;
using NUnit.Framework;
using Individual_Task_Variant_7;
using System.Collections.Generic;

namespace NUnitProgramTest
{
    public class UnitTest1
    {
        [Test]
        public void SortTest()
        {
            Person person = new Person();

            List<Person> actualPeople = new List<Person>
            {
                new Student(3728, "Edward", "Lutvun", new DateTime(2001, 03, 05),
                "Lviv National University", new DateTime(2018, 08, 30)),
                new Employee(3128, "Olga", "Romaniv", new DateTime(1990, 10, 14),
                new DateTime(2011, 02, 01), 2100),
                new Person(7123, "Ira", "Kuruchenko", new DateTime(1976, 05, 01)),
                new Employee(2242, "Vitaliy", "Savka", new DateTime(1990, 05, 13),
                new DateTime(2013, 12, 31), 1610),
                new Student(1113, "Dmutro", "Vivsianuk", new DateTime(2000, 08, 30),
                "National University Lviv Politechnic", new DateTime(2017, 09, 02)),
                new Person(4561, "Rostuslav", "Shevchenko", new DateTime(1988, 11, 19)),
                new Employee(52147, "Vasuliy", "Dragan", new DateTime(1972, 02, 03),
                new DateTime(2018, 05, 16), 980),
                new Student(3728, "Orest", "Hret", new DateTime(2002, 09, 28),
                "Lviv National University", new DateTime(2019, 09, 07)),
                new Student(1113, "Volodumur", "Firman", new DateTime(1999, 07, 11),
                "National University Lviv Politechnic", new DateTime(2017, 10, 07)),
                new Employee(2242, "Tetiana", "Savka", new DateTime(1971, 09, 15),
                new DateTime(2009, 11, 04), 670)
            };
            List<Person> expectedPeople = new List<Person>
            {
                new Employee(52147, "Vasuliy", "Dragan", new DateTime(1972, 02, 03),
                new DateTime(2018, 05, 16), 980),
                new Student(1113, "Volodumur", "Firman", new DateTime(1999, 07, 11),
                "National University Lviv Politechnic", new DateTime(2017, 10, 07)),
                new Student(3728, "Orest", "Hret", new DateTime(2002, 09, 28),
                "Lviv National University", new DateTime(2019, 09, 07)),
                new Person(7123, "Ira", "Kuruchenko", new DateTime(1976, 05, 01)),
                new Student(3728, "Edward", "Lutvun", new DateTime(2001, 03, 05),
                "Lviv National University", new DateTime(2018, 08, 30)),
                new Employee(3128, "Olga", "Romaniv", new DateTime(1990, 10, 14),
                new DateTime(2011, 02, 01), 2100),
                new Employee(2242, "Tetiana", "Savka", new DateTime(1971, 09, 15),
                new DateTime(2009, 11, 04), 670),
                new Employee(2242, "Vitaliy", "Savka", new DateTime(1990, 05, 13),
                new DateTime(2013, 12, 31), 1610),
                new Person(4561, "Rostuslav", "Shevchenko", new DateTime(1988, 11, 19)),
                new Student(1113, "Dmutro", "Vivsianuk", new DateTime(2000, 08, 30),
                "National University Lviv Politechnic", new DateTime(2017, 09, 02))
            };

            actualPeople.Sort(new Person.Comparer());

            CollectionAssert.AreEqual(expectedPeople, actualPeople);
        }
    }
}