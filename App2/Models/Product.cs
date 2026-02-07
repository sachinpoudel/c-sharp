using System.ComponentModel;
using System.Data.Common;


enum ProductCategory
{
    Grocery,
    Electronic,
    Clothing
}
class Product
{
    public int Id {get;}
    public string Name {get;}
    public decimal Price {get;}

    public ProductCategory Category  {get;}


    Product(int id, int name, int price , ProductCategory category)
    {
        Id = id;
        Name = name;
        Price = price;
        Category = category;
    }
}