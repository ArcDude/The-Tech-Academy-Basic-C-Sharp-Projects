using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsTechAcademy
{
    public class Math
    {
        public int Add(int Num2, int Num1)
        {
            Console.WriteLine("Enter a number to add to 7:");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Num2 = 7;
            Console.WriteLine(Num1 + " + " + Num2 + " equals:");
            Console.WriteLine(Num2 + Num1);
            return Num2 + Num1;
        }
        public int Sub(int Num2, int Num1)
        {
            Console.WriteLine("Enter a number to subtract from 7:");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Num2 = 7;
            Console.WriteLine(Num2 + " - " + Num1 + " equals:");
            Console.WriteLine(Num2 - Num1);
            return Num2 - Num1;
        }
        public int Multi(int Num2, int Num1)
        {

            Console.WriteLine("Enter a number to multiply by 7:");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Num2 = 7;
            Console.WriteLine(Num2 + " * " + Num1 + " equals:");
            Console.WriteLine(Num2 * Num1);
            return Num2 * Num1;
        }
        public int Num2 { get; set; }
        public int Num1 { get; set; }
    }
}
