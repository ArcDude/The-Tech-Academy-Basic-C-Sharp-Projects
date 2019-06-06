using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalClassTechAcademy
{
    public class Decimal
    {
        public Decimal()
        {
            Console.WriteLine("Enter an integer to be divided by 2:");
            Int1 = Convert.ToInt32(Console.ReadLine());
            Int2 = 2;
            int quotient = Int1 / Int2;
            Console.WriteLine(Int1 + " divided by " + Int2 + " equals " + quotient);
            Console.WriteLine("Enter a decimal to be added by 6:");
            Dec = Convert.ToDecimal(Console.ReadLine());
            Int2 = 6;
            int sum = Convert.ToInt32(Dec + Int2);
            Console.WriteLine(Dec + " added to " + Int2 + " equals " + sum + " converted back to an integer.");
            Console.WriteLine("Enter a number in string format to be multiplied by three.");
            NumString = Console.ReadLine();
            try
            {
                int num1 = Int32.Parse(NumString);
                Int2 = 3;
                int product = num1 * Int2;
                Console.WriteLine(num1 + " multiplied by " + Int2 + " equals " + product);
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert {0} to an integer.", NumString);
            }
        }
        public int Int1 { get; set; }
        public int Int2 { get; set; }
        public decimal Dec { get; set; }
        public string NumString { get; set; }
    }
}
