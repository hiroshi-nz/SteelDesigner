using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class.SteelColumn
{
    class UCData
    {
        public string name { get; set; }
        public double[] effectiveLength = { 1.5, 2.0, 2.5, 3.0, 3.5, 4.0, 4.5, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0 };
        //y-axis buckling
        public double phiNs;//kN
        public double[] alphac;

        public UCData(string name, double phiNs, double[] alphac)
        {
            this.name = name;
            this.phiNs = phiNs;
            this.alphac = alphac;
        }
    }
}
