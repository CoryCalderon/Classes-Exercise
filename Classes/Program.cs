namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Chevy";
            myCar.Model = "Malibu";
            myCar.Year = 2013;

            Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}.");
        }
    }
}
