namespace WinFormsApp1.Models;

public class ProductItem
{
    public Product? Product { get; set; }
    public int Quantity { get; set; }
    public bool Selected { get; set; }


    public ProductItem(Product? product)
    {
        Product = product;
    }

    public float TotalPrice()
    {
        return Quantity * Product?.Price ?? 0;
    } 
}
