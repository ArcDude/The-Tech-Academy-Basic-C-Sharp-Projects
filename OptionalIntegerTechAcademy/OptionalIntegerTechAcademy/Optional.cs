using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalIntegerTechAcademy
{
    public class Optional
    {
        public int ifYouWant(int num1, string opt1 )
        {
            if (opt1 == "")
            {
                num1 += num1;
                Console.WriteLine("The first value added to itself is: {0}", num1);
            }
            else
            {
                try
                {
                    int opt2 = Convert.ToInt32(opt1);
                    num1 += opt2;
                    Console.WriteLine("The first value added to the second value is: {0}", num1);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer, if you choose to have a second number.");
                }
            }
        return num1;
        }
    }
}
