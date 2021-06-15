using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace CivilApp.Class.SteelColumn
{
    class SteelColumnExample
    {

        public static void AlphacCalculationExample()
        {
            List<UBData> UCXBendingList = SteelColumnInitializer.CreateUCXBendingList();
            List<UCData> UCXBucklingList = SteelColumnInitializer.CreateUCXBucklingList();
            List<UCData> UCYBucklingList = SteelColumnInitializer.CreateUCYBucklingList();
            
            int UCListIndex = 0;
            Console.WriteLine("Calculation for " + UCXBucklingList[UCListIndex].name);

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                double length = Convert.ToDouble(random.Next(0, 1000)) / 100;


                UCObject ucObject = new UCObject(length, UCXBendingList[UCListIndex], UCXBucklingList[UCListIndex], UCYBucklingList[UCListIndex]);
            }
        }

        public static void DemandExample()
        {
            Random random = new Random();
            double length = Convert.ToDouble(random.Next(40, 100)) / 10;
            double UDL = 10;

            double maximumMoment = SimplySupportedBeam.MaximumMoment(UDL, length);
            double maximumShear = SimplySupportedBeam.MaximumShear(UDL, length);
            double axialForce = Convert.ToDouble(random.Next(3000, 10000)) / 10;

            SteelColumnSelector.Solve(length, maximumMoment, axialForce);
            //List<UCObject> UBObjectList = SteelColumnSelector.CreatePassList(length, maximumMoment, axialForce);
        }

        public static void DemandGridExample(DataGridView dataGridView)
        {
            Random random = new Random();

            double length = Convert.ToDouble(random.Next(20, 90)) / 10;
            double maximumMoment = Convert.ToDouble(random.Next(0, 3000)) / 10;
            double axialForce = Convert.ToDouble(random.Next(3000, 20000)) / 10;

            List<UCObject> UCObjectList = SteelColumnSelector.Solve(length, maximumMoment, axialForce);

            Console.WriteLine("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");

            Console.WriteLine("Length:" + length + "m " + "M*:" + maximumMoment + "kN*m N*" + axialForce + "kN\r\n");
            

           dataGridView.ColumnCount = 4;
            dataGridView.Columns[0].Name = "Name";
            dataGridView.Columns[1].Name = "PhiMbx";
            dataGridView.Columns[2].Name = "PhiNcx";
            dataGridView.Columns[3].Name = "PhiNcy";
            foreach (UCObject ucObject in UCObjectList)
            {
                dataGridView.Rows.Add(ucObject.xBendingData.name, ucObject.phiMbx, ucObject.phiNcx, ucObject.phiNcy);
            }
            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        public static void ChartExample(Chart chart)
        {
            SteelColumnChart scChart = new SteelColumnChart(chart);
        }

        public static void DataGridViewExample(DataGridView dataGridView)
        {
            List<UCData> UCList = SteelColumnInitializer.CreateUCXBucklingList();
            dataGridView.ColumnCount = 15;
            dataGridView.Columns[0].Name = "Name";
            dataGridView.Columns[1].Name = "PhiNs";
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
            foreach (UCData uc in UCList)
            {
                dataGridView.Rows.Add(uc.name, uc.phiNs, uc.alphac[0], uc.alphac[1], uc.alphac[2], uc.alphac[3], uc.alphac[4], uc.alphac[5], uc.alphac[6], uc.alphac[7], uc.alphac[8], uc.alphac[9], uc.alphac[10], uc.alphac[11], uc.alphac[12]);
            }

            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public static void DataGridViewBendingExample(DataGridView dataGridView)
        {
            List<UBData> UBList = SteelColumnInitializer.CreateUCXBendingList();
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
    }
}
