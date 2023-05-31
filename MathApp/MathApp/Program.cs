using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
namespace MathApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GeometryClass.STriangle(5, 5));
            Console.WriteLine(GeometryClass.Rectangle(6, 4));
            Console.WriteLine(GeometryClass.Square(7));   
            Console.WriteLine(GeometryClass.Circle(4, 6));
            Console.WriteLine(GeometryClass.Trapeze(5, 4, 8));

            Console.WriteLine(AlgebraClass.QuadEquation(5, 5));
            Console.ReadKey();

        }
    }
}
