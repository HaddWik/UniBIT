using System;
using System.Text;

public class Product
{
    private string name;
    private string unit;
    private double quantity;
    private double price;
    private double retailPrice;
    private double discountedPrice;

    public Product(string name, string unit, double quantity, double price)
    {
        this.Name = name;
        this.Unit = unit;
        this.Quantity = quantity;
        this.Price = price * quantity;
    }

    private string Name { get; set; }

    private string Unit { get; set; }

    private double Quantity { get; set; }

    private double Price { get; set; }

    private void CalculateRetailPrice()
    {
        var tempPrice = Price * 1.2;
        this.retailPrice = tempPrice * 1.2;
    }

    private void CalculateDiscountedPrice()
    {
        this.discountedPrice = Price * 0.85;
    }

    private String GetPricePerUnit(int type)
    {
        var tempPrice = this.Price / this.Quantity;

        if (type == 1)
            tempPrice = this.discountedPrice / this.Quantity;
        else if (type == 2)
            tempPrice = this.retailPrice / this.Quantity;

        return tempPrice.ToString();
    }
    public void Print()
    {
        CalculateRetailPrice();
        CalculateDiscountedPrice();

        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine("Product: {0}", this.name);
        Console.WriteLine($"Price: {this.Price:f2} EUR per {this.Quantity} {this.Unit}'s ({this.GetPricePerUnit(0):f2} EUR per {this.Unit})");
        Console.WriteLine($"Discounted Price: {this.discountedPrice:f2} EUR per {this.Quantity} {this.Unit}'s ({this.GetPricePerUnit(1):f2} EUR per {this.Unit})");
        Console.WriteLine($"Retail Price: {this.retailPrice:f2} EUR per {this.Quantity} {this.Unit}'s ({this.GetPricePerUnit(2):f2} EUR per {this.Unit})");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
    }
}