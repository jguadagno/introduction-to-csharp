using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.IfProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //IfConsoleApplication();
            //SwitchConsoleApplication();
        }

        public static void IfConsoleApplication()
        {
            Console.Write("Enter a character: ");
            char ch = (char)Console.Read();

            if (Char.IsUpper(ch))
            {
                Console.WriteLine("The character is an uppercase letter.");
            }
            else if (Char.IsLower(ch))
            {
                Console.WriteLine("The character is a lowercase letter.");
            }
            else if (Char.IsDigit(ch))
            {
                Console.WriteLine("The character is a number.");
            }
            else
            {
                Console.WriteLine("The character is not alphanumeric.");
            }

            //Sample Input and Output:
            //Enter a character: E
            //The character is an uppercase letter.

            //Enter a character: e
            //The character is a lowercase letter.

            //Enter a character: 4
            //The character is a number.

            //Enter a character: =
            //The character is not alphanumeric.
        }

        public static void SwitchConsoleApplication()
        {
            Console.WriteLine("Coffee sizes: 1=small 2=medium 3=large");
            Console.Write("Please enter your selection: ");
            string str = Console.ReadLine();
            int cost = 0;

            // Notice the goto statements in cases 2 and 3. The base cost of 25
            // cents is added to the additional cost for the medium and large sizes.
            switch (str)
            {
                case "1":
                case "small":
                    cost += 25;
                    break;
                case "2":
                case "medium":
                    cost += 25;
                    goto case "1";
                case "3":
                case "large":
                    cost += 50;
                    goto case "1";
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Please insert {0} cents.", cost);
            }
            Console.WriteLine("Thank you for your business.");
        }
    }
}
