using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalClassTechAcademy
{
    public class Decimal
    {
        public int Opp(int num1)
        {
            num1 /= num1;
            Console.WriteLine("The value divided by itself is: {0}", num1);
            Console.ReadLine();
            return num1;
        }

        public double Opp(double dec1)
        {
            dec1 *= dec1;
            int dec2 = Convert.ToInt32(dec1);
            Console.WriteLine("The value squared after being converted back to an integer is: {0}", dec2);
            Console.ReadLine();
            return dec1;
        }
        public string Opp(string str1)
        {
            int str2 = Convert.ToInt32(str1);
            str2 += str2;
            Console.WriteLine("The value added by itself is: {0}", str2);
            return str1;
        }
    }
}
