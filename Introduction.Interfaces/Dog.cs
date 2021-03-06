﻿using System;

namespace Introduction.Interfaces
{
    public class Dog : IPet
    {
        public string Name { get; set; }
        public int NumberOfLives { get; set; }
        public int NumberOfLegs { get; set; }
        public GenderEnum Gender { get; set; }

        public void Speak(string whatToSay)
        {
            Console.WriteLine($"From Dog: My name is '{Name}' and I say '{whatToSay}'");
        }
    }
}
