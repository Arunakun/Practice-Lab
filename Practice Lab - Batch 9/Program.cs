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
        }
    }
}
