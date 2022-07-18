using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Exercise
{
    public static class Temp_Converter
    {
        public static double FahrenheightToCelsius(double fahrenheight)
        {
            return (fahrenheight - 32) / 1.8;
        }
        public static double CelsiusTorFahrenheight(double celsius)
        {
            return (celsius * 9) / 5 + 32; 
        }
    }
}
