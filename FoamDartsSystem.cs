using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFormsFoamDartFactorySimulator
{
    internal class FoamDartsSystem
    {
        private double _updateRate;
        private double _foamDarts;
        public double FoamDarts
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

        public double FoamDartsTotal { get; set; }
        public List<double> FoamDartsSumList { get; set; }
        public List<double> FoamDartsMultList { get; set; }
        public double FoamDartsRate { get; set; }

        public FoamDartsSystem(double updateRate)
        {
            FoamDarts = 0;
            FoamDartsTotal = FoamDarts;
            FoamDartsSumList = new List<double>();
            FoamDartsMultList = new List<double>();
            _updateRate = updateRate;
        }

        private double FoamDartsSum() { return FoamDartsSumList.Aggregate((a, c) => a + c); }
        private double FoamDartsMultiplier() { return (FoamDartsMultList.Count() > 0) ? FoamDartsMultList.Aggregate((a, c) => a * c) : 1; }
        public void FoamDartsUpdate() 
        {
            FoamDartsRate = FoamDartsMultiplier() * FoamDartsSum();
            FoamDarts += 1.0f / _updateRate * FoamDartsRate; 
        }
    }
}
