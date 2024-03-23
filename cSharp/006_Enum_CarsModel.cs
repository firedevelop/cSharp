public class CarsModel
{
    public enum Cars
    {
        ford,
        seat,
        kia
    }

    public static void Print()
    {
        foreach (Cars cars in Enum.GetValues(typeof(Cars)))
        {
            Console.WriteLine(cars);
        }
        Cars car = Cars.seat;
        Console.WriteLine($"my car: {car}\n");
    }
}
