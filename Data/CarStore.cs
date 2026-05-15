namespace Car.API;

public static class CarStore
{
    private static readonly List<Car> Cars =
    [
        new Car { Id = 1, Make = "Toyota", Model = "Corolla", Year = 2022, Vin = "1HGBH41JXMN109186", Price = 22500m, Status = "Available" },
        new Car { Id = 2, Make = "BMW",    Model = "3 Series", Year = 2023, Vin = "WBA5R7C50KAK12345", Price = 47900m, Status = "Available" },
        new Car { Id = 3, Make = "Ford",   Model = "Mustang",  Year = 2021, Vin = "1FA6P8TH5M5100234", Price = 38750m, Status = "Sold"      },
        new Car { Id = 4, Make = "Audi",   Model = "A4",       Year = 2024, Vin = "WAUFFAFL5EN012678", Price = 54200m, Status = "Reserved"  },
        new Car { Id = 5, Make = "Honda",  Model = "Civic",    Year = 2023, Vin = "2HGFC2F59PH501122", Price = 26400m, Status = "Available" },
    ];

    public static IEnumerable<Car> GetAll() => Cars;

    public static Car? GetById(int id) => Cars.FirstOrDefault(c => c.Id == id);

    public static Car Add(Car car)
    {
        car.Id = Random.Shared.Next(1_000, int.MaxValue);
        Cars.Add(car);
        return car;
    }

    public static bool Update(int id, Car car)
    {
        var existing = Cars.FirstOrDefault(c => c.Id == id);
        if (existing is null) return false;

        existing.Make   = car.Make;
        existing.Model  = car.Model;
        existing.Year   = car.Year;
        existing.Vin    = car.Vin;
        existing.Price  = car.Price;
        existing.Status = car.Status;
        return true;
    }

    public static bool Delete(int id)
    {
        var existing = Cars.FirstOrDefault(c => c.Id == id);
        if (existing is null) return false;

        Cars.Remove(existing);
        return true;
    }
}
