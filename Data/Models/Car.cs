namespace Car.API;

public class Car
{
    public int Id { get; set; }
    public string Make { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Vin { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Status { get; set; } = "Available"; // Available | Sold | Reserved
}
