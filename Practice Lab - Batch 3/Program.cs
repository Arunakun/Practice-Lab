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
        }
    }
}
