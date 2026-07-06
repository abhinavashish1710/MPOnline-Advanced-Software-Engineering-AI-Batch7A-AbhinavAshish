using System;

namespace Assignment03_EmployeeManagement
{
    // Base Class
    class Employee
    {
        public virtual void GenerateReport()
        {
            Console.WriteLine("Employee Report");
        }
    }

    // Developer Class
    class Developer : Employee
    {
        public override void GenerateReport()
        {
            Console.WriteLine("Developer Report: Project Development Status");
        }
    }

    // Tester Class
    class Tester : Employee
    {
        public override void GenerateReport()
        {
            Console.WriteLine("Tester Report: Bugs Found in the Project");
        }
    }

    // Manager Class
    class Manager : Employee
    {
        public override void GenerateReport()
        {
            Console.WriteLine("Manager Report:");
            Console.WriteLine("Project Development Status");
            Console.WriteLine("Bug Report Summary");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee developer = new Developer();
            Employee tester = new Tester();
            Employee manager = new Manager();

            developer.GenerateReport();
            Console.WriteLine();

            tester.GenerateReport();
            Console.WriteLine();

            manager.GenerateReport();
        }
    }
}