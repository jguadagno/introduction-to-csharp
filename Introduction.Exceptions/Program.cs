using System;

namespace Introduction.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividend = 0;
            int divisor = 0;
            int result = 0;


            Console.WriteLine("Please enter the dividend");
            var dividendAsString = Console.ReadLine();
            Console.WriteLine("Please enter the divisor");
            var divisorAsString = Console.ReadLine();

            try
            {
                dividend = int.Parse(dividendAsString);
                divisor = int.Parse(divisorAsString);

                result = dividend/divisor;
                Console.WriteLine(result);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine($"You entered a non number.");
            }
            catch (DivideByZeroException divideByZeroException)
            {
                Console.Write("Seriously? Divided by zero");
            }
            catch (Exception exception)
            {
                Console.Write($"Failed to divide {dividend} by {divisor} because '{exception.Message}'");
                //throw;
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
