namespace Practice_Lab___Batch_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            double coldTemp = -13.73;
            double freezingTemp = 0.00;
            double warmTemp = 19.86;

            Console.WriteLine("A below-zero temperature could be " + coldTemp + "°C.");
            Console.WriteLine("Water freezes at exactly (or around) " + freezingTemp + "°C.");
            Console.WriteLine("Water does not freeze at " + warmTemp + "°C.");

            // Exercise 2
            double shorterDistance = 4.82;
            double longerDistance = 15.39;
            double totalDistance = shorterDistance + longerDistance;

            Console.WriteLine("\nWe have two stretches on a map.");
            Console.WriteLine("The length of the first one is " + shorterDistance + "km, length of the other is " + longerDistance + "km.");
            Console.WriteLine("Added together, the total length is " + totalDistance + "km.");
        }
    }
}
