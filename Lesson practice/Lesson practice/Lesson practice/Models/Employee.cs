using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_practice.Models
{
    public class Employee : Person
    {
        public override void Test()
        {
            Console.WriteLine("Employee Test"); 
        }
    }
}
