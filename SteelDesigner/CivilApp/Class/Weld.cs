using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class
{
    class Weld
    {
        public static void Solve()
        {
            FindWeldLength(500000, 0.6, 410, 6); //Demand 500kN, GP Weld, E41XX, Weld Size 6mm
            FindWeldLength(367380, 0.8, 410, 6); //Demand 367.38kN, SP Weld, E41XX, Weld Size 6mm

            double Nt = TensionNSC(300, 900, 900, 440);//150mm * 6mm = 900mm2 Grade300 Steel Plate 
            Console.WriteLine("Tensile Nominal Section Capacity:" + Nt + "N");

            double Nt2 = TensionNSC(400, 900, 900, 450);//From the slide
            Console.WriteLine("Tensile Nominal Section Capacity:" + Nt2 + "N");

        }
        //Looks fine but need to be checked
        public static double TensionNSC(double Ag, double fy, double An, double fu)//Tension Nominal Section Capacity NZS3404 7.2
        {
            //fy the minimum value of yield stress from 2.1.1
            //fu Tensile strength from 2.1.2 
            //Flats and Sections Steel Grade 300 thickness < 11mm, Yield Stress 320MPa, Tensile Strength 440MPa
            //11mm <= thickness < 17mm, Yield Stress 300MPa, Tensile Strength 440MPa
            //17mm < thickness, Yield Stress 280MPa, Tensile Strength 440MPa
            double phi = 0.9;
            double kte = 1.0;

            //lesser of
            double Nt = phi * Ag * fy;
            Console.WriteLine("phi*Ag*fy:" + Nt + "N");
            double Nt2 = phi * 0.85 * kte * An * fu;
            Console.WriteLine("phi*0.85*kte*An*fu:" + Nt2 +"N");

            if(Nt < Nt2)
            {
                return Nt;
            }
            else
            {
                return Nt2;
            }

        }

        public static void FindWeldLength(double demand, double phi, double fuw, double tw)
        {
            double phiVw = Shear(phi, fuw, tw);
            double Lw = demand / phiVw;
            Console.WriteLine("Required Weld Length:" + Math.Round(Lw) + "mm");
        }

        public static void Table()//table similar to Table 8.3 from SESOC Design Guide
        {
            Console.WriteLine("GP E41XX Elextrodes");
            List(0.6, 410, 5, 12);

            Console.WriteLine("GP E48XX Elextrodes");
            List(0.6, 480, 5, 12);

            Console.WriteLine("SP E41XX Elextrodes");
            List(0.8, 410, 5, 12);

            Console.WriteLine("SP E48XX Elextrodes");
            List(0.8, 480, 5, 12);
        }

        public static void List(double phi, double fuw, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine("Weld Size:" + i + "mm");
                Shear(phi, fuw, i);
            }
        }

        public static double Shear(double phi, double fuw, double tw)
        {

            double tt = tw / Math.Sqrt(2); //throat thickness of the weld
            double kr = 1.0; // only for lap, most of the time 1.0

            double phiVw = 0.6 * phi * fuw * tt * kr;
            Console.WriteLine("Weld Shear: " + Math.Round(phiVw) + "N/mm");

            return phiVw;
        }

        public static void Example()
        {
            double phi = 0.6; // for GP
            double fuw = 410;  // weld ultimate strength for E41xx in MPa
            double tw = 6; //size of weld in mm
            double tt = tw / Math.Sqrt(2); //throat thickness of the weld
            double kr = 1.0; // only for lap, most of the time 1.0

            double phiVw = 0.6 * phi * fuw * tt * kr;
            Console.WriteLine("Weld Shear: " + Math.Round(phiVw) + "N/mm");
        }

    }
}
