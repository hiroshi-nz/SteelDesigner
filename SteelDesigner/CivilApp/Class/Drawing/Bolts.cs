using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class.Drawing
{
    class Bolts
    {
        public static List<Bolt> CreateBolts(int numberOfBolts, XY origin, double crs, double diameter)
        {
            List<Bolt> bolts = new List<Bolt>();
            //this.numberOfBolts = numberOfBolts;
            //this.origin = origin;

            if (IsOdd(numberOfBolts))
            {
                int cnt = (numberOfBolts - 1) / 2;

                XY xy = new Class.XY(origin.x, origin.y);
                Bolt bolt = new Bolt(xy, 16);
                bolts.Add(bolt);

                for (int i = 1; i <= cnt; i++)
                {
                    double offsetY = crs * i;

                    xy = new Class.XY(origin.x, origin.y - offsetY);
                    bolt = new Bolt(xy, diameter);
                    bolts.Add(bolt);

                    xy = new Class.XY(origin.x, origin.y + offsetY);
                    bolt = new Bolt(xy, diameter);
                    bolts.Add(bolt);
                }
            }
            else
            {
                int cnt = (numberOfBolts) / 2;
                for (int i = 0; i < cnt; i++)
                {
                    double offsetY = crs/2 + crs * i;

                    XY xy = new Class.XY(origin.x, origin.y - offsetY);
                    Bolt bolt = new Bolt(xy, diameter);
                    bolts.Add(bolt);

                    xy = new Class.XY(origin.x, origin.y + offsetY);
                    bolt = new Bolt(xy, diameter);
                    bolts.Add(bolt);
                }
            }
            return bolts;
        }

        

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
