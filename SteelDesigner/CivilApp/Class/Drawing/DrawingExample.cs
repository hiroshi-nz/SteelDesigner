using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CivilApp.Class.SteelBeam;
using System.Drawing;

namespace CivilApp.Class.Drawing
{
    class DrawingExample
    {
        public static void DrawConnection(Graphics graphics)
        {
            int plateWidth = 100;
            int plateHeight = 250;
           
            int boltDiameter = 16;
            int numberOfBolts = 5;
            int crs = 50;

            List<Rectangle> rectList = new List<Rectangle>();

            XY origin = new XY(100, 200);

            string name = "310UB40.4";
            UBObject ub = new UBObject(5, name);
            ub.SetDimensions(name);

            Rectangle plateRect = Drawing.Plate(origin, plateWidth, plateHeight);

            rectList.Add(plateRect);

            foreach (Rectangle rect in rectList)
            {
                graphics.DrawRectangle(Pens.Black, rect);
            }

            XY beamOrigin = new XY(plateRect.Left, origin.y);
            rectList = Drawing.Beam(beamOrigin, ub.dimensions);

            foreach (Rectangle rect in rectList)
            {
                graphics.DrawRectangle(Pens.Black, rect);
            }

            XY ColumnOrigin = new XY(plateRect.Left, origin.y);
            rectList = Drawing.Column(ColumnOrigin, ub.dimensions);

            foreach (Rectangle rect in rectList)
            {
                graphics.DrawRectangle(Pens.Black, rect);
            }

            List<Bolt> boltList = Bolts.CreateBolts(numberOfBolts, origin, crs, boltDiameter);
            List<Rectangle> circleList = Drawing.Bolts(origin, boltList);

            foreach (Rectangle rect in circleList)
            {
                graphics.DrawEllipse(Pens.Black, rect);
            }

        }
    }
}
