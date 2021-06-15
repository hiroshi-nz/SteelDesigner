using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class.SteelBeam
{
    class SteelBeamSelector
    {
        public static void Solve(double length, double maximumMoment)
        {

            List<UBData> UBList = SteelBeamInitializer.CreateUBList();
            List<UBObject> UBPassList = new List<UBObject>();
            foreach (UBData ubData in UBList)//Create UB beams with the specified length in different sizes and compare the capacity to the demand.
            {
                Console.WriteLine("Calculation for " + ubData.name);
                UBObject ubObject = new UBObject(length, ubData);
                if (ubObject.phiMbx >= maximumMoment)
                {
                    Console.WriteLine("Capacity " + ubObject.phiMbx + "kN*m >= " + "Demand" + maximumMoment + "kN*m");
                    UBPassList.Add(ubObject);
                }
                else
                {
                    Console.WriteLine("Capacity " + ubObject.phiMbx + "kN*m < " + "Demand" + maximumMoment + "kN*m");
                }
                Console.WriteLine();
            }
            Console.WriteLine("count:" + UBPassList.Count());


            if (UBPassList.Count() == 0)//prevent no element error
            {
                Console.WriteLine("No match");
            }
            else
            {
                FindOptimumBeam(UBPassList);
            }
        }

        public static List<UBObject> CreatePassList(double length, double maximumMoment)
        {
            List<UBData> UBList = SteelBeamInitializer.CreateUBList();
            List<UBObject> UBPassList = new List<UBObject>();
            foreach (UBData ubData in UBList)//Create UB beams with the specified length in different sizes and compare the capacity to the demand.
            {
                UBObject ubObject = new UBObject(length, ubData);
                if (ubObject.phiMbx >= maximumMoment)
                {
                    UBPassList.Add(ubObject);
                }
            }
            return UBPassList;
        }

        public static UBObject FindOptimumBeam(List<UBObject> UBPassList)//it will throw error if empty list is passed, so the list need to be checked beforehand.
        {
                double match = (from x in UBPassList select x.phiMbx).Min();
                int index = UBPassList.FindIndex(x => x.phiMbx == match);
                //Console.WriteLine("match:" + match + "index:" + index);
                Console.WriteLine("Optimum Beam is " + UBPassList[index].ubData.name);
                UBObject ubObject = UBPassList[index];
                return ubObject;
        }
    }
}
