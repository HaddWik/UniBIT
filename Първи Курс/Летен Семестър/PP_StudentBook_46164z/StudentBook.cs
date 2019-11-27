using System.Collections.Generic;

public class StudentBook
{
    public StudentBook(List<Semester> semesters)
    {
        this.Semesters = semesters;

        CalculateAverageGrade();
        CalculateTotalSubjects(semesters);
    }

    public List<Semester> Semesters { get; set; }

    public double AverageGrade { get; set; }

    public double TotalSubjects { get; set; }

    private void CalculateAverageGrade()
    {
        double totalGrade = 0;

        foreach (var semester in Semesters)
            totalGrade += semester.AverageGrade;

        this.AverageGrade = totalGrade / Semesters.Count;
    }

    private void CalculateTotalSubjects(List<Semester> semesters)
    {
        double total = 0;

        foreach (var semester in semesters)
            total += semester.GradesCount;

        this.TotalSubjects = total;
    }
}