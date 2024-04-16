using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_2_2
{
    internal class InchesConverter
    {
        public static readonly double C_RATIO = 0.0254;

        //inches to meter
        public static  double FromMeter(double vMeter)
        {
            return vMeter / C_RATIO;
        }

        //meter to inches
        public static double ToMeter(double vInch)
        {
            return vInch * C_RATIO;
        }
    }
}
