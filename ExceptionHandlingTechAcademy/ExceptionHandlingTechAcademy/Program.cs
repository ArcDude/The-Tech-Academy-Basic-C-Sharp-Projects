using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>();
                numbers.Add(4);
                numbers.Add(9);
                numbers.Add(28);
                numbers.Add(2);
                numbers.Add(16);
                Console.WriteLine("Enter a number to divide from the list.");
                int divide = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(numbers[0] + " divided by " + divide + " equals " + numbers[0] / divide);
                Console.WriteLine(numbers[1] + " divided by " + divide + " equals " + numbers[1] / divide);
                Console.WriteLine(numbers[2] + " divided by " + divide + " equals " + numbers[2] / divide);
                Console.WriteLine(numbers[3] + " divided by " + divide + " equals " + numbers[3] / divide);
                Console.WriteLine(numbers[4] + " divided by " + divide + " equals " + numbers[4] / divide);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number");
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero, it's illegal");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
