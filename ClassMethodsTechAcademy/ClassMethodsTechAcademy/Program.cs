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
            int sum = math.Add(math.Num2, math.Num1);
            int diff = math.Sub(math.Num2, math.Num1);
            int multi = math.Multi(math.Num2, math.Num1);
            Console.ReadLine();
        }
    }
}
