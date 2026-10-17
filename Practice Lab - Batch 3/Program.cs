namespace Practice_Lab___Batch_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            int lowestTemp = -15;
            int averageTemp = 0;
            int highestTemp = 13;

            Console.WriteLine("Temperature measurements in Celsius - Denmark, December 1999");
            Console.WriteLine();
            Console.WriteLine("Lowest measured temperature: " + lowestTemp);
            Console.WriteLine("Average temperature during December 1999: " + averageTemp);
            Console.WriteLine("Highest measured temperature: " + highestTemp);

            // Exercise 2
            int roundOnePoints = 7;
            int roundTwoPoints = 12;
            int totalPoints = roundOnePoints + roundTwoPoints;

            Console.WriteLine();
            Console.WriteLine("Scoreboard - Lone Wolf");
            Console.WriteLine();
            Console.WriteLine("Round 1: " + roundOnePoints + " points");
            Console.WriteLine("Round 2: " + roundTwoPoints + " points");
            Console.WriteLine();
            Console.WriteLine("Final score: " + totalPoints + " points!");

            // Exercise 3
            int totalSeats = 155;
            int bookedSeats = 58;
            int freeSeats = totalSeats - bookedSeats;

            Console.WriteLine();
            Console.WriteLine("Verde Avenue Venue has " + totalSeats + " seats in total.");
            Console.WriteLine("Currently, " + bookedSeats + " seats are booked for the Lord of the Rings Marathon.");
            Console.WriteLine("This leaves " + freeSeats + " available seats.");

            // Exercise 4
            int stickerPacks = 7;
            int stickersPerPack = 17;
            int totalStickers = stickerPacks * stickersPerPack;

            Console.WriteLine();
            Console.WriteLine("If I open up all of my sticker packs, I'll end up with " + totalStickers + " stickers.");
            Console.WriteLine("That would be " + totalStickers + " more stickers than I had before.");

            // Exercise 5
            Console.WriteLine();
            Console.Write("Dear Player. Please type your full name: ");
            string playerName = Console.ReadLine();
            int currentScore = 0;
            int pointsGained = 17;
            int pointsLost = 5;

            Console.WriteLine();
            Console.WriteLine("Let the games begin");
            Console.WriteLine("Your name: " + playerName);
            Console.WriteLine("Your score: " + currentScore);

            currentScore += pointsGained;

            Console.WriteLine();
            Console.WriteLine("Round 1 - Updated scoreboard");
            Console.WriteLine("Your name: " + playerName);
            Console.WriteLine("Current score: " + currentScore);

            currentScore -= pointsLost;

            Console.WriteLine();
            Console.WriteLine("End - post-game summary");
            Console.WriteLine("Your name: " + playerName);
            Console.WriteLine("Final score: " + currentScore);
        }
    }
}
