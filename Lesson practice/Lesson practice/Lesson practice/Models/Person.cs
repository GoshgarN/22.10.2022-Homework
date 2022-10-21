using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_practice.Models
{
   public abstract class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

        public abstract void Test();
    }
}
