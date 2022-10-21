using Lesson_practice.Models;
using Lesson_practice.Services.Implementation;
using Lesson_practice.Services.Interface;
using System;

namespace Lesson_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //Console.WriteLine(car.Name);

            //Cat cat = new Cat();

            //cat.GetSound();

            //Bird bird = new Bird();
            //bird.GetSound();

            //Animal animal = new Animal();
            //animal.GetSound();

            //cat.Eat();

            //Student student = new Student()
            //{
            //    Name = "Qoshqar",
            //    SurName = "Narimanli",
            //    Age = 30
            //};

            //Console.WriteLine(GetStudent(student, 29));

            //Student stu1 = new Student();
            //stu1.Test();

            //Employee emp1 = new Employee();
            //emp1.Test();

            //Car car = new Car();

            //IUser user = new User();
            //user.Login("Salam", "Saqol");

            IAccountService service = new AccountService();
            service.Register();


        }
        //public static Student GetStudent(Student student, int age)
        //{
        //    student.Age = age;
        //    return student;
        //}
    }
}
