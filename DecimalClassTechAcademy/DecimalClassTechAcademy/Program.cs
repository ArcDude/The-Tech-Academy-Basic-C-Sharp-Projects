using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalClassTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal deci = new Decimal();
            deci.Opp(12);
            deci.Opp(5.6);
            deci.Opp("2");
            Console.ReadLine();
        }
    }
}
