using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTryCatchTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool validAnswer = false;
            int age = 0;
            while (!validAnswer)
            {
                    Console.WriteLine("What is your age?");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("Please enter an integer.");
            }
            if (age <= 0)
            {
                throw new NiceTry();
            }
            bool ageTest = true;
            while (ageTest)
            {
                try
                {
                    Console.WriteLine("You were born in the year of {0}", DateTime.Now.Year - age);
                    Console.ReadLine();
                    return;
                }
                catch (NiceTry)
                {
                    Console.WriteLine("Nope. Can't fool this program.");
                    Console.ReadLine();
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("You broke it.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.ReadLine();
        }
    }
}
