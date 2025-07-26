using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session03.P01Ex1
{
    internal class Rectangle : IRectangle
    {
        public double Area { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area oF Rectangle: {Width * Length}");
        }
    }
}
