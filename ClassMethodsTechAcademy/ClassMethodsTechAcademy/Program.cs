using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("What number do you want to do the math operations on?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            math.Add(userInput, 2);
            math.Sub(userInput, 7);
            math.Multi(userInput, 12);
            Console.ReadLine();
        }
    }
}
