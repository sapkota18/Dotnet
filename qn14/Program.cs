using System;

namespace EmployeeApp
{
    class Employee
    {
        // Private fields
        private int id;
        private string name;

        // Public property for ID
        public int Id
        {
            get { return id; }            // Getter
            set { id = value; }           // Setter
        }

        // Public property for Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp = new Employee();

            Console.Write("Enter Employee ID: ");
            emp.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            emp.Name = Console.ReadLine();

            Console.WriteLine("\nEmployee Details:");
            emp.Display();
        }
    }
}
