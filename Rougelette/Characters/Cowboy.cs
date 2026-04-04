using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Characters
{
    public sealed class Cowboy : Character
    {
        public Cowboy()
        {
            Name = "Cowboy";
            StartingMoney = 6;
            Min = 0;
            Max = 6;
        }

        public override int Spin()
        {
            Random rand = new Random();
            int rolledNum = rand.Next(Min, Max+1);
            return rolledNum;
        }
    }
}
