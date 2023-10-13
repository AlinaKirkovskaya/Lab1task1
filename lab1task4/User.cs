using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1task4
{
    internal class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private readonly DateTime registrationDate;

        public User(string login, string firstName, string lastName, int age)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.registrationDate = DateTime.Now;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("User information:");
            Console.WriteLine($"login: {login}");
            Console.WriteLine($"Name: {firstName}");
            Console.WriteLine($"Lastname: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Registration date: {registrationDate}");
        }
    }
}
