using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Just follow the rules:");
            Console.WriteLine("Please enter '1' or '2':");
            int rules = Convert.ToInt32(Console.ReadLine());
            bool correct = rules == 2;
            do
            {
                switch (rules)
                {
                    case 1:
                        Console.WriteLine("You have succesfully entered the number 1, however this is not the right answer, so please try again. :)");
                        Console.WriteLine("Please enter '1' or '2':");
                        rules = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You have inputed the equivilent of 10 to the console, and have found the right answer.");
                        correct = true;
                        break;
                    case 0:
                        Console.WriteLine("No. Bad user. Stop thinking outside of the box. This is the only easter egg that matters. Don't bother finding the other one, there is no point");
                        Console.WriteLine("Please enter '1' or '2':");
                        rules = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("What are you doing here, there is nothing of interest to see here.");
                        Console.ReadLine();
                        Console.WriteLine("This is just a waste of your time, you should have just followed the rules.");
                        Console.ReadLine();
                        Console.WriteLine("Oh, you're still here.");
                        Console.ReadLine();
                        Console.WriteLine("So... what now?");
                        Console.ReadLine();
                        Console.WriteLine("You do know that you can exit this whenever you want, right?");
                        Console.ReadLine();
                        Console.WriteLine("Huh, guess you didn't want to leave.");
                        Console.ReadLine();
                        Console.WriteLine("");
                        Console.ReadLine();
                        Console.WriteLine("");
                        Console.ReadLine();
                        Console.WriteLine("");
                        Console.ReadLine();
                        Console.WriteLine("");
                        Console.ReadLine();
                        Console.WriteLine("");
                        Console.ReadLine();
                        Console.WriteLine("Fine, you persistent little pest, have a high five and get out of my sight!");
                        Console.ReadLine();
                        Console.WriteLine("Sheesh! Just enter either '1' or '2' this time!");
                        Console.ReadLine();
                        Console.WriteLine("Enter '1' or '2':");
                        rules = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!correct);
            Console.Read();

        }
    }
}
