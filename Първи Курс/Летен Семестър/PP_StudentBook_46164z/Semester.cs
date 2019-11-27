public class Semester
{
    public Semester(int semesterNumber, int totalHours, double grade)
    {
        this.SemesterNumber = semesterNumber;
        this.TotalHours = totalHours;
        this.GradesCount = 1;
        this.TotalGrade = grade;
        this.AverageGrade = grade;
    }

    public int SemesterNumber { get; set; }

    public int TotalHours { get; set; }

    public double TotalGrade { get; set; }

    public double GradesCount { get; set; }

    public double AverageGrade { get; set; }

    public void AddSubject(int totalHours, double grade)
    {
        this.TotalHours += totalHours;
        this.GradesCount += 1;
        this.TotalGrade += grade;
        this.AverageGrade = this.TotalGrade / this.GradesCount;
    }
}