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

            // Exercise 4
            Console.WriteLine("\n\nWeek 7, Batch 1, Exercise 4\n");
            Console.Write("Give me a name for an event: ");
            var eventName = Console.ReadLine();
            Console.Write("Tell me how many rows of seats there are: ");
            var userInputRowsOfSeats = Console.ReadLine();
            Console.Write("Tell me how many seats there are per row: ");
            var userInputSeatsPerRow = Console.ReadLine();

            var rowsOfSeats = int.Parse(userInputRowsOfSeats);
            var seatsPerRow = int.Parse(userInputSeatsPerRow);
            var seatingCapacity = rowsOfSeats * seatsPerRow;

            Console.WriteLine("\n~~ Event summary ~~");
            Console.WriteLine("Name of event: " + eventName);
            Console.WriteLine("Rows of seats: " + userInputRowsOfSeats);
            Console.WriteLine("Seats per row: " + userInputSeatsPerRow);

            Console.WriteLine("\nSeating capacity: " + rowsOfSeats + " * " + seatsPerRow + " = " + seatingCapacity);
            Console.WriteLine("Runtime type of your rowsPerSeat input: " + userInputRowsOfSeats.GetType());
            Console.WriteLine("Runtime type of the converted input: " + rowsOfSeats.GetType());
            Console.WriteLine("Runtime type of the capacity: " + seatingCapacity.GetType());

            // Exercise 5
            Console.WriteLine("\n\nWeek 7, Batch 1, Exercise 5\n");
            Console.Write("Give me a name for a station: ");
            var stationName = Console.ReadLine();
            Console.Write("Give me its current visitor count: ");
            var userInputVisitorCount = Console.ReadLine();
            Console.Write("Give me a temperature in Celsius: ");
            var userInputTemperature = Console.ReadLine();

            var visitorCount = int.Parse(userInputVisitorCount);
            var temperature = double.Parse(userInputTemperature);
            var zoneMarker = 'O';
            var isStationOpen = false;

            Console.WriteLine("\n~~ Station report ~~\n");
            Console.WriteLine("Name: " + stationName);
            Console.WriteLine("Visitor count: " + visitorCount + " - runtime type: " + visitorCount.GetType());
            Console.WriteLine("Temperature: " + temperature + "°C");
            Console.WriteLine("Zone: " + zoneMarker);
            Console.WriteLine("Open status: " + isStationOpen);

            var arrivingGroup = 85;
            visitorCount += arrivingGroup;
            zoneMarker = 'H';
            isStationOpen = true;

            Console.WriteLine("\n~~ Updated station report ~~\n");
            Console.WriteLine("Name: " + stationName);
            Console.WriteLine("Temperature: " + temperature + "°C");
            Console.WriteLine("Size of newly arrived group: " + arrivingGroup);
            Console.WriteLine("Updated visitor count: " + visitorCount + " - runtime type: " + visitorCount.GetType());
            Console.WriteLine("Updated zone: " + zoneMarker);
            Console.WriteLine("Open status: " + isStationOpen);
        }
    }
}
