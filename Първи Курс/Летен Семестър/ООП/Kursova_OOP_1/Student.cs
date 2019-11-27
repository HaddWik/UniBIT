using System;

public class Student
{
    private string facNumber;
    private string firstName;
    private string lastName;
    private string discipline;
    private int[] grades;

    public Student(string facNumber, string firstName, string lastName, string discipline, int[] grades)
    {
        this.FacNumber = facNumber;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Discipline = discipline;
        this.Grades = grades;
    }

    public int[] Grades { get; set; }

    private string FacNumber { get; set; }

    private string FirstName { get; set; }

    private string LastName { get; set; }

    private string Discipline { get; set; }

    public void CheckGrade(int grade)
    {
        if (grade < 2 || grade > 6)
            Console.WriteLine("{0} is not a valid grade!", grade);
        else
            Console.WriteLine("{0} is a valid grade!", grade);
    }
}
