using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactNameTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee employee1 = new Employee();
            Console.WriteLine("Input a first name");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Input a last name");
            employee.LastName = (Console.ReadLine());
            Console.WriteLine("Enter an ID number");
            employee.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input another first name");
            employee1.FirstName = Console.ReadLine();
            Console.WriteLine("Input another last name");
            employee1.LastName = (Console.ReadLine());
            Console.WriteLine("Enter another ID number");
            employee1.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first employee's name is {0} {1} and thier ID number is {2}.", employee.FirstName, employee.LastName, employee.Id);
            Console.WriteLine("The second employee's name is {0} {1} and thier ID number is {2}.", employee1.FirstName, employee1.LastName, employee1.Id);
            //Employee employee = new Employee();
            //Console.WriteLine("Enter your first name:");
            //employee.FirstName = Console.ReadLine();
            //Console.WriteLine("Enter your last name:");
            //employee.LastName = Console.ReadLine();
            //Console.WriteLine("Enter your ID number:");
            //employee.Id = Convert.ToInt32(Console.ReadLine());
            //employee.SayName();
            //Console.WriteLine("Employee1's ID: {0}", employee.Id);
            //Console.WriteLine("The program will now end.");
            Console.ReadLine();
            //employee.Quit();

        }
    }
}
