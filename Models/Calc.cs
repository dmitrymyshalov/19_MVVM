using System;

namespace MVVM.Models
{
    internal static class Calc
    {
        public static double Circumference(double radius) =>
            2 * Math.PI * radius;
    }
}