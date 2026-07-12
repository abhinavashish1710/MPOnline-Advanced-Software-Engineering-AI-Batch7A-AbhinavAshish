using System;
using System.Collections.Generic;

namespace Assignment11_CustomSorting
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }

        public Employee(int id, string name, double salary, DateTime joiningDate)
        {
            EmployeeID = id;
            Name = name;
            Salary = salary;
            JoiningDate = joiningDate;
        }
    }

    class Program
    {
        static void Display(List<Employee> employees)
        {
            Console.WriteLine("\nID\tName\tSalary\tJoining Date");
            Console.WriteLine("---------------------------------------------");

            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.EmployeeID}\t{emp.Name}\t{emp.Salary}\t{emp.JoiningDate:dd/MM/yyyy}");
            }
        }

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter number of employees: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEmployee {i + 1}");

                Console.Write("Employee ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                Console.Write("Joining Date (dd/MM/yyyy): ");
                DateTime joiningDate = DateTime.ParseExact(
                    Console.ReadLine(),
                    "dd/MM/yyyy",
                    null);

                employees.Add(new Employee(id, name, salary, joiningDate));
            }

            Console.WriteLine("\nSort By");
            Console.WriteLine("1. Salary");
            Console.WriteLine("2. Joining Date");
            Console.WriteLine("3. Employee ID");
            Console.Write("Enter Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    employees.Sort((a, b) => a.Salary.CompareTo(b.Salary));
                    break;

                case 2:
                    employees.Sort((a, b) => a.JoiningDate.CompareTo(b.JoiningDate));
                    break;

                case 3:
                    employees.Sort((a, b) => a.EmployeeID.CompareTo(b.EmployeeID));
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    return;
            }

            Display(employees);

            Console.ReadLine();
        }
    }
}