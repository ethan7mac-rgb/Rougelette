using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Characters
{
    public class Cowboy : Character
    {
        public Cowboy()
        {
            Name = "Cowboy";
            StartingMoney = 6;
        }
        public override int[] WheelNums()
        {
            int[0] wheelNums = new int[1, 2, 3, 4, 5, 6, 0, 00];
            return wheelNums;
        } 
    }
}
