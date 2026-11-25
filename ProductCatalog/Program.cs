using System;
using System.Collections;
public class Product
{
   

    public string Name { get; set; }
    public decimal Price { get; set; }

    public int Stock { get; set; }

    public Product(string name, decimal price, int stock)
    {
        Name = name;
        Price = price;
        this.Stock = stock;
    }
    public void ShowDetails()
    {
        Console.WriteLine(
            $"Product: {Name}, Price: {Price}, Stock: {Stock}");
    }

}
public class Pogram
{
    public static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", 65000m, 10);
        Product product2 = new Product("Mouse", 500m, 30);


        product1.ShowDetails();
        product2.ShowDetails();
    }
}