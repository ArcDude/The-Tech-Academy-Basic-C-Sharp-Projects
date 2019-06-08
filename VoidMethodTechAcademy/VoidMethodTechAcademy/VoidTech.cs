using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodTechAcademy
{
   public class VoidTech
    {
        public void Sample(int num1, int num2)
        {
            num1 *= num1;
            Console.WriteLine("The first value squared: {0}", num1);
            Console.WriteLine("The second value is: {0}", num2);
        }
    }
}
