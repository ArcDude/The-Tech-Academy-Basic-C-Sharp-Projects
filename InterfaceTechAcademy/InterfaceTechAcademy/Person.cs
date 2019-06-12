using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTechAcademy
{
    public abstract class Person
    {
        public virtual void SayName()
        {
            FirstName = "Sample";
            LastName = "Student";
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
