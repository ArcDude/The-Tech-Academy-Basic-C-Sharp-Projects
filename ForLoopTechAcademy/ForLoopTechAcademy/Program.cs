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
            // Activity 2 
            //int x = 1;
            //while(x == 1)
            //{
            //    Console.WriteLine("This is an infinite loop");
            //}

            // Activity 3
            //int x = 1;
            //while (x == 1)
            //{
            //    Console.WriteLine("This is no longer an infinite loop");
            //    x = x + 1;
            //}
            //Console.ReadLine();

            // Activity 1, 4
            //string[] loopString = { "boop ", "bop " };
            //for (int i = 0; i < loopString.Length; i++)
            //{
            //    Console.WriteLine("Please enter something to add to the array.");
            //    string userInput = Console.ReadLine();
            //    Console.WriteLine(loopString[i]);
            //    loopString[i] = loopString[i] + userInput;
            //    Console.WriteLine(loopString[i]);
            //}
            //Console.ReadLine();


            // Activity 5
            string[] loopString = { "boop ", "bop " };
            for (int i = 0; i <= loopString.Length; i++)
            {
                Console.WriteLine("Please enter something to add to the array.");
                string userInput = Console.ReadLine();
                Array.Resize(ref loopString, loopString.Length + 1);
                loopString[loopString.Length - 1] = " Hi ";
                Console.WriteLine(loopString[i]);
                loopString[i] = loopString[i] + userInput;
                Console.WriteLine(loopString[i]);
                if (i == 2)
                {
                    Console.WriteLine("Goodbye");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            Console.ReadLine();

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
            //string nope = ("The string you entered is not in the list.");
            //foreach (string loopString in loopStringList)
            //{
            //    if (stringInput == loopString)
            //    {
            //        Console.WriteLine(loopStringList.IndexOf(loopString));
            //        Console.ReadLine();
            //        Environment.Exit(0);
            //    }
            //    else
            //    {
            //        Console.WriteLine(nope);
            //    }
            //}
            //Console.ReadLine();

            // Activity 9 - 10
            //List<string> loopStringList = new List<string>();
            //loopStringList.Add("this");
            //loopStringList.Add("string");
            //loopStringList.Add("is");
            //loopStringList.Add("in");
            //loopStringList.Add("this");
            //loopStringList.Add("list");
            //loopStringList.Add("of");
            //loopStringList.Add("strings");
            //Console.WriteLine("Insert either: 'this', 'string', 'is', 'in', 'this', 'list', 'of', or 'strings' ");
            //string stringInput = (Console.ReadLine());
            //for (var i = 0; i < loopStringList.Count; i++)
            //{
            //    if (stringInput == loopStringList[i])
            //    {
            //        Console.WriteLine(i);

            //    }
            //    else
            //    {
            //        Console.WriteLine("You didn't enter a string that is in the list.");
            //    }
            //}
            //Console.ReadLine();

            // Activity 11
            //List<string> loopStringList = new List<string>();
            //loopStringList.Add("this");
            //loopStringList.Add("string");
            //loopStringList.Add("is");
            //loopStringList.Add("in");
            //loopStringList.Add("this");
            //loopStringList.Add("list");
            //loopStringList.Add("of");
            //loopStringList.Add("strings");
            //var dupe = loopStringList
            //    .GroupBy(i => i)
            //    .Where(g => g.Count() > 1)
            //    .Select(g => g.Key);
            //foreach (var d in dupe)
            //{
            //    if (loopStringList.Count != loopStringList.Distinct().Count())
            //    {
            //        Console.WriteLine("The duplicate string in the list is: {0}", d);

            //    }
            //    else
            //    {
            //        Console.WriteLine("Something went wrong with the code!");
            //    }
            //}
            //Console.ReadLine();
        }
    }
}
