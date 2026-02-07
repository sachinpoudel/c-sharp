using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
static void Main()
{
List<Product> products = new()
{
new Product(1, "Rice", 120, ProductCategory.Grocery),
new Product(2, "Laptop", 85000, ProductCategory.Electronics),
new Product(3, "T-Shirt", 800, ProductCategory.Clothing)
};


Invoice invoice = new Invoice();


while (true)
{
Console.WriteLine("\n1. View Products");
Console.WriteLine("2. Add to Invoice");
Console.WriteLine("3. Print Invoice");
Console.WriteLine("4. Exit");


int choice = int.Parse(Console.ReadLine());


if (choice == 1)
{
foreach (var p in products)
Console.WriteLine($"{p.Id}. {p.Name} - {p.Price}");
}
else if (choice == 2)
{
Console.Write("Product Id: ");
int id = int.Parse(Console.ReadLine());


Console.Write("Quantity: ");
int qty = int.Parse(Console.ReadLine());


var product = products.FirstOrDefault(p => p.Id == id);
if (product != null)
invoice.AddItem(product, qty);
}
else if (choice == 3)
{
invoice.Print();
}
else
{
break;
}
}
}
}