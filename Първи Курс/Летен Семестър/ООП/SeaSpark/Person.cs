public class Person
{
    private string name;
    private string location;
    private double cost;

    public Person(string name, string location, int days)
    {
        this.Name = name;

        switch (location)
        {
            case "Burgas":
                {
                    this.Cost = days * 30;
                    if (days > 3)
                        this.Cost = (days * 30) * 0.94;
                    break;
                }
            case "Zlatni Pyasatsi":
                {
                    this.Cost = days * 32;
                    if (days > 3)
                        this.Cost = (days * 32) * 0.95;
                    break;
                }
            case "Sozopol":
                {
                    this.Cost = days * 31;
                    if (days > 3)
                        this.Cost = (days * 31) * 0.95;
                    break;
                }
            default:
                break;
        }
    }

    public string Name { get; set; }

    public double Cost { get; set; }
}
