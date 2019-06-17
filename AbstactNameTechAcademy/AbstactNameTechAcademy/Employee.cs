using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactNameTechAcademy
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }
        public int Id { get; set; }

        public void Quit()
        {
            Environment.Exit(0);
        }
        
       
        //public static Employee operator ==(Employee employee, Employee employee1)
        //{
        //    if (employee.Id == employee1.Id)
        //    {
        //        Console.WriteLine("The IDs are the same.");
        //    }
        //    return bool;

        //}
        //public static Employee operator !=(Employee Employee1, Employee Employee2)
        //{
        //    if (Employee1.Id != Employee2.Id)
        //    {
        //        Console.WriteLine("The IDs are not the same");
        //    }
        //    return bool;
        //}
       
    }
}
