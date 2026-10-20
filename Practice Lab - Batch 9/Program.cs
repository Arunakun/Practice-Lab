namespace Practice_Lab___Batch_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Exercise 1\n");

            Console.Write("You're a shipment general, there's a shipment coming in. Name it: ");
            string shipmentName = Console.ReadLine();
            Console.Write("Tell me how many full boxes there are: ");
            string userInputBoxes = Console.ReadLine();
            Console.Write("Now tell me how many items are in each box: ");
            string userInputItemsPerBox = Console.ReadLine();

            int fullBoxesTotal = int.Parse(userInputBoxes);
            int itemsPerBox = int.Parse(userInputItemsPerBox);
            int itemsTotal = fullBoxesTotal * itemsPerBox;

            Console.WriteLine("\nCheckpoint summary #1:");
            Console.WriteLine("Shipment name: " + shipmentName);
            Console.WriteLine("Box count: " + fullBoxesTotal);
            Console.WriteLine("Items per box: " + itemsPerBox);
            Console.WriteLine("Total item count: " + itemsTotal);

            Console.Write("\nOup, there are more full boxes of the same side being added, tell me how many: ");
            string userInputBoxAddition = Console.ReadLine();
            int addedBoxCount = int.Parse(userInputBoxAddition);
            
            fullBoxesTotal += addedBoxCount;
            itemsTotal = fullBoxesTotal * itemsPerBox;

            Console.WriteLine("\nCheckpoint summary #2:");
            Console.WriteLine("Added box count: " + addedBoxCount);
            Console.WriteLine("Updated box count: " + fullBoxesTotal);
            Console.WriteLine("Updated item total: " + itemsTotal);

            Console.Write("\nOh shit, there are damaged items... Tell me how many items are damaged: ");
            string userInputDamagedItems = Console.ReadLine();
            int damagedItems = int.Parse(userInputDamagedItems);
            int usableItems = itemsTotal - damagedItems;

            Console.WriteLine("\n\nCheckpoint summary #3 (final): ");
            Console.WriteLine("Shipment name: " + shipmentName);
            Console.WriteLine("Updated box count: " + fullBoxesTotal);
            Console.WriteLine("Total item count: " + itemsTotal);
            Console.WriteLine("Damaged item count: " + damagedItems);
            Console.WriteLine("Usable item count: " + usableItems);


            // Exercise 2
            Console.WriteLine("\n\n\nExercise 2\n");
            Console.Write("You were recently on a roadtrip. Tell me what you'd call this journey: ");
            string journeyName = Console.ReadLine();
            
            Console.Write("I remember you telling me it was over 2 parts. Tell me how far you traveled on part 1 in kilometres: ");
            string userInputDistanceFirstPart = Console.ReadLine();
            Console.Write("Tell me how long it took you in hours: ");
            string userInputDurationFirstPart = Console.ReadLine();
            Console.Write("Now tell me how far you traveled on the second part of the journey in kilometres: ");
            string userInputDistanceSecondPart = Console.ReadLine();
            Console.Write("Please tell me how long that took you in hours: ");
            string userInputDurationSecondPart = Console.ReadLine();

            double distanceFirstPart = double.Parse(userInputDistanceFirstPart);
            double distanceSecondPart = double.Parse(userInputDistanceSecondPart);
            double durationFirstPart = double.Parse(userInputDurationFirstPart);
            double durationSecondPart = double.Parse(userInputDurationSecondPart);

            double totalDistance = distanceFirstPart + distanceSecondPart;
            double totalDuration = durationFirstPart + durationSecondPart;
            double averageSpeed = totalDistance / totalDuration;

            Console.WriteLine("\nJourney summary:");
            Console.WriteLine("Name of journey: " + journeyName);
            Console.WriteLine("\nPart 1 distance: " + distanceFirstPart + "km");
            Console.WriteLine("Part 2 distance: " + distanceSecondPart + "km");
            Console.WriteLine("\nPart 1 duration: " + durationFirstPart + " hours");
            Console.WriteLine("Part 2 duration: " + durationSecondPart + " hours");
            Console.WriteLine("\nTotal distance: " + totalDistance + "km");
            Console.WriteLine("Total duration: " + totalDuration + " hours");
            Console.WriteLine("Average speed: " + averageSpeed + "km/h");


            // Exercise 3
            string reportHeading = "Reading Room Report (RRR)";

            Console.WriteLine("\n\n\nExercise 3\n");
            Console.WriteLine(reportHeading);

            {
                Console.Write("Give me a name for this reading room: ");
                string readingRoomName = Console.ReadLine();

                Console.Write("Tell me how many reserved seats there are: ");
                string userInputReservedSeats = Console.ReadLine();
                int reservedSeats = int.Parse(userInputReservedSeats);

                Console.Write("Tell me how many unreserved seats there are: ");
                string userInputUnreservedSeats = Console.ReadLine();
                int unreservedSeats = int.Parse(userInputUnreservedSeats);

                Console.Write("Tell me the room's length in metres: ");
                string userInputLength = Console.ReadLine();
                double length = double.Parse(userInputLength);

                Console.Write("Tell me the room's width in metres: ");
                string userInputWidth = Console.ReadLine();
                double width = double.Parse(userInputWidth);

                int seatingCapacity = reservedSeats + unreservedSeats;
                double area = length * width;
                char sectionMarker = 'G';
                bool isRoomOpen = false;

                Console.WriteLine("\n~~ Initial report of reading room ~~");
                Console.WriteLine("Room name: \"" + readingRoomName + "\"");
                Console.WriteLine("Reserved seats: " + reservedSeats);
                Console.WriteLine("Unreserved seats: " + unreservedSeats);
                Console.WriteLine("Max capacity: " + seatingCapacity);
                Console.WriteLine("Length: " + length + "m");
                Console.WriteLine("Width: " + width + "m");
                Console.WriteLine("Floor area: " + area + "m²");
                Console.WriteLine("Section: " + sectionMarker);
                Console.WriteLine("Room open: " + isRoomOpen);

                sectionMarker = 'J';
                isRoomOpen = true;

                Console.WriteLine("\n~~ 2nd report of reading room ~~");
                Console.WriteLine("Room name: \"" + readingRoomName + "\"");
                Console.WriteLine("Max capacity: " + seatingCapacity);
                Console.WriteLine("Floor area: " + area + "m²");
                Console.WriteLine("Section: " + sectionMarker);
                Console.WriteLine("Room open: " + isRoomOpen);
            }

            Console.WriteLine(reportHeading);
        }
    }
}
