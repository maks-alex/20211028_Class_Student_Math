using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211028_Class_Student_Math
{
    public static class MathFunctions
    {
        public static double ExpFunction(double x)
        {
            return Math.Exp(x);
        }

        public static double ArcSinFunction(double x)
        {
            return Math.Asin(x);
        }

        public static double DistanceBetweenPoints(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2) + Math.Pow(a.Z - b.Z, 2));
        }

        public static void MatrixTranspose(ref int[,] arr)
        {
            int[,] tmp = new int[arr.GetLength(dimension: 1), arr.GetLength(dimension: 0)];
            for (int i = 0; i < arr.GetLength(dimension: 0); i++)
            {
                for (int j = 0; j < arr.GetLength(dimension: 1); j++)
                {
                    tmp[j, i] = arr[i, j];
                }
            }
            arr = tmp;
        }

    }
}
