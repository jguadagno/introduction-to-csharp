using System;
using System.Collections.Generic;

namespace Introduction.Interfaces.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var sammie = new Cat {Name = "Sammie", NumberOfLives = 4, Gender = GenderEnum.Male, NumberOfLegs = 4};
            var max = new Cat {Name = "Max", NumberOfLives = 8, Gender = GenderEnum.Male, NumberOfLegs = 4};
            var jessie = new Dog {Name = "Jessie", Gender = GenderEnum.Female, NumberOfLegs = 4, NumberOfLives = 1};
            var spider = new Spider {Name="Peter", NumberOfLegs = 8, NumberOfLives = 1, Gender = GenderEnum.Male};

            List<IPet> pets = new List<IPet> {sammie, max, jessie, spider};

            CheckNumberOfLivesRemaining(pets);
            MakeAnimalsSpeak(pets);
            Console.ReadLine();
        }

        public static void CheckNumberOfLivesRemaining(List<IPet> pets)
        {
            foreach (var pet in pets)
            {
                if (pet.NumberOfLives <= 1)
                {
                    Console.WriteLine($"Oh snap, be careful with {pet.Name}, it has {pet.NumberOfLives} left.");
                }
            }
        }

        public static void MakeAnimalsSpeak(List<IPet> pets)
        {
            foreach (var pet in pets)
            {
                if (pet is Cat)
                {
                    pet.Speak("Meow");
                }
                else if (pet is Dog)
                {
                    pet.Speak("Ruff");
                }
                else if (pet is Spider)
                {
                    pet.Speak("");
                }
            }
        }
    }
}
