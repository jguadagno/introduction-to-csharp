using System;

namespace Introduction.UnderstandingScope
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l);

            }
            //Console.WriteLine(i);
            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for: " + k);

            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething();

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod(): " + k);
        }

    }

    class Car // Default internal
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        string helperMethod() // Default Private
        {
            return "Hello world!";
        }

    }
}