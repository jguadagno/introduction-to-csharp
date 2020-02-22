using System;

namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }
        public int TailLength { get; set; }

        public string Species { get; set; }

        public void Walk(int numberOfSteps)
        {
            Console.WriteLine("Walked {0} steps", numberOfSteps);
        }
    }
}
