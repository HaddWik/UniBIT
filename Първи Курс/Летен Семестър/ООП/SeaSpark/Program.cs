using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Person Name: ");
        var name = Console.ReadLine();

        Console.Write("Vacantion Location: ");
        var location = Console.ReadLine();

        Console.Write("Days for reservation: ");
        var days = int.Parse(Console.ReadLine());

        var person = new Person(name, location, days);

        Console.WriteLine($"{person.Name}'s order costs: {person.Cost:f2} lv");
    }
}
