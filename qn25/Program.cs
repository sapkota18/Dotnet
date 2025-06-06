using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student { Name = "Alice", Age = 20, Grade = 85.5 },
            new Student { Name = "Bob", Age = 17, Grade = 92.0 },
            new Student { Name = "Ramesh", Age = 19, Grade = 72.3 },
            new Student { Name = "Mukesh", Age = 21, Grade = 88.8 },
            new Student { Name = "Suresh", Age = 18, Grade = 95.2 }
        };

        // 1. All students older than 18
        var olderThan18 = students.Where(s => s.Age > 18);

        // 2. Students with grade >= 90
        var gradeAbove90 = students.Where(s => s.Grade >= 90);

        // 3. Students aged between 18 and 20 inclusive
        var ageBetween18And20 = students.Where(s => s.Age   >= 18 && s.Age <= 20);

        // 4. Students whose names start with A or E
        var namesStartWithAE = students.Where(s => s.Name.StartsWith("A") || s.Name.StartsWith("E"));

        // 5. Top 3 students by grade descending
        var top3ByGrade = students.OrderByDescending(s => s.Grade).Take(3);

        // 6. Count of students younger than 20
        var countYoungerThan20 = students.Count(s => s.Age < 20);

        // 7. Average grade of all students
        var avgGrade = students.Average(s => s.Grade);

        // 8. Check if any student has grade less than 70
        var anyGradeLessThan70 = students.Any(s => s.Grade < 70);

        // 9. Select only student names in uppercase
        var namesUpper = students.Select(s => s.Name.ToUpper());

        // 10. Find the student with the highest grade
        var highestGradeStudent = students.OrderByDescending(s => s.Grade).FirstOrDefault();

        // Output results

        Console.WriteLine("1. Students older than 18:");
        foreach (var s in olderThan18) Console.WriteLine($"  {s.Name}, Age: {s.Age}");

        Console.WriteLine("\n2. Students with grade >= 90:");
        foreach (var s in gradeAbove90) Console.WriteLine($"  {s.Name}, Grade: {s.Grade}");

        Console.WriteLine("\n3. Students aged 18 to 20:");
        foreach (var s in ageBetween18And20) Console.WriteLine($"  {s.Name}, Age: {s.Age}");

        Console.WriteLine("\n4. Students whose names start with A or E:");
        foreach (var s in namesStartWithAE) Console.WriteLine($"  {s.Name}");

        Console.WriteLine("\n5. Top 3 students by grade:");
        foreach (var s in top3ByGrade) Console.WriteLine($"  {s.Name}, Grade: {s.Grade}");

        Console.WriteLine($"\n6. Count of students younger than 20: {countYoungerThan20}");

        Console.WriteLine($"\n7. Average grade: {avgGrade:F2}");

        Console.WriteLine($"\n8. Any student with grade less than 70? {anyGradeLessThan70}");

        Console.WriteLine("\n9. Student names in uppercase:");
        foreach (var name in namesUpper) Console.WriteLine($"  {name}");

        Console.WriteLine("\n10. Student with highest grade:");
        if (highestGradeStudent != null)
            Console.WriteLine($"  {highestGradeStudent.Name}, Grade: {highestGradeStudent.Grade}");
    }
}
