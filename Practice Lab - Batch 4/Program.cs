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

            // Exercise 5
            Console.Write("\nYou have a box of pens, please type how many were in the box initially: ");
            string userInputPens = Console.ReadLine();

            Console.Write("Please type how many pens you handed out: ");
            string userInputHandedOut = Console.ReadLine();

            int pensBox = int.Parse(userInputPens);
            int pensHandedOut = int.Parse(userInputHandedOut);
            int remainingPens = pensBox - pensHandedOut;

            Console.WriteLine("So, the box initially had " + pensBox + " pens in the box before you opened it...");
            Console.WriteLine("...and you gave " + pensHandedOut + " pens away to strangers...");
            Console.WriteLine("That means, you only have " + remainingPens + " left for yourself.");

            // Exercise 6
            Console.Write("\nThink of a grid. Now, tell me how many rows it has: ");
            string userInputRows = Console.ReadLine();
            Console.Write("Now tell me how many columns it has: ");
            string userInputColumns = Console.ReadLine();

            int rows = int.Parse(userInputRows);
            int columns = int.Parse(userInputColumns);
            int cells = rows * columns;

            Console.WriteLine("\nYou thought of a grid with " + rows + " rows and " + columns + " columns...");
            Console.WriteLine("That gives us a grand total of " + cells + " cells!");
        }
    }
}
