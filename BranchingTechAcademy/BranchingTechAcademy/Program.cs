using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxDimensions = 50;
            int maxWeight = 50;
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter a weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight <= maxWeight)
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());
                int userDimensions = width + height + length;

                if (userDimensions <= maxDimensions)
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + userDimensions * weight / 100.00);
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
        }
    }
}
