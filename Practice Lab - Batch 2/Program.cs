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
        }
    }
}
