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
    }
}
