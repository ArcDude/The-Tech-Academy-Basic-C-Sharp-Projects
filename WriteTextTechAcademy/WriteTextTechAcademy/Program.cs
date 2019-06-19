using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteTextTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered {0} in your number.txt file on your desktop.", number);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Schui\Desktop\number.txt", true))
            {
                file.WriteLine(number);
            }
            Console.ReadLine();

        }
    }
}
