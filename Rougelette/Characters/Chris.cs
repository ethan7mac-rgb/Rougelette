using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Characters
{
    public sealed class Chris : Character
    {
        public Chris()
        {
            Name = "Chris London";
            StartingMoney = 15;
            Min = 0;
            Max = 16;
        }

        public override int Spin()
        {
            Random rand = new Random();
            int rolledNum = rand.Next(Min, Max + 1);
            return rolledNum;
        }
    }
}
