using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var students = new List<Student>();

        Console.Write("Please enter students count: ");
        var studentsCount = int.Parse(Console.ReadLine());

        Console.WriteLine("On each line enter student details. (Format: firstName lastName, age)");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");

        for (int i = 0; i < studentsCount; i++)
        {
            var studentArgs = Console.ReadLine().Split();

            var firstName = studentArgs[0];
            var lastName = studentArgs[1];
            var age = int.Parse(studentArgs[2]);

            var student = new Student(firstName, lastName, age);

            students.Add(student);
        }

        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine("Regular Students:");

        foreach (var student in students)
        {
            if (student.StudentType.Equals("Regular"))
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }
    }
}