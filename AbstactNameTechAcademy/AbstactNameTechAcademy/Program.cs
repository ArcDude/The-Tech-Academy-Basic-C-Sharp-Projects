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
            Console.WriteLine("Enter your first name:");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            employee.LastName = Console.ReadLine();
            Console.WriteLine("Enter your ID number:");
            employee.Id = Convert.ToInt32(Console.ReadLine());
            employee.SayName();
            Console.WriteLine("ID: {0}", employee.Id);
            Console.WriteLine("The program will now end.");
            Console.ReadLine();
            employee.Quit();
        }
    }
}
