using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CivilApp.Class.SteelColumn;

namespace CivilApp.Class.SteelColumn
{
    class UCObject
    {
        public double length;
        public double bucklingEffectiveLength;
        public double bendingEffectiveLength;

        public UBData xBendingData;
        public UCData xBucklingData;
        public UCData yBucklingData;

        public double alphas;
        public double alphacx;
        public double alphacy;

        public double phiMbx;
        public double phiNcx;
        public double phiNcy;

        public UCObject(double length, UBData xBendingData, UCData xBucklingData, UCData yBucklingData)
        {
            double bucklingKe = 1.0;
            double bendingKe = 1.1;
            double alpham = 1.0;

            this.xBendingData = xBendingData;
            this.xBucklingData = xBucklingData;
            this.yBucklingData = yBucklingData;

            this.length = length;
            this.bendingEffectiveLength = bendingKe * length;
            this.bucklingEffectiveLength = bucklingKe * length;

            this.alphas = Alphas(xBendingData);
            this.alphacx = Alphac(this.xBucklingData);
            this.alphacy = Alphac(this.yBucklingData);

            this.phiMbx = this.alphas * alpham * xBendingData.phiMsx;
            this.phiNcx = this.alphacx * this.xBucklingData.phiNs;
            this.phiNcy = this.alphacy * this.yBucklingData.phiNs;

            Console.WriteLine("Length: " + length + "m");
            Console.WriteLine("Alpha s:" + MathHelper.Round3dec(this.alphas) + " Alpha cx:" + MathHelper.Round3dec(this.alphacx) + " Alpha cy:" + MathHelper.Round3dec(this.alphacy));
            Console.WriteLine("PhiMbx:" + MathHelper.Round2dec(this.phiMbx) + "KN*m PhiNcx:" + MathHelper.Round2dec(this.phiNcx) + "KN PhiNcy:" + MathHelper.Round2dec(this.phiNcy) + "KN\r\n");
        }

        public double Alphac(UCData ucData)
        {
            double alphac = 0;//if the effective length is over the limit (Le>10m), alphas will be 0.
            if (this.bucklingEffectiveLength <= ucData.effectiveLength[0])
            {
                alphac = MathHelper.Interpolate(this.bucklingEffectiveLength, 0, ucData.effectiveLength[0], 1, ucData.alphac[0]);
            }
            else if (this.bucklingEffectiveLength > ucData.effectiveLength[ucData.effectiveLength.Length - 1])
            {
            }
            else
            {
                for (int i = 1; i < ucData.effectiveLength.Length; i++)
                {
                    if (this.bucklingEffectiveLength > ucData.effectiveLength[i - 1] && this.bucklingEffectiveLength <= ucData.effectiveLength[i])
                    {
                        alphac = MathHelper.Interpolate(this.bucklingEffectiveLength, ucData.effectiveLength[i - 1], ucData.effectiveLength[i], ucData.alphac[i - 1], ucData.alphac[i]);
                    }
                }
            }
            return alphac;
        }

        public double Alphas(UBData ubData)
        {
            double alphas = 0;//if the effective length is over the limit (Le>10m), alphas will be 0.
            if (this.bendingEffectiveLength <= ubData.effectiveLength[0])
            {
                alphas = MathHelper.Interpolate(this.bendingEffectiveLength, 0, ubData.effectiveLength[0], 1, ubData.alphas[0]);
            }
            else if (this.bendingEffectiveLength > ubData.effectiveLength[ubData.effectiveLength.Length - 1])
            {
            }
            else
            {
                for (int i = 1; i < ubData.effectiveLength.Length; i++)
                {
                    if (this.bendingEffectiveLength > ubData.effectiveLength[i - 1] && this.bendingEffectiveLength <= ubData.effectiveLength[i])
                    {
                        alphas = MathHelper.Interpolate(this.bendingEffectiveLength, ubData.effectiveLength[i - 1], ubData.effectiveLength[i], ubData.alphas[i - 1], ubData.alphas[i]);
                    }
                }
            }
            return alphas;
        }


    }
}
