using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction.While
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n < 6)
            {
                Console.WriteLine("Current value of n is {0}", n);
                n++;
            }

            Console.WriteLine();
            Console.WriteLine("while(true)");
            int i = 0;
            while (true)
            {
                Console.WriteLine("Current value of n is {0}", i);
                i++;
                if (i == 20)
                {
                    break;
                }
            }

            int month = 1;
            while (month <= 12)
            {
                if (DateTime.DaysInMonth(2016, month) == 30)
                {
                    Console.WriteLine("{0} has 30 days",
                        new DateTime(2016, month, 1).ToString("MMMM"));
                }
                month++;
            }

            int month1 = 1;
            while (true)
            {
                if (DateTime.DaysInMonth(2016, month1) == 30)
                {
                    Console.WriteLine("{0} has 30 days",
                        new DateTime(2016, month1, 1).ToString("MMMM"));
                }
                if (month1 == 12)
                {
                    break;
                }
                month1++;
            }

            Console.ReadLine();
        }
    }
}
