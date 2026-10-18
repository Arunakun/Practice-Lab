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
        }
    }
}
