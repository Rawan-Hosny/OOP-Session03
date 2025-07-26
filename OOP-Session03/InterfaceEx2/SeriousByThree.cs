using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session03.InterfaceEx2
{
    internal class SeriousByThree : ISerious
    {
        public int Current { get; set; }

        public void Next()
        {
            Current += 3;
        }
    }
}
