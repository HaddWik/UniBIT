using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Please enter product name: ");
        var productName = Console.ReadLine();

        Console.Write("Please enter weight unit: ");
        var unit = Console.ReadLine();

        Console.Write("Please enter product price per {0}: ", unit);
        var price = double.Parse(Console.ReadLine());

        Console.Write("Please enter product quantity in {0}'s: ", unit);
        var quantity = double.Parse(Console.ReadLine());

        var product = new Product(productName, unit, quantity, price);

        product.Print();
    }
}
