using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_practice.Models
{
    class Bird : Animal
    {

        public override void GetSound()
        {
            Console.WriteLine("Chik Chik");
        }
    }
}
