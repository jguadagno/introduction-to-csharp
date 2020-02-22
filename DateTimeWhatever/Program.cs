using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeWhatever
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = new DateTime(1999,5,31,2,17,00);

            Console.WriteLine(birthday.ToLongDateString() + " " + birthday.ToLongTimeString());
            Console.WriteLine(birthday.ToString("d"));

            Console.ReadLine();
        }
    }
}
