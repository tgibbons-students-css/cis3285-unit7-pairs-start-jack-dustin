using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class NullAccount : IAccount
    {
        public decimal Balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int RewardPoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddTransaction(decimal amount)
        {
            
        }

        public int CalculateRewardPoints(decimal amount)
        {
            return 0;
        }
    }
}
