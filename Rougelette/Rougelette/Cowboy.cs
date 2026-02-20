using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette
{
    public class Cowboy : Character
    {
        public override int[] WheelNums()
        {
            int[] wheelNums = { 1, 2, 3, 4, 5, 6, 0, 00 };
            return wheelNums;
        } 
    }
}
