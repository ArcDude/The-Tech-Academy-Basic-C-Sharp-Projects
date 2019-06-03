using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Activity 1 - 5
            //string []loopString = { "boop ", "bop "};
            //for (int i = 0; i <= loopString.Length; i++)
            //{
            //    Console.WriteLine("Please enter something to add to the array.");
            //    string userInput = Console.ReadLine();
            //    Console.WriteLine(loopString[i]);
            //    loopString[i] = loopString[i] + userInput;
            //}
            //Console.ReadLine();

            // Activity 6 - 8
            //List<string> loopStringList = new List<string>();
            //loopStringList.Add("This");
            //loopStringList.Add("is");
            //loopStringList.Add("a");
            //loopStringList.Add("list");
            //loopStringList.Add("of");
            //loopStringList.Add("strings");
            //Console.WriteLine("Insert either: 'This', 'is', 'a', 'list', 'of', or 'strings' ");
            //string stringInput = (Console.ReadLine());
            //int index1 = loopStringList.IndexOf("This");
            //foreach (string loopString in loopStringList)
            //{
            //    if (stringInput == loopString)
            //    {
            //        Console.WriteLine(loopStringList.IndexOf(loopString));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter a different string to see what its index is, and if you don't see a number then that means you need to input a string from the list.");
            //    }
            //}
            //Console.ReadLine();


            List<string> loopStringList = new List<string>();
            loopStringList.Add("this");
            loopStringList.Add("string");
            loopStringList.Add("is");
            loopStringList.Add("in");
            loopStringList.Add("this");
            loopStringList.Add("list");
            loopStringList.Add("of");
            loopStringList.Add("strings");
            Console.WriteLine("Insert either: 'this', 'string', 'is', 'in', 'this', 'list', 'of', or 'strings' ");
            string stringInput = (Console.ReadLine());
            int index1 = loopStringList.IndexOf("This");
            foreach (string loopString in loopStringList)
            {
                if (stringInput == loopString)
                {
                    Console.WriteLine(loopStringList.IndexOf(loopString));
                }
                else
                {
                    Console.WriteLine("Enter a different string to see what its index is, and if you don't see a number then that means you need to input a string from the list.");
                }
            }
            Console.ReadLine();
        }
    }
}
