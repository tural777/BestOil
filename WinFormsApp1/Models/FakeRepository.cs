namespace WinFormsApp1.Models;

static class FakeRepository
{
    public static List<Gasoline> GetGasolines()
        => new()
        {
            new Gasoline("Regular 92", 1.00f),
            new Gasoline("Super 95", 1.60f),
            new Gasoline("Premium 98", 1.90f),
            new Gasoline("Diesel", 0.80f),
            new Gasoline("LPG", 0.65f),
        };



    public static List<ProductItem> GetMiniCafeProducts()
        => new()
        {
            new ProductItem(new Product("Hot Dog", 4f)),
            new ProductItem(new Product("Hamburger", 5.4f)),
            new ProductItem(new Product("French fries", 3.2f)),
            new ProductItem(new Product("Coca-Cola", 2f)),
        };
}
