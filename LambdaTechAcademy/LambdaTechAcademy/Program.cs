using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaTechAcademy
{
    class Program
    {
        enum Employee
        {
            Joe_Bruns,
            Adam_Smith,
            Joe_Baily,
            Alexa_Hays,
            Alisa_Max,
            Edith_Mays,
            Josh_Perterson,
            Ashley_Brown,
            Barton_Spring,
            Susan_Pho
        }

        static void Main(string[] args)
        {
            foreach (string person in Enum.GetNames(typeof(Employee)))
            {

                Console.ReadLine();
            }
        }
    }
}
