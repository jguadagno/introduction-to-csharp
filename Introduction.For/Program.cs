using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.For
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //NestedFor();
            FindLeapYearAndLongMonths();

            Console.WriteLine("End");
            Console.ReadLine();
        }

        public static void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    //break;
                }
            }
        }

        public static void NestedFor()
        {
            bool shouldBreak = false;
            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
                for (int x = 0; x < 10; x++)
                {
                    Console.WriteLine("MyValue='{1}', X = {0}", x, myValue);
                    if (x == 7)
                    {
                        shouldBreak = true;
                        break;
                    }
                }
                if (shouldBreak)
                {
                    break;
                }
            }
        }

        public static void FindLeapYearAndLongMonths()
        {
            for (int year = 2010; year <= 2020; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine("Year {0} is a leap year", year);
                }

                for (int month = 1; month <= 12; month++)
                {
                    if (DateTime.DaysInMonth(year, month) > 30)
                    {
                        Console.WriteLine("{0} ({1}) of Year {2} has more than 30 days",
                            new DateTime(year, month, 1).ToString("MMMM"), month, year);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
