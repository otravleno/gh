using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class AlgebraClass
    {
       public static double[] QuadEquation(List<int> list)
    {
        if (list.Count() != 3)
        {
            Console.WriteLine("Error!");
            return new double[0];
        }

        int D = list[1] * list[1] - 4 * list[0] * list[2];
        if (D < 0)
        {
            Console.WriteLine("No Roots");
            return new double[0];
        }
        else if (D == 0)
        {
            Console.WriteLine("One Root:");
            double[] x = new double[1];
            double x1 = -list[1] / 2 * list[0];
            x.Append(x1);
            return x;
        }
        else
        {
            Console.WriteLine("Two Roots:");
            double[] x = new double[2];
            double x1 = -list[1] + Math.Sqrt(D) / 2 * list[0];
            double x2 = -list[1] - Math.Sqrt(D) / 2 * list[0];
            x.Append(x1);
            x.Append(x2);
            return x;
        }
    }
    public static double[] QuadEquation(int[] array)
    {
        if (array.Count() != 3)
        {
            Console.WriteLine("Error!"); return new double[0];
        }
        int D = array[1] * array[1] - 4 * array[0] * array[2]; if (D < 0)
        {
            Console.WriteLine("No Roots");
            return new double[0];
        }
        else if (D == 0)
        {
            Console.WriteLine("One Root:"); double[] x = new double[1];
            double x1 = -array[1] / 2 * array[0]; x.Append(x1);
            return x;
        }
        else
        {
            Console.WriteLine("Two Roots:"); double[] x = new double[2];
            double x1 = -array[1] + Math.Sqrt(D) / 2 * array[0]; double x2 = -array[1] - Math.Sqrt(D) / 2 * array[0];
            x.Append(x1); x.Append(x2);
            return x;
        }
    }



    }
}
