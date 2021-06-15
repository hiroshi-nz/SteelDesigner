using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using CivilApp.Class.SteelBeam;

namespace CivilApp.Class
{
    class SteelBeamChart
    {
        public SteelBeamChart(Chart chart)
        {
            InitializeChart(chart);
            List<UBData> ubs =  SteelBeamInitializer.CreateUBList();
            AddLines(chart, ubs);
        }

        public void InitializeChart(Chart chart)//http://csharpexamples.com/c-chart-control-example/
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Titles.Add("Universal Beam");

            chart.ChartAreas["ChartArea1"].AxisY.Interval = 0.1;
        }

        public void AddLine(Chart chart, UBData ubData)//http://csharpexamples.com/c-chart-control-example/
        {
            Series series = chart.Series.Add(ubData.name);
            series.ChartType = SeriesChartType.Line;

            for (int i = 0; i < ubData.effectiveLength.Length; i++)
            {
                series.Points.AddXY(ubData.effectiveLength[i], ubData.alphas[i]);
            }
        }

        public void AddLines(Chart chart, List<UBData> UBDataList)//http://csharpexamples.com/c-chart-control-example/
        {
            foreach (UBData ub in UBDataList)
            {
                Series series = chart.Series.Add(ub.name);
                series.ChartType = SeriesChartType.Line;

                for (int i = 0; i < ub.effectiveLength.Length; i++)
                {
                    series.Points.AddXY(ub.effectiveLength[i], ub.alphas[i]);
                }
            }
        }

        public void SlendernessReductionFactor10()
        {
            //310UB46.2 x-axis buclking
            double phiNs = 1587;//1587kN
            double[] ac = { 1.0, 0.989, 0.975, 0.961, 0.946, 0.930, 0.914, 0.897, 0.859, 0.816, 0.767, 0.712, 0.653 };
            double phiNt = 1601;//1601kN

        }
        
    }
}
