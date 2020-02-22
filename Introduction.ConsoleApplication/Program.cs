using System;
namespace Introduction.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Program");
            string firstName = "Joe James Guadagno";

            Console.WriteLine("o is found at {0}", firstName.IndexOf('o'));


            Console.WriteLine("Ending Program");
            Console.ReadLine();
        }
    }
}