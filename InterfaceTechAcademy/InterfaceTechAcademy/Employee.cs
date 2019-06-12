using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTechAcademy
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }
        public void Identifcation()
        {
            Id = 100;

            Console.WriteLine("ID: {0}", Id);
        }
        public int Id { get; set; }
        public static Employee operator== (Employee employee, Person person)
        {
            employee.Id.Equals(person);
            return employee;
        }
        public static Employee operator!= (Employee employee, Person person)
        {
            employee.Id.Equals(person);
            return employee;
        }
        public void Quit(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
