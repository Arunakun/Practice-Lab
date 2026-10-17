namespace Practice_Lab___Batch_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            string city = "Viborg";
            string country = "Norway";

            Console.WriteLine(city + " is in Denmark, not in " + country);

            // Exercise 2
            Console.WriteLine();
            Console.Write("Please write a nickname for you: ");
            string nickname = Console.ReadLine();

            Console.WriteLine("Hello, " + nickname);

            // Exercise 3
            Console.WriteLine();
            Console.Write("What is one of your favorite games? Please tell me: ");
            string game = Console.ReadLine();
            Console.Write("Really? That's an interesting game! Please tell me the platform, you play it on: ");
            string platform = Console.ReadLine();

            Console.WriteLine("Playing " + game + " on " + platform + " does sound like a great experience!");

            // Exercise 4
            Console.WriteLine();
            Console.Write("If you were to make an esports team, tell me what you would call it: ");
            string team = Console.ReadLine();

            Console.WriteLine(team + " was founded in 2026.");
            Console.WriteLine(team + " currently consists of 1 member: " + nickname);
        }
    }
}
