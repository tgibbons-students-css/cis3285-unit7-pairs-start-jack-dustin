using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IAccount
    {

        decimal Balance { get; set; }
        int RewardPoints { get; set; }
        void AddTransaction(decimal amount);
        int CalculateRewardPoints(decimal amount);
    }
}
