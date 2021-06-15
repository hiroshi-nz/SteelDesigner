using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class
{
    class SimplySupportedBeam
    {

        public SimplySupportedBeam()
        {

        }

        public static double MaximumShear(double UDL, double length)
        {
            double maximumShear = UDL * length / 2;
            Console.WriteLine("Maximum shear force is " + maximumShear + "kN");
            return maximumShear;
        }

        public static double MaximumMoment(double UDL, double length)
        {
            double maximumMoment =  (UDL * length * length) / 8;
            Console.WriteLine("Maximum bending moment is " + maximumMoment +"kN*m");
            return maximumMoment;
        }

    }
}
