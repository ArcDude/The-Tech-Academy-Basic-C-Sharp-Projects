using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] loopString = { "boop", "bop" };
            for (int i = 0; i < loopString.Length; i++)
            {
                Console.WriteLine("Input some text:");
                Console.ReadLine();
                Console.WriteLine(loopString[i]);
                string appendString = string.Concat(loopString[i]);
                Console.WriteLine(appendString);
            }
            Console.ReadLine();
        } 
    }
}
