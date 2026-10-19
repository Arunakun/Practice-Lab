namespace Practice_Lab___Batch_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            double coldTemp = -13.73;
            double freezingTemp = 0.00;
            double warmTemp = 19.86;

            Console.WriteLine("A below-zero temperature could be " + coldTemp + "°C.");
            Console.WriteLine("Water freezes at exactly (or around) " + freezingTemp + "°C.");
            Console.WriteLine("Water does not freeze at " + warmTemp + "°C.");

            // Exercise 2
            double shorterDistance = 4.82;
            double longerDistance = 15.39;
            double totalDistance = shorterDistance + longerDistance;

            Console.WriteLine("\nWe have two stretches on a map.");
            Console.WriteLine("The length of the first one is " + shorterDistance + "km, length of the other is " + longerDistance + "km.");
            Console.WriteLine("Added together, the total length is " + totalDistance + "km.");

            // Exercise 3
            double fullWaterContainer = 15.67;
            double waterUsed = 5.53;
            double waterLeft = fullWaterContainer - waterUsed;

            Console.WriteLine("\nThis container can hold " + fullWaterContainer + "L of water when full.");
            Console.WriteLine("We have used " + waterUsed + "L so far, which leaves us with " + waterLeft + "L of water.");

            // Exercise 4
            double rectangleLength = 3.25;
            double rectangleWidth = 5.09;
            double rectangleArea = rectangleLength * rectangleWidth;

            Console.WriteLine("\nA rectangle is in front of you.");
            Console.WriteLine("It is " + rectangleLength + "m long and " + rectangleWidth + "m wide.");
            Console.WriteLine("With those two measurements, the area is then " + rectangleArea + "m².");

            // Exercise 5
            double kilometresTraveled = 449.32;
            double hoursTraveled = 5.69;
            double kilometresPerHour = kilometresTraveled / hoursTraveled;

            Console.WriteLine("\nYou've traveled far today, my friend. " + kilometresTraveled + "km to be exact.");
            Console.WriteLine("With having spent only " + hoursTraveled + " hours to get there...");
            Console.WriteLine("You traveled with a speed of " + kilometresPerHour + "km/h.");

            // Exercise 6
            int firstValue = 17;
            int secondValue = 13;

            double firstValueDouble = firstValue;
            double secondValueDouble = secondValue;

            double intDivision = firstValue / secondValue;
            double doubleDivision = firstValueDouble / secondValueDouble;

            Console.WriteLine("\nThese two numbers, " + firstValue + " and " + secondValue + ", are both integers.");
            Console.WriteLine("Dividing the bigger with the smaller, gives us " + intDivision);

            Console.WriteLine("\n.. and these two numbers, " + firstValueDouble + " and " + secondValueDouble + ", are both doubles.");
            Console.WriteLine("Dividing the bigger with the smaller, gives us " + doubleDivision);

            // Exercise 7
            double waterQuantity = 8.34;
            double waterAdded = 5.92;
            double waterRemoved = 13.21;

            Console.WriteLine("\nWe have a container in the office, currently containing " + waterQuantity + "L water.");
            
            waterQuantity += waterAdded;
            Console.WriteLine("Weekly maintenance added " + waterAdded + "L to it so it's now containing " + waterQuantity + "L water.");

            waterQuantity -= waterRemoved;
            Console.WriteLine("We were hit by a heatwave, so we drank " + waterRemoved + "L water, leaving us with only " + waterQuantity + "L water.");

            // Exercise 8
            Console.Write("\nYou went on a walk recently. Please tell me what you would like to name the route: ");
            string routeTitle = Console.ReadLine();
            
            double routeDistance = 17.34;
            double firstSectionDistance = 4.18;
            double secondSectionDistance = 6.21;
            double hoursWalked = 2.74;

            double distanceCompleted = firstSectionDistance + secondSectionDistance;
            double distanceRemaining = routeDistance - distanceCompleted;
            double distancePerHour = distanceCompleted / hoursWalked;

            Console.WriteLine("\nSo.. The route, " + routeTitle + ", is " + routeDistance + "km long.");
            Console.WriteLine("You walked " + firstSectionDistance + "km before taking your first break.");
            Console.WriteLine("You then proceeded to walk another " + secondSectionDistance + "km before ending the day.");
            Console.WriteLine("In total, you walked for " + hoursWalked + " hours.");

            Console.WriteLine("That means, that you walked " + distanceCompleted + "km on your first day.");
            Console.WriteLine("This leaves you with " + distanceRemaining + "km on the second day.");
            Console.WriteLine("Walking at a pace of " + distancePerHour + "km/h, it shouldn't take long to finish.");

            Console.WriteLine("\nSo.. A brief summary:");
            Console.WriteLine("Route: " + routeTitle);
            Console.WriteLine("Kilometres walked: " + distanceCompleted + "km");
            Console.WriteLine("Kilometres remaining: " + distanceRemaining + "km");
            Console.WriteLine("Walking speed: " + distancePerHour + "km/h");
        }
    }
}
