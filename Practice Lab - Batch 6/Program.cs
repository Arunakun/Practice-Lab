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

            Console.WriteLine("Exercise 1\n=== Lie Detector 9001 - Session #13 ACTIVE ===");
            Console.WriteLine("The door is open. (" + isDoorOpen + ")");
            Console.WriteLine("The lamp is on. (" + isLampOn + ")");

            // Exercise 2
            bool isGalleryOpen = false;

            Console.WriteLine("\n\nExercise 2\n=== Art Gallery Opening Hours ===");
            Console.WriteLine("\nOpening Hours: 7:00 AM - 5:00 PM");
            Console.WriteLine("\nCurrent time: 6:00 AM");
            Console.WriteLine("Is the gallery open? " + isGalleryOpen);

            isGalleryOpen = true;
            Console.WriteLine("\nCurrent time: 8:00 AM");
            Console.WriteLine("Is the gallery open? " + isGalleryOpen);

            isGalleryOpen = false;
            Console.WriteLine("\nCurrent time: 8:00 PM");
            Console.WriteLine("Is the gallery open? " + isGalleryOpen);
        }
    }
}
