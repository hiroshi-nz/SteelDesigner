using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class.SteelBeam
{
    class UBObject
    {
        public double length;
        public double effectiveLength;
        public UBData ubData;
        public double alphas;
        public double phiMbx;
        public UBDimensions dimensions;

        public UBObject(double length, UBData ubData)
        {
            double Ke = 1.1;
            double alpham = 1.0;
            this.ubData = ubData;
            this.length = length;
            this.effectiveLength = Ke * length;
            this.alphas = Alphas();
            this.phiMbx = this.alphas * alpham * ubData.phiMsx;
            Console.WriteLine("PhiMbx is " + MathHelper.Round2dec(this.phiMbx) + "KN*m");
        }

        public UBObject(double length, string ubName)
        {
            List<UBData> UBList = SteelBeamInitializer.CreateUBList();
            var ubData = UBList.Find(x => x.name == ubName);

            double Ke = 1.1;
            double alpham = 1.0;
            this.ubData = ubData;
            this.length = length;
            this.effectiveLength = Ke * length;
            this.alphas = Alphas();
            this.phiMbx = this.alphas * alpham * ubData.phiMsx;
            Console.WriteLine("PhiMbx is " + MathHelper.Round2dec(this.phiMbx) + "KN*m");
        }

        public void SetDimensions(string ubName)
        {
            List<UBDimensions> UBList = SteelBeamInitializer.CreateDimensionsList();
            this.dimensions = UBList.Find(x => x.name == ubName);
        }




        public double Alphas()
        {
            double alphas = 0;//if the effective length is over the limit (Le>10m), alphas will be 0.

            Console.WriteLine("The length of the beam is " + length + "m.");
            Console.WriteLine("The effective length of the beam is " + this.effectiveLength + "m.");
            if (this.effectiveLength <= ubData.effectiveLength[0])
            {
                Console.WriteLine("The effective length of the beam is less than " + ubData.effectiveLength[0] + "m.");
                alphas = MathHelper.Interpolate(this.effectiveLength, 0, ubData.effectiveLength[0], 1, ubData.alphas[0]);
                Console.WriteLine("Alpha s value for this beam is " + alphas + ".");
            }
            else if (this.effectiveLength > ubData.effectiveLength[ubData.effectiveLength.Length - 1])
            {
                Console.WriteLine("The effective length of the beam is over the limit.");
            }
            else
            {
                for (int i = 1; i < ubData.effectiveLength.Length; i++)
                {
                    if (this.effectiveLength > ubData.effectiveLength[i - 1] && this.effectiveLength <= ubData.effectiveLength[i])
                    {
                        Console.WriteLine("The effective length of the beam is between " + ubData.effectiveLength[i - 1] + "m and " + ubData.effectiveLength[i] + "m.");
                        alphas = MathHelper.Interpolate(this.effectiveLength, ubData.effectiveLength[i - 1], ubData.effectiveLength[i], ubData.alphas[i - 1], ubData.alphas[i]);
                        Console.WriteLine("Alpha s value for this beam is " + alphas + ".");
                    }
                }
            }
            return alphas;
        }
    }
}
