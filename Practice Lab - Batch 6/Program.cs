using System.Diagnostics;

namespace Practice_Lab___Batch_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            bool isDoorOpen = true;
            bool isLampOn = false;

            Console.WriteLine("Exercise 1\n");
            Console.WriteLine("=== Lie Detector 9001 - Session #13 ACTIVE ===");
            Console.WriteLine("The door is open. (" + isDoorOpen + ")");
            Console.WriteLine("The lamp is on. (" + isLampOn + ")");

            // Exercise 2
            bool isGalleryOpen = false;

            Console.WriteLine("\n\nExercise 2\n");
            Console.WriteLine("=== Art Gallery Opening Hours ===");
            Console.WriteLine("\nOpening Hours: 7:00 AM - 5:00 PM");
            Console.WriteLine("\nCurrent time: 6:00 AM");
            Console.WriteLine("Is the gallery open? " + isGalleryOpen);

            isGalleryOpen = true;
            Console.WriteLine("\nCurrent time: 8:00 AM");
            Console.WriteLine("Is the gallery open? " + isGalleryOpen);

            isGalleryOpen = false;
            Console.WriteLine("\nCurrent time: 8:00 PM");
            Console.WriteLine("Is the gallery open? " + isGalleryOpen);

            // Exercise 3
            char section = 'Q';
            char door = '7';
            char punctuationMark = '^';

            Console.WriteLine("\n\nExercise 3\n");
            Console.WriteLine("Imagine walking down a corridor in this section: " + section);
            Console.WriteLine("You walk past doors until you find the number you're looking for: " + door);
            Console.WriteLine("You check the room.. it's clear. You mark the door with this: " + punctuationMark);

            // Exercise 4
            char newSection = 'N';
            char station = '3';

            Console.WriteLine("\n\nExercise 4\n");
            Console.WriteLine("We have encountered enemy forces in section " + newSection + ". Stop.");
            Console.WriteLine("Need immediate backup at station " + station + ". Stop.");

            newSection = 'A';
            Console.WriteLine("\nEnemy forces have cleared out at station " + station + ". Stop.");
            Console.WriteLine("Return to section " + newSection + " and wait for new orders. Stop.");

            // Exercise 5
            string trackingIdentifier = "0C3301";
            int parcelCount = 73;
            double parcelMass = 67.52;
            bool areParcelsInspected = false;
            char dispatchZone = 'Z';

            Console.WriteLine("\n\nExercise 5\n");
            Console.WriteLine("We are currently tracking a batch of parcels, with the following identifier: " + trackingIdentifier);
            Console.WriteLine("There are a total of " + parcelCount + " parcels in this batch.");
            Console.WriteLine("The total weight of said parcels is " + parcelMass + "kg.");
            Console.WriteLine("The current status of whether they have been inspected or not: " + areParcelsInspected);
            Console.WriteLine("The parcels, once cleared, are expected to be dispatched to zone " + dispatchZone + ".");
        }
    }
}
