using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using CivilApp.Class.SteelColumn;

namespace CivilApp.Class
{
    class SteelColumnChart
    {
        public SteelColumnChart(Chart chart)
        {
            InitializeChart(chart);
            List<UCData> ucs =  SteelColumnInitializer.CreateUCXBucklingList();
            AddLines(chart, ucs);
        }

        public void InitializeChart(Chart chart)//http://csharpexamples.com/c-chart-control-example/
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Titles.Add("Universal Column");

            chart.ChartAreas["ChartArea1"].AxisY.Interval = 0.1;
        }

        public void AddLines(Chart chart, List<UCData> UCDataList)//http://csharpexamples.com/c-chart-control-example/
        {
            foreach (UCData uc in UCDataList)
            {
                Series series = chart.Series.Add(uc.name);
                series.ChartType = SeriesChartType.Line;

                for (int i = 0; i < uc.effectiveLength.Length; i++)
                {
                    series.Points.AddXY(uc.effectiveLength[i], uc.alphac[i]);
                }
            }
        }     
    }
}
