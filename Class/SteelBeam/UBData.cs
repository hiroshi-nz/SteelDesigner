using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class
{
    class UBData
    {
        public string name { get; set; }
        public double[] effectiveLength = { 1.5, 2.0, 2.5, 3.0, 3.5, 4.0, 4.5, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0 };
        //x-axis bending
        public double phiMsx;//kN*m
        public double[] alphas;
        public double phiVv;//kN

        public UBData(string name, double phiMsx, double[] alphas, double phiVv)
        {
            this.name = name;
            this.phiMsx = phiMsx;
            this.alphas = alphas;
            this.phiVv = phiVv;
        }
    }
}
