namespace WinFormsApp1.Models;

public class Gasoline
{
    public string? Name { get; set; }
    public float Price { get; set; }

    public Gasoline(string? name, float price)
    {
        Name = name;
        Price = price;
    }
}
