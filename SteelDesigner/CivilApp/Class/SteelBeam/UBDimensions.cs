using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CivilApp.Class.SteelBeam
{
    class UBDimensions
    {
        public string name;
        public double mass;
        public double depth;
        public double width;
        public double flangeThickness;
        public double webThickness;

        public UBDimensions(string name, double mass, double depth, double width, double flangeThickness, double webThickness)
        {
            this.name = name;
            this.mass = mass;
            this.depth = depth;
            this.width = width;
            this.flangeThickness = flangeThickness;
            this.webThickness = webThickness;
        }
    }
}
