using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string howOld = Console.ReadLine();
            int age = Convert.ToInt32(howOld);
            Console.WriteLine("Have you ever had a DUI?(true, or false)");
            string hadDUI = Console.ReadLine();
            bool DUI = Convert.ToBoolean(hadDUI);
            Console.WriteLine("How many speeding tickets do you have?");
            string speeding = Console.ReadLine();
            int speed = Convert.ToInt32(speeding);
            Console.WriteLine("Qualified?");
            Console.ReadLine();
            Console.WriteLine(age > 15 && DUI == false && speed <= 3);
            Console.ReadLine();
        }
    }
}
