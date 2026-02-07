class InvoiceItem
{
    public Product Product {get;} // here we use the Product class to get details of the product
    public int  Quantity {get;} 

    public InvoiceItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public decimal  Total => Product.Price * Quantity; // this is a lamba property to calculate total price 
}