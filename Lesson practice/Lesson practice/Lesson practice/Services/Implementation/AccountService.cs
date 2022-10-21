using Lesson_practice.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_practice.Services.Implementation
{
    public class AccountService : IAccountService

    {
        public void Register()
        {
            Console.WriteLine("Already Register");
        }
    }
}
