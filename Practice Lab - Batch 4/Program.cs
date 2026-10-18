namespace Practice_Lab___Batch_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.Write("Please type how many pages you've read tonight: ");
            string pagesInput = Console.ReadLine();
            int pages = int.Parse(pagesInput);
            int finalPageCount = pages + 1;

            Console.WriteLine("\nYou've read a grand total of " + pages + " pages today..");
            Console.WriteLine("If you'd read another page, you would've ended on " + finalPageCount + " pages instead.");

            // Exercise 2
            Console.Write("\nPlease write the lowest temperature in Celsius you remember experiencing: ");
            string celsiusInput = Console.ReadLine();
            int coldestTemp = int.Parse(celsiusInput);
            int tempRise = 17;
            int newTemp = coldestTemp + tempRise;

            Console.WriteLine("\nColdest temperature experienced: " + coldestTemp + " degrees Celcius.");
            Console.WriteLine("If the temperature were to rise with " + tempRise + " degrees...");
            Console.WriteLine("...the new temperature would be " + newTemp + " degrees Celcius.");

            // Exercise 3
            Console.WriteLine("\nHow many Pokémon cards do you own? Please type it out: ");

            string userInputCards = Console.ReadLine();
            int userCards = int.Parse(userInputCards);
            int target = 500;
            int cardsNeeded = target - userCards;

            Console.WriteLine("\nSo, with a target of " + target + " cards to reach your personal goal...");
            Console.WriteLine("...and with your current collection holding " + userCards + " cards...");
            Console.WriteLine("...you only need " + cardsNeeded + " Pokémon cards to reach it.");
        }
    }
}
