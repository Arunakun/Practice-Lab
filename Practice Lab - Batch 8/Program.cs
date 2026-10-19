namespace Practice_Lab___Batch_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Exercise 1\n");
            Console.Write("Give me a length in metres: ");
            string userInputMetres = Console.ReadLine();
            double inputMetres = double.Parse(userInputMetres);

            Console.WriteLine("Here is the original string input: " + userInputMetres);
            Console.WriteLine("Here is the converted version with a bonus suffix: " + inputMetres + "m");
        }
    }
}
