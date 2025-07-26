using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session03.InterfaceEx1
{
    internal interface IMyType
    {
        public double Salary { get; set; }
        // 2. Signature Of Method[Name of function , Parameter , Return Type] Only not have body(code):
        void MyFun();
        // 3.Default Implemented Method  [Fully Implemented Method]
        void Print()
        {
            Console.WriteLine("Fully Implemented Method");
        }

    }
}
