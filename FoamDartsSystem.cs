using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFormsFoamDartFactorySimulator
{
    internal class FoamDartsSystem
    {
        private ulong _foamDarts;
        public ulong FoamDarts
        {
            get
            {
                return _foamDarts;
            }
            set
            {
                if (value > _foamDarts)
                {
                    FoamDartsTotal += (value - _foamDarts);
                }
                _foamDarts = value;
            }
        }
        public ulong FoamDartsTotal { get; set; }
        public List<ulong> FoamDartsSumList { get; set; }
        public List<double> FoamDartsMultList { get; set; }

        public FoamDartsSystem()
        {
            FoamDarts = 0;
            FoamDartsTotal = FoamDarts;
            FoamDartsSumList = new List<ulong>();
            FoamDartsMultList = new List<double>();
        }

        private ulong FoamDartsSum() { return FoamDartsSumList.Aggregate((a, c) => a + c); }
        private double FoamDartsMultiplier() { return (FoamDartsMultList.Count() > 0) ? FoamDartsMultList.Aggregate((a, c) => a * c) : 1; }
        public void FoamDartsUpdate() { FoamDarts += (ulong)(FoamDartsMultiplier() * FoamDartsSum()); }
    }
}
