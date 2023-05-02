using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AljabarLibraries
{
    public class quadraticForm
    {
        public static double[] akarKuadrat(double[] kuadrat)
        {
            double a = kuadrat[0];
            double b = kuadrat[1];
            double c = kuadrat[2];
            double[] hasil = new double[2];

            hasil[0] = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            hasil[1] = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            return hasil;
        }
        public static double[] kuadrat(double[] x)
        {
            double a = x[0];
            double b = x[1];
            double[] hasil = new double[3];

            hasil[0] = Math.Pow(a, 2);
            hasil[1] = 2 * a * b;
            hasil[2] = Math.Pow(b, 2);
            return hasil;
        }

    }
}
