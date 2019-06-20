using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter a number:");
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime.Now.AddHours(hours);
            Console.WriteLine("It will be {0} in {1} hour(s)", DateTime.Now.AddHours(hours), hours);
            Console.ReadLine();

        }
    }
}
