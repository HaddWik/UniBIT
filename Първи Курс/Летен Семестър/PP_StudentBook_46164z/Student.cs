using System;
using System.Text;

public class Student
{
    public Student(string name, StudentBook studentBook)
    {
        this.Name = name;
        this.StudentBook = studentBook;
    }

    public string Name { get; set; }

    public StudentBook StudentBook { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Студент: {this.Name}");
        sb.AppendLine($"Общо изучавани дисциплини: {this.StudentBook.TotalSubjects}");
        sb.AppendLine($"Среден успех по семестри и общ хорариум:");

        foreach (var semester in StudentBook.Semesters)
            sb.AppendLine($"    {semester.SemesterNumber}. Семестър {semester.SemesterNumber}, {semester.TotalHours}: {semester.AverageGrade:f2}");

        sb.AppendLine($"Общ среден успех: {Math.Round(this.StudentBook.AverageGrade, 1):f2}");

        return sb.ToString().TrimEnd();
    }
}