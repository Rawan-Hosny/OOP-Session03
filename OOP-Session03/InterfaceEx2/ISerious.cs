using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session03.InterfaceEx2
{
    internal interface ISerious
    {
        public int Current { get; set; } // 0
        void Next();
        void Reset()
        {
            Current = 0;
        }

    }
}
