using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_practice
{
    public interface IUser
    {
        void Login(string username, string password);
        string SendEmail(string email);
    }
}
