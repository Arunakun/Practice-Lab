namespace Practice_Lab___Batch_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Exercise 1\n");
            {
                string message = "Corviknight is a Flying/Steel Pokémon introduced in Generation 8.";
                Console.WriteLine(message);
                Console.WriteLine(message);
            }
            Console.WriteLine("Yes I wrote it twice, what are you gonna do about it? It's a good Pokémon, I like it!");

            // Exercise 2
            string imaginaryPlaceName = "Marrowbean";
            Console.WriteLine("\n\nExercise 2\n");
            Console.WriteLine("Welcome to " + imaginaryPlaceName + " - a place of wonders!");
            {
                string activityName = "gaming";
                Console.WriteLine("The main activity to do around here is " + activityName);
            }
            Console.WriteLine("We hope you like it here in " + imaginaryPlaceName + "!");
        }
    }
}
