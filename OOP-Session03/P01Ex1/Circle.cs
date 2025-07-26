using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session03.P01Ex1
{
    internal class Circle : ICircle
    {
        public double Area { get; set; }
        public double Radious { get; set; }

        public void DisplayShapeInfo()
        {
            const double PI = Math.PI; 
            Console.WriteLine($"Area Of Circle: {Radious * Radious * PI}");
        }
    }
}
