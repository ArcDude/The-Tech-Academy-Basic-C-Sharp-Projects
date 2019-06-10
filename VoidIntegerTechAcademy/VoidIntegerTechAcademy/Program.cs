using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidIntegerTechAcademy
{
   static class Program
    {
        static void Main(string[] args)
        {
            VoidDivision voidDivision = new VoidDivision();
            voidDivision.Division();
            voidDivision.Division(out int x);
            Console.ReadLine();
        }
    }
}
