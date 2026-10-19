namespace Practice_Lab___Batch_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Exercise 1\n");
            
            {
                string message = "Corviknight is a Flying/Steel Pokémon introduced in Generation 8.";
                Console.WriteLine(message);
                Console.WriteLine(message);
            }
            
            Console.WriteLine("Yes I wrote it twice, what are you gonna do about it? It's a good Pokémon, I like it!");

            // Exercise 2
            string imaginaryPlaceName = "Marrowbean";
            Console.WriteLine("\n\nExercise 2\n");
            Console.WriteLine("Welcome to " + imaginaryPlaceName + " - a place of wonders!");
            
            {
                string activityName = "gaming";
                Console.WriteLine("The main activity to do around here is " + activityName);
            }
            
            Console.WriteLine("We hope you like it here in " + imaginaryPlaceName + "!");

            // Exercise 3
            int score = 17;
            int scoreGain = 13;
            Console.WriteLine("\n\nExercise 3\n");
            Console.WriteLine("Starting score: " + score + " points");

            {
                double liquidQuantity = 6.34;
                double liquidQuantityGain = 2.18;
                Console.WriteLine("Liquid amount: " + liquidQuantity + "L");

                liquidQuantity += liquidQuantityGain;
                Console.WriteLine("Adding " + liquidQuantityGain + "L to it gives us a total of " + liquidQuantity + "L.");
            }

            score += scoreGain;
            Console.WriteLine("Adding " + scoreGain + " points to the score gives us " + score + " points in total.");

            // Exercise 4
            string reportCaption = "I have no idea what a report caption is, so pretend this is a report caption.";
            Console.WriteLine("\n\nExercise 4\n");
            Console.WriteLine(reportCaption);

            {
                Console.Write("Please give me a title for a poster: ");
                string title = Console.ReadLine();
                Console.Write("Please give me an amount of copies per bundle of posters: ");
                string userInputPostersPerBundle = Console.ReadLine();
                Console.Write("And finally, please give me an amount of bundles copied: ");
                string userInputCountOfBundles = Console.ReadLine();

                int postersPerBundle = int.Parse(userInputPostersPerBundle);
                int countOfBundles = int.Parse(userInputCountOfBundles);
                int totalPosters = postersPerBundle * countOfBundles;

                Console.WriteLine("\nAlright, per your suggestion, here's an overview of the poster titled \"" + title + "\":");
                Console.WriteLine("In every bundle, there are " + postersPerBundle + " posters.");
                Console.WriteLine(countOfBundles + " bundles of posters were printed.");
                Console.WriteLine("That gives us a grand total of " + totalPosters + " printed.");
            }

            Console.WriteLine(reportCaption);

            // Exercise 5
            Console.WriteLine("\n\nExercise 6 (of batch 6, but actually this is exercise 5 of this batch (batch 7))\n");
            Console.Write("We need a name for our newest exhibitor, give me a suggestion: ");
            string exhibitorName = Console.ReadLine();

            Console.Write("Hmm.. I like the sound of that. Now, tell me how many leaflets it has: ");
            string userInputLeaflets = Console.ReadLine();
            int leaflets = int.Parse(userInputLeaflets);
            char standZone = 'C';
            bool isStandOpen = false;

            double standlength = 2.37;
            double standWidth = 3.59;
            double standArea = standlength * standWidth;

            Console.WriteLine("\nName of stand: " + exhibitorName);
            Console.WriteLine("Amount of leaflets: " + leaflets);
            Console.WriteLine("Zone: " + standZone);
            Console.WriteLine("Open: " + isStandOpen);
            Console.WriteLine("Length: " + standlength + " metres");
            Console.WriteLine("Width: " + standWidth + " metres");
            Console.WriteLine("Area: " + standArea + " square metres");

            standZone = 'P';
            isStandOpen = true;

            Console.WriteLine("\nUpdated summary of " + exhibitorName + ":");
            Console.WriteLine("Amount of leaflets: " + leaflets);
            Console.WriteLine("New Zone: " + standZone);
            Console.WriteLine("Open: " + isStandOpen);
            Console.WriteLine("Area of stand: " + standArea + " square metres");

            // Exercise 6
            Console.WriteLine("\n\nExercise 6 (of batch 6, but actually this is exercise 6 of this batch (batch 7))\n");
            Console.Write("We need a name for our newest exhibitor, give me a suggestion: ");
            string exhibitorNameAgain = Console.ReadLine();

            Console.Write("Hmm.. I like the sound of that. Now, tell me how many leaflets it has: ");
            string userInputLeafletsAgain = Console.ReadLine();
            int leafletsAgain = int.Parse(userInputLeafletsAgain);
            char standZoneAgain = 'C';
            bool isStandOpenAgain = false;

            double standlengthagain = 2.37;
            double standWidthAgain = 3.59;
            double standAreaAgain = standlengthagain * standWidthAgain;

            Console.WriteLine("\nName of stand: " + exhibitorNameAgain);
            Console.WriteLine("Amount of leaflets: " + leafletsAgain);
            Console.WriteLine("Zone: " + standZoneAgain);
            Console.WriteLine("Open: " + isStandOpenAgain);
            Console.WriteLine("Length: " + standlengthagain + " metres");
            Console.WriteLine("Width: " + standWidthAgain + " metres");
            Console.WriteLine("Area: " + standAreaAgain + " square metres");

            standZoneAgain = 'P';
            isStandOpenAgain = true;

            Console.WriteLine("\nUpdated summary of " + exhibitorNameAgain + ":");
            Console.WriteLine("Amount of leaflets: " + leafletsAgain);
            Console.WriteLine("New Zone: " + standZoneAgain);
            Console.WriteLine("Open: " + isStandOpenAgain);
            Console.WriteLine("Area of stand: " + standAreaAgain + " square metres");
        }
    }
}
