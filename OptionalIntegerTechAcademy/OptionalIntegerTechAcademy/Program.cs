using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalIntegerTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Optional optional = new Optional();
            Console.WriteLine("Enter the first integer: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer, or just press enter, I don't care.");
            string option = Console.ReadLine();
            optional.ifYouWant(userInput, option);
            Console.ReadLine();
        }
    }
}
