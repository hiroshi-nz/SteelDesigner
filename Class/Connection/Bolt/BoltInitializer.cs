using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class.Connection.Bolt
{
    class BoltInitializer
    {
        
        public static List<BoltData> CreateBoltList()
        {
            List<BoltData> boltList = new List<BoltData>();

            BoltData boltData = new BoltData("M12", 84.3, 113, 76.2);//all in mm.
            boltList.Add(boltData);

            boltData = new BoltData("M16", 157, 201, 144);
            boltList.Add(boltData);

            boltData = new BoltData("M20", 245, 314, 225);
            boltList.Add(boltData);

            boltData = new BoltData("M24", 353, 452, 324);
            boltList.Add(boltData);

            boltData = new BoltData("M30", 561, 706, 519);
            boltList.Add(boltData);

            boltData = new BoltData("M36", 817, 1016, 759);
            boltList.Add(boltData);

            return boltList;
        }


    }
}
