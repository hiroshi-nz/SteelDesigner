using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CivilApp.Class.Connection.Bolt;

namespace CivilApp.Class.Connection.Bolt
{
    class BoltExample
    {
        
        public static void BoltCalculationExample()
        {
            string txt = "";
            int numberOfBolts = 4;
            List<BoltData> boltList =  BoltInitializer.CreateBoltList();
            BoltObject bolt = new BoltObject(830,1,0, boltList[2]);

            txt += bolt.boltData.name + " " + numberOfBolts + "*PhiVf:" + numberOfBolts * bolt.phiVf/1000 + "kN\r\n";

            PlateObject plate = new PlateObject(155, 16);
            txt += "Ag:" + plate.Ag + "mm2 An:" + plate.An + "mm2 PhiNt" + plate.phiNt / 1000 + "kN " + numberOfBolts + "*PhiVb:" + numberOfBolts * plate.phiVb / 1000 + "kN";

            Console.WriteLine(txt);
        }

        public static void ShankandCoreExample()
        {
            string txt = "";
            int numberOfBolts = 4;
            List<BoltData> boltList = BoltInitializer.CreateBoltList();
            BoltObject bolt = new BoltObject(830, 1, 1, boltList[2]);

            txt += bolt.boltData.name + " " + numberOfBolts + "*PhiVf:" + numberOfBolts * bolt.phiVf / 1000 + "kN\r\n";

            PlateObject plate = new PlateObject(155, 16);
            txt += "Ag:" + plate.Ag + "mm2 An:" + plate.An + "mm2 PhiNt" + plate.phiNt / 1000 + "kN " + numberOfBolts + "*PhiVb:" + numberOfBolts * plate.phiVb / 1000 + "kN";

            Console.WriteLine(txt);
        }

        public static void BraceConnectionExample()
        {
            //BoltObject bolt = new BoltObject(830, 1, 0, "M16");
            BoltObject bolt = new BoltObject(410, 1, 0, "M16");
            //BraceConnection braceConnection = new BraceConnection(bolt, 8, 384, 36.87);

            BraceConnection braceConnection = new BraceConnection(bolt, 8, 200, 36.87);
        }

    }
}
