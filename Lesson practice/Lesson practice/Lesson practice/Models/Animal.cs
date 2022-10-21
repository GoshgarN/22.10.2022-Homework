using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_practice.Models
{
    class Animal
    {

        public string Name { get; set; }

        public virtual void GetSound()
        {
            Console.WriteLine("Animal sound");
        }

        public void Eat()
        {
            Console.WriteLine("Animal Eating");
        }

        public void Eat(string meal)
        {
            Console.WriteLine(meal);
        }

        public void Eat(string meal, string water)
        {
            Console.WriteLine(meal + " " + water);
        }
    }
}
