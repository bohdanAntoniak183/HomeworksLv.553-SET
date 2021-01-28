using System;
using System.Collections.Generic;
using NUnit.Framework;
using Individual_Task_Variant_7;

namespace NUnitProgramTest
{
    class UnitTest3
    {
        // File serialization_test.txt capacity
        //
        //<?xml version = "1.0" encoding="utf-8"?>
        //    <ArrayOfPerson xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
        //        <Person xsi:type="Employee">
        //            <FirstName>Olga</FirstName>
        //            <LastName>Romaniv</LastName>
        //            <TaxNumber>3128</TaxNumber>
        //            <BirthDate>1990-10-14T00:00:00</BirthDate>
        //            <EmploymentDate>2011-02-01T00:00:00</EmploymentDate>
        //            <Wage>2400</Wage>
        //        </Person>
        //    </ArrayOfPerson>

        [Test]
        public void DeserializationXMLTest()
        {
            string objectFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
                "\\serialization_test.txt";
            List<Person> expectedPeople = new List<Person>
            {
                new Employee(3128, "Olga", "Romaniv", new DateTime(1990, 10, 14),
                new DateTime(2011, 02, 01), 2400),
            };
            List<Person> actualPeople = new List<Person>
            {
                new Employee(3128, "Olga", "Romaniv", new DateTime(1990, 10, 14),
                new DateTime(2011, 02, 01), 2100)
            };

            Program.DeserializeFromXML(objectFile, ref actualPeople);

            CollectionAssert.AreEqual(expectedPeople, actualPeople);
        }
    }
}
