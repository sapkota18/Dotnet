using System;

namespace EmployeeApp
{
    class Employee
    {
        public int Id;
        public string Name;

        // Constructor
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
            Console.WriteLine("Constructor called");
        }

        // Destructor
        ~Employee()
        {
            Console.WriteLine("Destructor called");
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
            Employee emp1 = new Employee(1, "Mukesh");
            Employee emp2 = new Employee(2, "Suresh");

            Console.WriteLine("\nEmployee Details:");
            emp1.Display();
            emp2.Display();

            // Optional: force garbage collection to see destructor message
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
