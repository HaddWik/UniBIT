using System.Text;

public class Student
{
    private string firstName;
    private string lastName;
    private int age;
    private string studentType;

    public Student(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        CheckAge(age);
    }

    private string FirstName { get; set; }

    private string LastName { get; set; }

    private int Age { get; set; }

    public string StudentType { get; set; }

    private void CheckAge(int age)
    {
        if (age < 25)
            this.StudentType = "Regular";
        else
            this.StudentType = "Distant";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("First Name: " + this.FirstName);
        sb.AppendLine("Last Name: " + this.LastName);
        sb.AppendLine("Age: " + this.Age);

        return sb.ToString().Trim();
    }
}