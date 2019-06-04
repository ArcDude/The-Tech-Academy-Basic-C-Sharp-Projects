using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            math.Num2 = 7;
            Console.WriteLine("What would you like to add to 7?");
            math.Num1 = Convert.ToInt32(Console.ReadLine());
            int sum = math.Num1 + math.Num2;
            Console.WriteLine( math.Num1 + " plus " + math.Num2 + " equals " + sum);
            Console.ReadLine();

            Console.WriteLine("What would you like to subtract with 7?");
            math.Num1 = Convert.ToInt32(Console.ReadLine());
            int difference = math.Num1 - math.Num2;
            Console.WriteLine(math.Num1+ " minus " + math.Num2 + " equals " + difference);
            Console.ReadLine();

            Console.WriteLine("What would you like to multiply with 7?");
            math.Num1 = Convert.ToInt32(Console.ReadLine());
            int product = math.Num1 * math.Num2;
            Console.WriteLine(math.Num1 + " times " + math.Num2 + " equals " + product);
            Console.ReadLine();
        }
    }
}
