public class Person
{
    private string name;
    private int age;
    private string type;
    public double price = 0;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;

        if (this.Age <= 12)
            this.Type = "student";
        else if (this.Age >= 70)
            this.Type = "pensioner";
        else
            this.Type = "regular";
    }

    public string Name { get; set; }

    public int Age { get; set; }

    public string Type { get; set; }

    public double Price { get; set; }

    public double GetTotalCost()
    {
        if (Type == "student")
            Price *= 0.73;
        else if (Type == "pensioner")
            Price *= 0.80;

        return Price;
    }
}