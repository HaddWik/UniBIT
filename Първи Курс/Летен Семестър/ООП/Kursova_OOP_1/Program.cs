using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var facNumber = Console.ReadLine();
        var firstName = Console.ReadLine();
        var lastName = Console.ReadLine();
        var discipline = Console.ReadLine();
        
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine("On next line input grades (divided by space) for student: {0} {1} with faculty number {2}:", firstName, lastName, facNumber);
        var grades = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");

        var student = new Student(facNumber, firstName, lastName, discipline, grades);

        foreach (var grade in grades)
        {
            student.CheckGrade(grade);
        }
    }
}