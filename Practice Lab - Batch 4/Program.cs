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
            Console.Write("\nHow many Pokémon cards do you own? Please type it out: ");

            string userInputCards = Console.ReadLine();
            int userCards = int.Parse(userInputCards);
            int target = 500;
            int cardsNeeded = target - userCards;

            Console.WriteLine("\nSo, with a target of " + target + " cards to reach your personal goal...");
            Console.WriteLine("...and with your current collection holding " + userCards + " cards...");
            Console.WriteLine("...you only need " + cardsNeeded + " Pokémon cards to reach it.");

            // Exercise 4
            Console.Write("\nPlease write how many books are on the top shelf: ");
            string userInputTopShelf = Console.ReadLine();
            
            Console.Write("Please write how many books are on the bottom shelf: ");
            string userInputBottomShelf = Console.ReadLine();

            int topShelfBooks = int.Parse(userInputTopShelf);
            int bottomShelfBooks = int.Parse(userInputBottomShelf);
            int totalBooks = topShelfBooks + bottomShelfBooks;

            Console.WriteLine("\nWith " + userInputTopShelf + " books on the top shelf...");
            Console.WriteLine("...and " + userInputBottomShelf + " books on the bottom shelf...");
            Console.WriteLine("...you have " + totalBooks + " books in total.");
        }
    }
}
