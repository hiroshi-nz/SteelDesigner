using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class.Connection.Bolt
{
    class BoltData
    {
        public string name { get; set; }
        public double As;//Tensile area
        public double Ao;//Shank area
        public double Ac;//Core area

        public BoltData(string name, double As, double Ao, double Ac)
        {
            this.name = name;
            this.As = As;
            this.Ao = Ao;
            this.Ac = Ac;
        }

    }
}
