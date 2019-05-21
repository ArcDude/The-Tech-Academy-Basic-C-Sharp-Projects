using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Activity 1
            Console.WriteLine("Enter a number: ");
            string multiplication = Console.ReadLine();
            long multi = Convert.ToInt64(multiplication);
            Console.WriteLine(multi + " times 50 equals " + multi * 50);
            Console.ReadLine();

            // Activity 2
            Console.WriteLine("Enter a number: ");
            string addition = Console.ReadLine();
            long add = Convert.ToInt64(addition);
            Console.WriteLine(add + " plus 25 equals ");
            Console.WriteLine(add + 25);
            Console.ReadLine();

            //Activity 3
            Console.WriteLine("Enter a number: ");
            string division = Console.ReadLine();
            long div = Convert.ToInt64(division);
            Console.WriteLine(div + " divided by 12.5 equals " + div / 12.5);
            Console.ReadLine();

            //Activity 4
            Console.WriteLine("Enter a number: ");
            string greater = Console.ReadLine();
            long great = Convert.ToInt64(greater);
            bool isGreater = true;
            isGreater = great > 50;
            if (isGreater)
            {
                Console.WriteLine(great + " is greater than 50: " + isGreater);
            }
            else
            {
                Console.WriteLine(great + " is greater than 50: " + isGreater);
            }
            Console.ReadLine();

            //Activity 5
            Console.WriteLine("Enter a number: ");
            string remainder = Console.ReadLine();
            long rem = Convert.ToInt64(remainder);
            Console.WriteLine("The remainer of " + rem + " divided by 7 is " + rem % 7);
            Console.ReadLine();
        }
    }
}
