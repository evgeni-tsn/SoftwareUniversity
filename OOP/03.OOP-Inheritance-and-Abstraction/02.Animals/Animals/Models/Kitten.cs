﻿using System;
using _02.Animals.Animals.Interfaces;

namespace _02.Animals.Animals
{
    public class Kitten : Animal, ISoundProducible
    {
        public Kitten(string name, int age) 
            : base(name, age, Gender.Male)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine($"The cat {this.Name} says: Meow!");
        }
    }
}