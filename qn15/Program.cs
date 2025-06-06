using System;

namespace StaticDemo
{
    class Employee
    {
        public int Id;
        public string Name;

        // Static field (shared across all objects)
        public static string CompanyName = "TechCorp";

        // Static method to display employee details
        public static void Display(Employee emp)
        {
            Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Company: {CompanyName}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating employee objects
            Employee emp1 = new Employee { Id = 106, Name = "Aman" };
            Employee emp2 = new Employee { Id = 107, Name = "Raman" };

            Console.WriteLine("Employee Details:");
            Employee.Display(emp1);
            Employee.Display(emp2);
        }
    }
}
