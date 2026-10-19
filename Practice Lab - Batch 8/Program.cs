namespace Practice_Lab___Batch_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Exercise 1\n");
            Console.Write("Give me a length in metres: ");
            string userInputMetres = Console.ReadLine();
            double inputMetres = double.Parse(userInputMetres);

            Console.WriteLine("Here is the original string input: " + userInputMetres);
            Console.WriteLine("Here is the converted version with a bonus suffix: " + inputMetres + "m");

            // Exercise 2
            Console.WriteLine("\n\nExercise 2\n");
            Console.Write("Give me a negative starting temperature in Celsius: ");
            string userInputCelsius = Console.ReadLine();
            Console.Write("Now give me a temperature rise in degrees: ");
            string userInputRise = Console.ReadLine();

            double celsius = double.Parse(userInputCelsius);
            double rise = double.Parse(userInputRise);
            double newTemp = celsius + rise;

            Console.WriteLine("\nYou gave me a starting temperature of " + celsius + "ºC");
            Console.WriteLine("You also gave me a temperature rise of " + rise + "ºC");
            Console.WriteLine("This would give a new temperature of " + newTemp + "ºC");

            // Exercise 3
            Console.WriteLine("\n\nExercise 3\n");
            Console.Write("Think of an imaginary panel. Give me its length in metres: ");
            string userInputLength = Console.ReadLine();
            Console.Write("Now give me its width in metres: ");
            string userInputWidth = Console.ReadLine();

            double length = double.Parse(userInputLength);
            double width = double.Parse(userInputWidth);
            double area = length * width;

            Console.WriteLine("\nThe length of the panel is " + length + "m");
            Console.WriteLine("The width of the panel is " + width + "m");
            Console.WriteLine("The area of the panel is " + area + "m²");
        }
    }
}
