namespace Practice_Lab___Week_7___Batch_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            var visitorName = "Steve Unemployed";
            var passNumber = 251;
            var visitDuration = 3.14;

            Console.WriteLine("Week 7, Batch 1, Exercise 1\n");
            Console.WriteLine("Todays VIP: " + visitorName + " - runtime type is " + visitorName.GetType());
            Console.WriteLine("Starting pass number: #" + passNumber + " - runtime type is " + passNumber.GetType());
            Console.WriteLine("Duration of visit: " + visitDuration + " hours - runtime type is " + visitDuration.GetType());

            // Exercise 2
            var isSignalActive = true;
            var signalMarker = 'Q';

            Console.WriteLine("\n\nWeek 7, Batch 1, Exercise 2\n");
            Console.WriteLine("State of signal: " + isSignalActive + " - runtime type is " + isSignalActive.GetType());
            Console.WriteLine("Signal marker: " + signalMarker + " - runtime type is " + signalMarker.GetType());

            isSignalActive = false;
            signalMarker = 'I';

            Console.WriteLine("\nUpdate to signal and marker");
            Console.WriteLine("State of signal: " + isSignalActive + " - runtime type is " + isSignalActive.GetType());
            Console.WriteLine("Signal marker: " + signalMarker + " - runtime type is " + signalMarker.GetType());

            // Exercise 3
            var trayCount = 16;
            var itemsPerTray = 32;
            var totalItemCount = trayCount * itemsPerTray;

            var trayWidth = 2.13;
            var trayLength = 3.07;
            var trayArea = trayWidth * trayLength;

            Console.WriteLine("\n\nWeek 7, Batch 1, Exercise 3\n");
            Console.WriteLine("There are " + trayCount + " trays");
            Console.WriteLine("Each tray has " + itemsPerTray + " items");
            Console.WriteLine("There are " + totalItemCount + " items in total - runtime type is " + totalItemCount.GetType());

            Console.WriteLine("\nEach tray is " + trayWidth + " metres wide");
            Console.WriteLine("Each tray is " + trayLength + " metres long");
            Console.WriteLine("Each tray has an area of " + trayArea + "m² - runtime typs is " + trayArea.GetType());
        }
    }
}
