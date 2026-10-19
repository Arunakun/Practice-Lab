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

            // Exercise 3
            int score = 17;
            int scoreGain = 13;
            Console.WriteLine("\n\nExercise 3\n");
            Console.WriteLine("Starting score: " + score + " points");

            {
                double liquidQuantity = 6.34;
                double liquidQuantityGain = 2.18;
                Console.WriteLine("Liquid amount: " + liquidQuantity + "L");

                liquidQuantity += liquidQuantityGain;
                Console.WriteLine("Adding " + liquidQuantityGain + "L to it gives us a total of " + liquidQuantity + "L.");
            }

            score += scoreGain;
            Console.WriteLine("Adding " + scoreGain + " points to the score gives us " + score + " points in total.");
        }
    }
}
