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
            Num2 = 7;
            return Num2 + Num1;
        }
        public int Sub(int Num2, int Num1)
        {
            Num2 = 7;
            return Num2 - Num1;
        }
        public int Multi(int Num2, int Num1)
        {
            Num2 = 7;
            return Num2 * Num1;
        }
        public int Num2 { get; set; }
        public int Num1 { get; set; }
    }
}
