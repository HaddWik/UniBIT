using System;

class Program
{
    static void Main()
    {
        Console.Write("Person Name: ");
        var name = Console.ReadLine();

        Console.Write("Person Age: ");
        var age = int.Parse(Console.ReadLine());

        var person = new Person(name, age);

        Console.WriteLine("Person Orders (type END for result):");
        while (true)
        {
            var currentMeal = Console.ReadLine();

            if (currentMeal.Equals("END"))
                break;

            switch (currentMeal)
            {
                case "First Meal":
                    person.Price += 5;
                    break;
                case "Second Meal":
                    person.Price += 6;
                    break;
                case "Third Meal":
                    person.Price += 9;
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine($"{person.Name}'s order costs {person.GetTotalCost():f2} lv");

    }
}