using System;


    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}");
        }
    }

    class Program
    {
        static void Main()
        {
            Employee[] employees = new Employee[2]; // Only 2 employees

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"\nEnter details for Employee {i + 1}:");

                Console.Write("Enter ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                employees[i] = new Employee
                {
                    Id = id,
                    Name = name
                };
            }

            Console.WriteLine("\nEmployee Details:");
            foreach (var employee in employees)
            {
                employee.Display();
            }
        }
    }

