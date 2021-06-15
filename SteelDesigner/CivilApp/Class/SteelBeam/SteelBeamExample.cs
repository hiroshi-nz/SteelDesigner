using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;

namespace CivilApp.Class.SteelBeam
{
    class SteelBeamExample
    {
        public static void AlphasCalculationExample()
        {
            List<UBData> UBList = SteelBeamInitializer.CreateUBList();
            int UBListIndex = 0;
            Console.WriteLine("Calculation for " + UBList[UBListIndex].name);

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                double length = Convert.ToDouble(random.Next(0, 1000)) / 100;
                UBObject ubObject = new UBObject(length, UBList[UBListIndex]);
            }
        }

        public static void DataGridViewExample(DataGridView dataGridView)
        {
            List<UBData> UBList = SteelBeamInitializer.CreateUBList();
            dataGridView.ColumnCount = 15;
            dataGridView.Columns[0].Name = "Name";
            dataGridView.Columns[1].Name = "PhiMsx";
            dataGridView.Columns[2].Name = "1.5m";
            dataGridView.Columns[3].Name = "2.0m";
            dataGridView.Columns[4].Name = "2.5m";
            dataGridView.Columns[5].Name = "3.0m";
            dataGridView.Columns[6].Name = "3.5m";
            dataGridView.Columns[7].Name = "4.0m";
            dataGridView.Columns[8].Name = "4.5m";
            dataGridView.Columns[9].Name = "5.0m";
            dataGridView.Columns[10].Name = "6.0m";
            dataGridView.Columns[11].Name = "7.0m";
            dataGridView.Columns[12].Name = "8.0m";
            dataGridView.Columns[13].Name = "9.0m";
            dataGridView.Columns[14].Name = "10.0m";
            foreach (UBData ub in UBList)
            {
                dataGridView.Rows.Add(ub.name, ub.phiMsx, ub.alphas[0], ub.alphas[1], ub.alphas[2], ub.alphas[3], ub.alphas[4], ub.alphas[5], ub.alphas[6], ub.alphas[7], ub.alphas[8], ub.alphas[9], ub.alphas[10], ub.alphas[11], ub.alphas[12]);
            }

            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public static void ChartExample(Chart chart)
        {
            SteelBeamChart sbChart = new SteelBeamChart(chart);
        }

        public static void DemandExample()
        {
            Random random = new Random();
            double length = Convert.ToDouble(random.Next(40, 100)) / 10;
            double UDL = 10;

            double maximumMoment = SimplySupportedBeam.MaximumMoment(UDL, length);
            double maximumShear = SimplySupportedBeam.MaximumShear(UDL, length);

            //SteelBeamSelector.Solve(length, maximumMoment);
            List<UBObject> UBObjectList = SteelBeamSelector.CreatePassList(length, maximumMoment);


        }

        public static void DemandGridExample(DataGridView dataGridView)
        {
            Random random = new Random();
            double length = Convert.ToDouble(random.Next(40, 100)) / 10;
            double UDL = 10;

            double maximumMoment = SimplySupportedBeam.MaximumMoment(UDL, length);

            Console.WriteLine("Length of the beam is " + length + "m " + "and demand is " + maximumMoment + "kN*m");

            List<UBObject> UBObjectList = SteelBeamSelector.CreatePassList(length, maximumMoment);

            dataGridView.ColumnCount = 3;
            dataGridView.Columns[0].Name = "Name";
            dataGridView.Columns[1].Name = "PhiMsx";
            dataGridView.Columns[2].Name = "PhiMbx";
            foreach (UBObject ubObject in UBObjectList)
            {
                dataGridView.Rows.Add(ubObject.ubData.name, ubObject.ubData.phiMsx, ubObject.phiMbx);
            }

            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public static string CreateEquation(UBObject ub)
        {
            string txt = "";
            txt += @"\phi M_{bx}=\alpha_m \times \alpha_s \times \phi M_{sx}";
            //txt += "1.0" + "\times" + ub.effectiveLength + "m \alpha_s" + +;

            return txt;
        }

        public static void DimensionsExample()
        {
            string name = "310UB40.4";

            UBObject ub = new UBObject(5, name);
            ub.SetDimensions(name);
            Console.WriteLine("Depth:" + ub.dimensions.depth + "mm Width:" + ub.dimensions.width + "mm Flange:" + ub.dimensions.flangeThickness + "mm Web:" + ub.dimensions.webThickness + "mm");
   
        }
    }
}
