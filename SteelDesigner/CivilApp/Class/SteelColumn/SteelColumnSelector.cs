using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class.SteelColumn
{
    class SteelColumnSelector
    {
        public static List<UCObject> Solve(double length, double maximumMoment, double axialForce)
        {
            List<UCObject> UCPassList = CreatePassList(length, maximumMoment, axialForce);

            Console.WriteLine("count:" + UCPassList.Count());

            if (UCPassList.Count() == 0)//prevent no element error
            {
                Console.WriteLine("No match");
            }
            else
            {
                Console.WriteLine("Not properly implemented!");
                FindOptimumColumnByXBending(UCPassList);
                FindOptimumColumnByXBuckling(UCPassList);
                FindOptimumColumnByYBuckling(UCPassList);
            }
            return UCPassList;
        }


        public static List<UCObject> CreatePassList(double length, double maximumMoment, double axialForce)
        {
            List<UBData> UCXBendingList = SteelColumnInitializer.CreateUCXBendingList();
            List<UCData> UBXBucklingList = SteelColumnInitializer.CreateUCXBucklingList();
            List<UCData> UBYBucklingList = SteelColumnInitializer.CreateUCYBucklingList();
            List<UCObject> UCPassList = new List<UCObject>();

            for(int i = 0; i < UCXBendingList.Count; i++)
            {
                UCObject ucObject = new UCObject(length, UCXBendingList[i], UBXBucklingList[i], UBYBucklingList[i]);
                if (ucObject.phiMbx >= maximumMoment && ucObject.phiNcx >= axialForce && ucObject.phiNcy >= axialForce)
                {
                    Console.WriteLine("This Column is OK");
                    UCPassList.Add(ucObject);
                }
            }

            return UCPassList;
        }
        // These need to be fixed
        public static UCObject FindOptimumColumnByXBending(List<UCObject> UCPassList)//it will throw error if empty list is passed, so the list need to be checked beforehand.
        {
            double match = (from x in UCPassList select x.phiMbx).Min();
            int index = UCPassList.FindIndex(x => x.phiMbx == match);
            //Console.WriteLine("match:" + match + "index:" + index);
            Console.WriteLine("Optimum Column by x-bending is " + UCPassList[index].xBendingData.name);
            UCObject ucObject = UCPassList[index];
            return ucObject;
        }

        public static UCObject FindOptimumColumnByXBuckling(List<UCObject> UCPassList)//it will throw error if empty list is passed, so the list need to be checked beforehand.
        {
            double match = (from x in UCPassList select x.phiNcx).Min();
            int index = UCPassList.FindIndex(x => x.phiNcx == match);
            Console.WriteLine("Optimum Column by x-buckling is " + UCPassList[index].xBucklingData.name);
            UCObject ucObject = UCPassList[index];
            return ucObject;
        }

        public static UCObject FindOptimumColumnByYBuckling(List<UCObject> UCPassList)//it will throw error if empty list is passed, so the list need to be checked beforehand.
        {
            double match = (from x in UCPassList select x.phiNcy).Min();
            int index = UCPassList.FindIndex(x => x.phiNcy == match);
            Console.WriteLine("Optimum Column by y-buckling is " + UCPassList[index].yBucklingData.name);
            UCObject ucObject = UCPassList[index];
            return ucObject;
        }
    }
}
