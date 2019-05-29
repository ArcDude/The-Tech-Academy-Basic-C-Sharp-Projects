using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArrayTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Array
            string[] stringArray = { "Red", "Blue", "Orange", "Gray" };
            Console.WriteLine("Enter a number from 0 - 3");
            int stringArrayInput = int.Parse(Console.ReadLine());
            if (stringArrayInput <= 3)
            {
                Console.WriteLine(stringArray[stringArrayInput]);
            }
            else
            {
                Console.WriteLine("Was expecting 0, 1, 2, or 3. Please reboot program and try again.");
            }
            Console.ReadLine();

            //Integer Array
            int[] intArray = { 7, 123, 923, 32, 5 };
            Console.WriteLine("Enter a number from 0 - 4");
            int intArrayInput = int.Parse(Console.ReadLine());
            if (intArrayInput <= 4)
            {
                Console.WriteLine(intArray[intArrayInput]);
            }
            else
            {
                Console.WriteLine("Was expecting 0, 1, 2, 3, or 4. Please reboot program and try again.");
            }
            Console.ReadLine();

            //String List
            List<string> stringList = new List<string>();
            stringList.Add("Yes");
            stringList.Add("No");
            stringList.Add("Maybe");
            stringList.Add("Possibly");
            Console.WriteLine("Please enter a number from 0 - 3");
            int stringListInput = int.Parse(Console.ReadLine());
            if (stringListInput <= 3)
            {
                Console.WriteLine(stringList[stringListInput]);
            }
            else
            {
                Console.WriteLine("Was expecting 0, 1, 2, or 3. Please reboot program and try again.");
            }
            Console.ReadLine();
        }
    }
}
