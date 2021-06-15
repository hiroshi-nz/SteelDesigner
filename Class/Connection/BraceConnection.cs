using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CivilApp.Class.Connection.Bolt;
using CivilApp.Class.SteelBeam;

namespace CivilApp.Class.Connection
{
    class BraceConnection
    {
        int numberOfBolts;
        BoltObject bolt;

        double VfDemand;
        double NtfDemand;

        double phiVf;
        double phiNtf;

        double phiNt;

        double angle;

        public BraceConnection(BoltObject bolt, int numberOfBolts, double NtDemand, double angle)
        {
            this.bolt = bolt;
            this.numberOfBolts = numberOfBolts;
            //There is a mistake in the slide. Pry force does not affect shear.
            CalculateDemand(NtDemand, angle);
            this.phiNt = CalculateCapacity(bolt, numberOfBolts);
            Console.WriteLine("Nt*:" + NtDemand + "kN PhiNt:" + MathHelper.Round2dec(this.phiNt/1000) + "kN");
        }

        public void CalculateDemand(double Nt, double angle)
        {
            this.angle = angle;
            VfDemand =  Nt * Math.Sin(angle * Math.PI / 180);
            NtfDemand = Nt * Math.Cos(angle * Math.PI / 180);
            Console.WriteLine("Vf*:" + MathHelper.Round2dec(VfDemand) + "kN Ntf*:" + MathHelper.Round2dec(NtfDemand) + "kN"); 
        }

        private double CalculateCapacity(BoltObject bolt, int numberOfBolts)
        {
            double pryingForce = 1.1;// 10% to 20% for bolt in tension.

            phiVf = (numberOfBolts * bolt.phiVf);
            phiNtf = (numberOfBolts * bolt.phiNtf) / pryingForce;

            Console.WriteLine("PhiVf:" + MathHelper.Round2dec(phiVf / 1000) + "kN PhiNtf:" + MathHelper.Round2dec(phiNtf / 1000) + "kN");

            double ans = CalculateShearAndTensionCombination();
            double phiNt = 0;

            if (ans > 1.0)
            {
                Console.WriteLine(ans + " CombinationCheck not OK");
            }
            else if (phiVf < phiNtf)
            {
                phiNt = phiVf / Math.Sin(angle * Math.PI / 180);
                Console.WriteLine(MathHelper.Round2dec(ans) + " CombinationCheck OK " + "PhiNt:" + MathHelper.Round2dec(phiNt / 1000) + "kN");
            }
            else
            {
                phiNt = phiNtf / Math.Cos(angle * Math.PI / 180);
                Console.WriteLine(MathHelper.Round2dec(ans) + " CombinationCheck OK " + "PhiNt:" + MathHelper.Round2dec(phiNt / 1000) + "kN");
            }

            return phiNt;
        }

        private double CalculateShearAndTensionCombination()
        {
            double ans = Math.Pow(VfDemand / (phiVf/1000), 2) + Math.Pow(NtfDemand / (phiNtf/1000), 2);
            return ans;
        }
    }
}
