using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerMethodTechAcademy
{
    class Operation
    {
        public Operation()
        {
            Console.WriteLine("Enter the first number:");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Num1 + " times " + Num2 + " equals " + Num1 * Num2);
            Console.WriteLine("Num1 = " + Num1);
            Console.WriteLine("Num2 = " + Num2);
            Console.ReadLine();
        }
        
        public int Num1 { get; set; }
        public int Num2 { get; set; }
    }
}
