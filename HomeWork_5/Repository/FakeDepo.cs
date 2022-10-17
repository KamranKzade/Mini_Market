using HomeWork_5.Models;


namespace HomeWork_5.Repository;

public class FakeDepo
{
    public static List<Product> GetStudents()
    {
        return new()
        {
            new("cola.png", "Coca-Cola", 1, 100, false),
            new("pepsi.png", "Pepsi", 1, 100,false),
            new("fanta.png", "Fanta", 1, 100, false),
            new("sprite.png", "Sprite", 1, 100, false),
            new("iceTea.png", "Ice Tea", 1, 100, false),
            new("hell.png", "Hell", 1.2M, 100, false),
            new("bizon.png", "Bizon", 0.8M, 100, false),
            new("mars.png", "Mars", 1.3M, 100, false),
            new("snickers.png", "Snickers", 1.7M, 100, false),
            new("bounty.png", "Bounty", 1.5M, 100, false),
            new("albeni.png", "Albeni", 1.1M, 100, false),
            new("tutku.png", "Tutku", 0.6M, 100, false)
        };
    }
}