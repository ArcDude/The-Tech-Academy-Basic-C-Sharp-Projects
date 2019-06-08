using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsTechAcademy
{
    public class Math
    {
        public int Add(int num1, int num2)
        {
            num1 += num1;
            Console.WriteLine("The first value added by itself is: {0}", num1);
            Console.WriteLine("You can't do anything about the fact that this number is {0}", num2);
            Console.ReadLine();
            return num1;
        }
        public int Sub(int num1, int num2)
        {
            num1 -= num1;
            Console.WriteLine("The first value subtracted by itself is: {0}", num1);
            Console.WriteLine("You can't do anything about the fact that this number is {0}", num2);
            Console.ReadLine();
            return num1;
        }
        public int Multi(int num1, int num2)
        {
            num1 *= num1;
            Console.WriteLine("The first value squared is: {0}", num1);
            Console.WriteLine("You can't do anything about the fact that this number is {0}", num2);
            return num1;
        }
        
    }
}
