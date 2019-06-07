using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidIntegerTechAcademy
{
    public class VoidDivision
    {
        public void Division()
        {
            Console.WriteLine("Enter an integer that will be divided by 2:");
            Div = Convert.ToInt32(Console.ReadLine());
            int quotient = Div / 2;
            Console.WriteLine("{0} divided by 2 equals {1}", Div, quotient);
        }

        public int Div { get; set; }
    }
}
