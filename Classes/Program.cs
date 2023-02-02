namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2009;

            Console.WriteLine($" My car is a {myCar.Make} {myCar.Model},year {myCar.Year}.");
        }
    }
}
