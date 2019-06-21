using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTryCatchTechAcademy
{
    public class NiceTry : Exception
    {
        public NiceTry()
            : base() { }
        public NiceTry(string message)
            : base(message) { }
    }
}