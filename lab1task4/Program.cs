using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lab1task4";

            Console.WriteLine("Enter your login:");
            string login = Console.ReadLine();

            Console.WriteLine("Enter a name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter age:");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Please, input correct value in double/float format");
                return;
            }

            User user = new User(login, firstName, lastName, age);

            Console.WriteLine("\nEntered information:");
            user.DisplayInfo();
        }
    }
    
}
