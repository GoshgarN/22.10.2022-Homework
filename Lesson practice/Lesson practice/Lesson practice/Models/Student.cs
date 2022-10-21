using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_practice.Models
{
    public class Student : Person
    {

        //public override string ToString()
        //{
        //    return Name + " " + SurName + " " + Age;
        //}
        public override void Test()
        {
            Console.WriteLine("Test Student");
        }
    }
}
