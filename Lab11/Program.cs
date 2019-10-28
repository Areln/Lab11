using System;
using System.Collections.Generic;
namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> peopleList = new List<Person>()
            { 
                new Person("Person", "Person's Address"),
                new Student("Student1", "Student1's Address", "C# .NET", 2019, 9000),
                new Student("Student2", "Student2's Address", "Java", 2019, 9000),
                new Student("Student3", "Student3's Address", "C# .NET", 2019, 9000),
                new Staff("staff1", "Staff1's Address", "Grand Circus", 19),
                new Staff("staff2", "Staff1's Address", "Grand Circus", 19),
            };

            foreach (Person person in peopleList)
            {
                Console.WriteLine(person.ToString());
            }

        }
    }
}
