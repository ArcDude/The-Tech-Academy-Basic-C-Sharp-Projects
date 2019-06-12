using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.SayName();
            employee.Identifcation();
            Console.ReadLine();
        }
    }
}
