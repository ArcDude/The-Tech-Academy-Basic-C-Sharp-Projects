using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlyRateTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            float hours1 = Convert.ToSingle(hourlyRate1);
            Console.WriteLine("Hours worked per week?");
            string hoursWorked1 = Console.ReadLine();
            int worked1 = Convert.ToInt32(hoursWorked1);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            float hours2 = Convert.ToSingle(hourlyRate2);
            Console.WriteLine("Hours worked per week?");
            string hoursWorked2 = Console.ReadLine();
            int worked2 = Convert.ToInt32(hoursWorked2);
            Console.WriteLine("Weekly salary of Person 1:");
            Console.WriteLine(hours1 * worked1);
            float weekSal1 = (hours1 * worked1);
            Console.WriteLine("Weekly salary of Person 2:");
            Console.WriteLine(hours2 * worked2);
            float weekSal2 = (hours2 * worked2);
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();
            bool moreCash = true;
            moreCash = weekSal1 > weekSal2;
            if(moreCash)
            {
                Console.WriteLine("Person 1 makes more than Person 2: " + moreCash);
            }
            else
            {
                Console.WriteLine("Person 1 makes more than Person 2: " + moreCash);
            }
            Console.ReadLine();
        }
    }
}
