using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CivilApp.Class.Connection.Bolt;

namespace CivilApp.Class.Connection
{
    class Moment
    {
        public static void Solve()
        {
            double numberOfRows = 2;
            
            string boltName = "M16";
            double crs = 60;
            int numberOfBolts = 8;
            double boltDiameter = 16;
            double height = 380;

            List < BoltData > boltList = BoltInitializer.CreateBoltList();
            var boltData = boltList.Find(x => x.name == boltName);

            
            double a = (numberOfRows* boltData.As)/crs;
            double beff = numberOfBolts * boltDiameter;

            double cyBar = Math.Sqrt(beff / a);
            //double cPlusyBar =  

        }
    }
}
