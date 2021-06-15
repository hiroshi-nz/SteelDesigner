using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivilApp.Class.Connection.Bolt
{
    class BoltObject
    {
        public double fuf;//minimum tensile strength in MPa.
        public int nn;
        public int nx;
        public BoltData boltData;

        public double phiVf;//in N
        public double phiNtf;

        public BoltObject(double fuf, int nn, int nx, BoltData boltData)
        {
            this.fuf = fuf;
            this.boltData = boltData;
            this.nn = nn;
            this.nx = nx;
            BoltInShear();
            BoltInTension();

        }

        public BoltObject(double fuf, int nn, int nx, string boltName)//improved version
        {
            List<BoltData> boltList = BoltInitializer.CreateBoltList();
            var boltData = boltList.Find(x => x.name == boltName);

            this.fuf = fuf;
            this.boltData = boltData;
            this.nn = nn;
            this.nx = nx;
            BoltInShear();
            BoltInTension();
        }

        private void BoltInShear()
        {
            double phi = 0.8;
            phiVf = phi * 0.62 * fuf * (nn * boltData.Ac + nx * boltData.Ao);
        }

        private void BoltInTension()
        {
            double phi = 0.8;
            phiNtf = phi * fuf * boltData.As;
        }
    }
}
