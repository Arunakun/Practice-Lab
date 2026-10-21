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
        }
    }
}
