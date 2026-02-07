using System.Diagnostics;

class Invoice
{
    public List<InvoiceItem> _items = new();

    public void AddItem(Product product, int qty)
    {
        _items.Add(new InvoiceItem(product, qty));
    }

    public decimal SubTotal => _items.Sum(i => i.Total);

    public decimal Tax => SubTotal * 0.13m;

    public decimal Discount => SubTotal > 1000 ? SubTotal * 0.05m : 0;

    public decimal GrandTotal => SubTotal + Tax - Discount;


public void Print()
    {
        Console.WriteLine("--------------INVOICES--------------");

foreach(var item in _items)
        {
            Console.WriteLine($"{item.Product.Name} * {item.Quantity} = {item.Total}");
        }
Console.WriteLine($"Tax:{Tax}");
Console.WriteLine($"Discount:{Discount}");
Console.WriteLine($"GrandTotal:{GrandTotal}");
    }


}