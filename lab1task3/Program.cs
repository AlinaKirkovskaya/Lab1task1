using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the employee's last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter the employee's first name:");
            string firstName = Console.ReadLine();

            Employee employee = new Employee(lastName, firstName);

            Console.WriteLine("Enter the employee's position (Junior/Middle/Senior):");
            string position = Console.ReadLine();
            employee.SetPosition(position);

            Console.WriteLine("Enter the employee's years of experience:");
            if (!int.TryParse(Console.ReadLine(), out int experience))
            {
                Console.WriteLine("Invalid experience input.");
                return;
            }
            employee.SetExperience(experience);

            employee.DisplayInfo();
        }
    }
    
}
