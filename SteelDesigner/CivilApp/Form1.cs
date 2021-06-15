using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CivilApp.Class;
using CivilApp.Class.SteelBeam;
using CivilApp.Class.SteelColumn;
using CivilApp.Class.Connection.Bolt;
using CivilApp.Class.Connection;
using CivilApp.Class.Drawing;
using System.Windows.Forms.DataVisualization.Charting;


namespace CivilApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Example1 example1 = new Example1();

            //list = new List<XY>();
            // List<XY> list = example1.generateData();

            //CreateChart(chart1, list);

            //SimEq.Solve();
            //Timber timber = new Timber(0.8, 0.6, 0.09, 0.24, 1, 4);
            //Weld.Solve();

            //SteelColumnExample.AlphacCalculationExample();
            SteelColumnExample.ChartExample(chart1);
            SteelColumnExample.DataGridViewExample(dataGridView1);
            //SteelColumnExample.DataGridViewBendingExample(dataGridView1);
            //SteelColumnExample.DemandExample();
            //SteelColumnExample.DemandGridExample(dataGridView1);

            //SteelBeamExample.AlphasCalculationExample();
            //SteelBeamExample.ChartExample(chart1);
            //SteelBeamExample.DemandExample();
            //SteelBeamExample.DemandGridExample(dataGridView1);

            //OfficeHelper.ExportToExcel(dataGridView1);

            //BoltExample.BoltCalculationExample();
            //BoltExample.ShankandCoreExample();

            //oltExample.BraceConnectionExample();
            //WordHelper.ExportToWord();



            //Drawing.Draw(pictureBox1);

            //SkywayCalculation.Solve();

            //PortalFrameCalculation.Solve();
            //PortalFrameCalculation.Dimensions(dataGridView1);

            //PortalFrameExample.SuperMarket();

        }

        private void CreateChart(Chart chart, List<XY> list)//http://csharpexamples.com/c-chart-control-example/
        {
            chart.Series.Clear();
            chart.Titles.Add("my chart");
            

            Series series = chart.Series.Add("d/b");
            series.ChartType = SeriesChartType.Line;
            foreach (XY xy in list)
            {
                series.Points.AddXY(xy.x, xy.y);
            }
        }

        private void columnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SteelColumnExample.ChartExample(chart1);
            SteelColumnExample.DataGridViewExample(dataGridView1);
        }

        private void beamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SteelBeamExample.ChartExample(chart1);
            SteelBeamExample.DemandExample();
        }
    }
}
