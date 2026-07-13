using System;
using System.Collections.Generic;

namespace Assignment08_AgeSorting
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Console.Write("Enter number of persons: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nEnter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                persons.Add(new Person(name, age));
            }

            // Sort by Age
            persons.Sort((p1, p2) => p1.Age.CompareTo(p2.Age));

            Console.WriteLine("\nPersons Sorted by Age");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Name\tAge");

            foreach (Person p in persons)
            {
                Console.WriteLine($"{p.Name}\t{p.Age}");
            }

            Console.ReadLine();
        }
    }
}
