using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFormsFoamDartFactorySimulator
{
    internal class CreditsSystem
    {
        private double _updateRate;
        private double _credits;
        public double Credits 
        {
            get
            {
                return _credits;
            }
            set
            {
                if (value > _credits)
                {
                    CreditsTotal += (value - _credits);
                }
                _credits = value;
            }
        }

        public double CreditsTotal { get; set; }
        public List<double> CreditsSumList { get; set; }
        public List<double> CreditsMultList { get; set; }
        public double CreditsRate { get; set; }

        public CreditsSystem(double startingCredits, double updateRate)
        {
            Credits = startingCredits;
            CreditsTotal = Credits;
            CreditsSumList = new List<double>();
            CreditsMultList = new List<double>();
            _updateRate = updateRate;
        }

        private double CreditsSum() { return CreditsSumList.Aggregate((a, c) => a + c); }
        private double CreditsMultiplier() { return (CreditsMultList.Count() > 0) ? CreditsMultList.Aggregate((a, c) => a * c) : 1; }
        public void CreditsUpdate() 
        {
            CreditsRate = CreditsMultiplier() * CreditsSum();
            Credits += 1.0f / _updateRate * CreditsRate; 
        }

    }
}
