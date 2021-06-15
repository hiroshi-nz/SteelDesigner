using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using CivilApp.Class.SteelBeam;
using CivilApp.Class.Drawing;

namespace CivilApp.Class.Drawing
{
    class Drawing
    {

        public static void Draw(PictureBox pictureBox)
        {

            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height,
                                        System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);

                DrawingExample.DrawConnection(graphics);
            }
            pictureBox.Image = bitmap;
        }

        public static List<Rectangle> Bolts(XY origin, List<Bolt> boltList)
        {
            List<Rectangle> rectList = new List<Rectangle>();
            foreach(Bolt bolt in boltList)
            {
                Rectangle rect = new Rectangle(new Point(Convert.ToInt32(bolt.xy.x - bolt.diameter / 2), Convert.ToInt32(bolt.xy.y - bolt.diameter / 2)), new Size(Convert.ToInt32(bolt.diameter), Convert.ToInt32(bolt.diameter)));
                rectList.Add(rect);
            }
            return rectList;
        }

        public static Rectangle Plate(XY origin, double width, double height)
        {
            double leftEnd = origin.x - width / 2;
            Rectangle rect = new Rectangle(new Point(Convert.ToInt32(origin.x - width / 2), Convert.ToInt32(origin.y - height / 2)), new Size(Convert.ToInt32(width), Convert.ToInt32(height)));
            return rect;
        }

        public static Rectangle Plate(XY origin, double width, double height, double thickness)
        {
            double leftEnd = origin.x - width / 2;
            Rectangle rect = new Rectangle(new Point(Convert.ToInt32(origin.x - width / 2), Convert.ToInt32(origin.y - height / 2)), new Size(Convert.ToInt32(width), Convert.ToInt32(height)));
            return rect;
        }

        public static Rectangle Beam(XY origin, UBDimensions dimensions, XY offset)
        {
            double width = 500;
            double leftEnd = origin.x - dimensions.width / 2;

            Point point = new Point(Convert.ToInt32(origin.x + offset.x - width / 2), Convert.ToInt32(origin.y + offset.y - dimensions.depth / 2));
            Size size = new Size(Convert.ToInt32(width), Convert.ToInt32(dimensions.depth));
            Rectangle rect = new Rectangle(point, size);
            return rect;
        }

        public static List<Rectangle> Beam(XY origin, UBDimensions dimensions)
        {
            List<Rectangle> rectList = new List<Rectangle>();

            double width = 500;

            Point point = new Point(Convert.ToInt32(origin.x), Convert.ToInt32(origin.y - dimensions.depth / 2));
            Size size = new Size(Convert.ToInt32(width), Convert.ToInt32(dimensions.depth));
            Rectangle beamRect = new Rectangle(point, size);
            rectList.Add(beamRect);

            point = new Point(Convert.ToInt32(beamRect.Left), Convert.ToInt32(beamRect.Top));
            size = new Size(Convert.ToInt32(width), Convert.ToInt32(dimensions.flangeThickness));
            Rectangle rect = new Rectangle(point, size);
            rectList.Add(rect);

            point = new Point(Convert.ToInt32(beamRect.Left), Convert.ToInt32(beamRect.Bottom - dimensions.flangeThickness));
            size = new Size(Convert.ToInt32(width), Convert.ToInt32(dimensions.flangeThickness));
            rect = new Rectangle(point, size);
            rectList.Add(rect);

            return rectList;
        }

        public static List<Rectangle> Column(XY origin, UBDimensions dimensions)
        {
            List<Rectangle> rectList = new List<Rectangle>();

            double height = 500;

            Point point = new Point(Convert.ToInt32(origin.x - dimensions.depth), Convert.ToInt32(origin.y - height/2));
            Size size = new Size(Convert.ToInt32(dimensions.depth), Convert.ToInt32(height));
            Rectangle beamRect = new Rectangle(point, size);
            rectList.Add(beamRect);

            point = new Point(Convert.ToInt32(beamRect.Right - dimensions.flangeThickness), Convert.ToInt32(origin.y - height / 2));
            size = new Size(Convert.ToInt32(dimensions.flangeThickness), Convert.ToInt32(height));
            Rectangle rect = new Rectangle(point, size);
            rectList.Add(rect);

            return rectList;
        }

    }
}
