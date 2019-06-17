using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTechAcademy
{
    class Program
    {
        enum DaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week:");
            string day = Console.ReadLine();
            DaysOfWeek daysOfWeek;

            if (Enum.TryParse(day, true, out daysOfWeek))
            {
                if (Enum.IsDefined(typeof(DaysOfWeek), daysOfWeek))
                    Console.WriteLine("The day is {0}", day);

                else
                    Console.WriteLine("Please enter a day of the week.");
            }
            else
            {
                Console.WriteLine("Please enter a day of the week.");
            }
            Console.ReadLine();
        }
    }
}
