using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalIntegerTechAcademy
{
    public class Optional
    {
        public Optional()
        {
            Console.WriteLine("Enter an integer:");
            Opt1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second integer, or enter No:");
            Option = Console.ReadLine();
            try
            {
                
                if (Option == "No")
                {
                    Console.WriteLine("The program will now add {0} to 8", Opt1);
                    int sum1 = Opt1 + 8;
                    Console.WriteLine("{0} plus 8 equals {1}", Opt1, sum1);
                }
                else
                {
                    Opt2 = Int32.Parse(Option);
                    Console.WriteLine("The program will now add {0} and {1}", Opt1, Opt2);
                    int sum2 = Opt1 + Opt2;
                    Console.WriteLine("{0} plus {1} equals {2}", Opt1, Opt2, sum2);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to parse {0}", Option);
            }
               
        }
        public int Opt1 { get; set; }
        public string Option { get; set; }
        public int SetNum { get; set; }
        public int Opt2 { get; set; }
    }
}
