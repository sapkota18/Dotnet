using System;
using MySql.Data.MySqlClient;

class Program
{
    static string connStr = "server=localhost;user=root;password=;database=test1;";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
           Console.WriteLine("1. Insert Student   2. View All Students   3. Update Student   4. Delete Student   5. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: InsertStudent(); break;
                case 2: ReadStudents(); break;
                case 3: UpdateStudent(); break;
                case 4: DeleteStudent(); break;
                case 5: return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    static void InsertStudent()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = $"INSERT INTO Students(Name, Age) VALUES('{name}', {age})";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Student inserted successfully.");
        }
    }

    static void ReadStudents()
    {
        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = "SELECT * FROM Students";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\n--- Student List ---");
            while (reader.Read())
            {
                Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");
            }
        }
    }

    static void UpdateStudent()
    {
        Console.Write("Enter Student ID to update: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter new Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter new Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = $"UPDATE Students SET Name='{name}', Age={age} WHERE Id={id}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
                Console.WriteLine("Student updated successfully.");
            else
                Console.WriteLine("Student ID not found.");
        }
    }

    static void DeleteStudent()
    {
        Console.Write("Enter Student ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = $"DELETE FROM Students WHERE Id={id}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
                Console.WriteLine("Student deleted successfully.");
            else
                Console.WriteLine("Student ID not found.");
        }
    }
}
