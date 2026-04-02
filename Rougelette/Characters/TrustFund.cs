using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Characters
{
    public class TrustFund : Character
    {
        public TrustFund()
        {
            Name = "TrustFund";
            StartingMoney = 50;
            Min = 0;
            Max = 36;
        }

        public override int Spin()
        {
            Random rand = new Random();
            int rolledNum = rand.Next(Min, Max + 1);
            return rolledNum;
        }
    }
}
