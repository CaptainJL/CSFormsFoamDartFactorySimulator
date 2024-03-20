using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFormsFoamDartFactorySimulator
{
    internal class CreditsSystem
    {
        private ulong _credits;
        public ulong Credits 
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
        public ulong CreditsTotal { get; set; }
        public List<ulong> CreditsSumList { get; set; }
        public List<double> CreditsMultList { get; set; }

        public CreditsSystem(ulong startingCredits)
        {
            Credits = startingCredits;
            CreditsTotal = Credits;
            CreditsSumList = new List<ulong>();
            CreditsMultList = new List<double>();   
        }

        private ulong CreditsSum() { return CreditsSumList.Aggregate((a, c) => a + c); }
        private double CreditsMultiplier() { return (CreditsMultList.Count() > 0) ? CreditsMultList.Aggregate((a, c) => a * c) : 1; }
        public void CreditsUpdate() { Credits += (ulong)(CreditsMultiplier() * CreditsSum()); }

    }
}
