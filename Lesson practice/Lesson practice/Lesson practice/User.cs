using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_practice
{
    public class User : IUser
    {
        public void Login(string username, string password)
        {
            Console.WriteLine("Login");
        }

        public string SendEmail(string email)
        {
            return "Email";
        }
    }
}
