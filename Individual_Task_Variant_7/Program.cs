using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Linq;

namespace Individual_Task_Variant_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a collection of persons and add some different persons to it.
            //Output the data about employees elder than 40 years and wage less than 1000
            //Sort the data by Firstname and Lastname
            //Output the collection to a file
            //Implement exception handling
            //Serialize the collection to XML file
            //Deserialize it back
            //Write unit tests


            List<Person> personList = new List<Person>
            {
                new Person(4561, "Rostuslav", "Shevchenko", new DateTime(1988, 11, 19)),
                new Student(1113, "Dmutro", "Vivsianuk", new DateTime(2000, 08, 30),
                "National University Lviv Politechnic", new DateTime(2017, 09, 02)),
                new Employee(52147, "Vasuliy", "Dragan", new DateTime(1972, 02, 03),
                new DateTime(2018, 05, 16), 980),
                new Employee(2242, "Vitaliy", "Savka", new DateTime(1990, 05, 13),
                new DateTime(2013, 12, 31), 1610),
                new Student(3728, "Orest", "Hret", new DateTime(2002, 09, 28),
                "Lviv National University", new DateTime(2019, 09, 07)),
                new Person(7123, "Ira", "Kuruchenko", new DateTime(1976, 05, 01)),
                new Student(1113, "Volodumur", "Firman", new DateTime(1999, 07, 11),
                "National University Lviv Politechnic", new DateTime(2017, 10, 07)),
                new Employee(3128, "Olga", "Romaniv", new DateTime(1990, 10, 14),
                new DateTime(2011, 02, 01), 2100),
                new Employee(2242, "Tetiana", "Savka", new DateTime(1971, 09, 15),
                new DateTime(2009, 11, 04), 670),
                new Student(3728, "Edward", "Lutvun", new DateTime(2001, 03, 05),
                "Lviv National University", new DateTime(2018, 08, 30))
            };

            const ushort MinAge = 40;
            const ushort MaxWage = 1000;

            Console.WriteLine("Employees, that elder than " + MinAge + " years and have " +
                "wage less than " + MaxWage + ":");

            var query = personList.Where(person => person is Employee)
                .Select(person => (Employee)person)
                .Where(employee => (employee.GetAge() >= MinAge) && (employee.Wage <= MaxWage));

            OutputEmployees(query);

            Console.WriteLine("List of people:\n");
            OutputPersonsNameList(personList);

            Console.WriteLine("\nSorting people by last name and first name...");

            personList.Sort(new Person.Comparer());

            Console.WriteLine("\nList of people after sorting by last name and " +
                "first name:\n");
            OutputPersonsNameList(personList);

            string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string filePath = userPath + "\\people_collection.txt";
            string xmlPath = userPath + "\\people.xml";

            OutputPeopleDataToTheFile(filePath, personList);
            SerializeToXML(xmlPath, personList);
            DeserializeFromXML(xmlPath, ref personList);

            Console.WriteLine("List of people after deserialization: \n");

            OutputPersonsNameList(personList);
        }

        public static void OutputEmployees(IEnumerable<Person> list)
        {
            foreach (Person person in list)
            {
                person.Output();
            }
        }

        public static void OutputPersonsNameList(List<Person> personList)
        {
            foreach (Person person in personList)
            {
                Console.WriteLine("First name: " + person.FirstName + ",\tlast name: " + person.LastName);
            }
        }

        public static void OutputPeopleDataToTheFile(string path, List<Person> list)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    foreach (Person person in list)
                    {
                        writer.Write(person.ToString());
                    }
                }

                Console.WriteLine("\nAdding data to the file was successful!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Adding data to the file was unsuccessful!");
                Console.WriteLine(ex.Message);
            }
        }

        public static void SerializeToXML(string xmlPath, List<Person> list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

            using (StreamWriter writer = new StreamWriter(xmlPath, false, Encoding.UTF8))
            {
                serializer.Serialize(writer, list);
            }

            Console.WriteLine("\nObject serialization...\n");
        }

        public static void DeserializeFromXML(string xmlPath, ref List<Person> objectList)
        {
            try
            {
                using (StreamReader reader = new StreamReader(xmlPath, Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

                    objectList = serializer.Deserialize(reader) as List<Person>;
                }

                Console.WriteLine("\nXML deserialization...\n");
        }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
}
    }
}
