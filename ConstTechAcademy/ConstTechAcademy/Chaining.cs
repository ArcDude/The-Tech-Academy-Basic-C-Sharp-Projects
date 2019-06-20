using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstTechAcademy
{
    public class Chaining
    {
        string add = "This string is being added to the chain.";
        int addint = 4;
        public Chaining(string chain1) : this(chain1, 12)
        {
        }
        public Chaining(string chain1, int chain2)
        {
            add = chain1;
            addint = chain2;
        }
       
    }
}
