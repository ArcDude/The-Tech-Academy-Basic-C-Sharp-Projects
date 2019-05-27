using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "When you want to ";
            string string2 = "yell, use ";
            string caps = "caps!!!";
            Console.WriteLine(string1 + string2 + caps.ToUpper());
            Console.ReadLine();
            string txt1 = "I like pineaples on pizza.";
            string txt2 = "He doesn't like pineapples on pizza.";
            string txt3 = "We have a hard time seeing eye to eye.";
            Console.WriteLine(txt1);
            Console.WriteLine(txt2);
            Console.WriteLine(txt3);
            Console.ReadLine();
        }
    }
}
