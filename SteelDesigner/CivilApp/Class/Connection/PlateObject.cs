using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class.Connection
{
    class PlateObject
    {
        public double Ag;// the gross area of the cross section
        public double fy;//the minimum value of yield stress 
        public double kte;//correction factor, check 7.3
        public double An;//the net area of cross section
        public double fu;//tensile strength

        public double phiNt;
        public double phiVb;

        public double height;
        public double thickness;

        public PlateObject(double height, double thickness)
        {
            this.height = height;
            this.thickness = thickness;

            this.fy = 320;
            this.kte = 1.0;
            this.fu = 440;
            

            
            CalculateAg();
            CalculateAn(2, 22);

            CalculatePhiNt();
            CalculatePlyInBearing(20, 29);
        }

        private void CalculateAg()
        {
            Ag = height * thickness;
        }

        public void CalculateAn(int holeNumber, double holeDiameter)//bolt diameter 24mm and less is + 2mm, bolt diameter 30mm and greater is + 3mm
        {
            An = Ag - holeNumber * holeDiameter * thickness;
        }

        private void CalculatePhiNt()
        {
            double phi = 0.9;
            double phiNt1 = phi * Ag * fy;
            double phiNt2 = phi * 0.85 * kte * An * fu;
            Console.WriteLine("PhiNt1:" + phiNt1/1000 + "kN PhiNt2:" + phiNt2/1000 + "kN");

            if(phiNt1 < phiNt2)
            {
                this.phiNt = phiNt1;
            }
            else
            {
                this.phiNt = phiNt2;
            }
        }

        private void CalculatePlyInBearing(double boltDiameter, double ae)//9.3.2.4
        {
            double phi = 0.9;
            double df = boltDiameter;
            double tp = this.thickness;
            double fup = this.fu;
            //ae:distance between edge of hole and edge of plate

            double phiVb1 = phi * 3.2 * df * tp * fup;
            double phiVb2 = phi * ae * tp * fup;

            if(phiVb1 < phiVb2)
            {
                this.phiVb = phiVb1;
            }
            else
            {
                this.phiVb = phiVb2;
            }

            Console.WriteLine("phiVb1:" + phiVb1 / 1000 + "kN phiVb2:" + phiVb2 / 1000 + "kN");

        }
    }
}
