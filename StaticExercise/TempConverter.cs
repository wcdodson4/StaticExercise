using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double FahrenheitToCelsius(double ftemp)
        {
            return (ftemp - 32) / 1.8;
        }

        public static double CelsiusToFahrenheit(double ctemp)
        {
            return (ctemp * 1.8) + 32;
        }
    }
}
