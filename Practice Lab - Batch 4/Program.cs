namespace Practice_Lab___Batch_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.Write("Please type how many pages you've read tonight: ");
            string pagesInput = Console.ReadLine();
            int pages = int.Parse(pagesInput);
            int finalPageCount = pages + 1;

            Console.WriteLine("\nYou've read a grand total of " + pages + " pages today..");
            Console.WriteLine("If you'd read another page, you would've ended on " + finalPageCount + " pages instead.");
        }
    }
}
