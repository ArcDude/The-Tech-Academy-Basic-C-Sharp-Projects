using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamePropertiesTechAcademy
{
    public class Employee : Person
    {
        public void Identifcation()
        {
            Id = 100;
            Console.WriteLine("ID: {0}", Id);
        }
        public int Id { get; set; }
    }
}

