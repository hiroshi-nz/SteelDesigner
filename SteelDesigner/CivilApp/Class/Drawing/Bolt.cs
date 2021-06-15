using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class.Drawing
{
    class Bolt
    {
        public double diameter;
        public XY xy;

        public Bolt(XY xy, double diameter)
        {
            this.diameter = diameter;
            this.xy = xy;
        }

    }
}
