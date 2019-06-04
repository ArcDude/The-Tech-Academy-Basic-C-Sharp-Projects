using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidTech voidTech = new VoidTech();
            voidTech.Int1 = 4;
            voidTech.Int2 = 2;
            Console.WriteLine(voidTech.Int1 + " " + voidTech.Int2);
            Console.ReadLine();
        }
    }
}
