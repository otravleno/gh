using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class GeometryClass
    {
        public static double STriangle(double a, double b)
        {
            return (a * b) / 2;
        }

        public static double Rectangle(double a, double b)
        {
            return a * b;
        }

        public static double Square(double a) 
        {
            return (a * a)* 3.14;
        }

        public static double Circle(double a, double b)
        {
            return a * (b * b);
        }

        public static double Trapeze(double a, double b, double c)
        {
            return (a + b) / 2 * c;
        }

    }

}
