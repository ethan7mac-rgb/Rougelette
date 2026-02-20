using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette
{
    public class Character
    {
        public string Name { get; set; }

        public int StartingMoney { get; set; }

        //Returns and array of numbers for the wheel. Made it virtual so other characters can overload it and change the starting numbers. Ex cowboy character is gonna only have 0 00 and 1-6
        public virtual int[] WheelNums()
        {
            int[] wheelNums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 0, 00 };
            return wheelNums;
        }
    }
}
