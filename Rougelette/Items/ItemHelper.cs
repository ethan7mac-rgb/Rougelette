using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Items
{
    //Static classs used for items
    public static class ItemHelper
    {
        //Checks the durrability on items
        public static bool DurCheck(int dur)
        {
            if (dur <= 0)
                return true;
            else
                return false;
        }
        //Simulates a coin flip
        public static bool CoinFlip()
        {
            Random rand = new Random();
            int coinFlip = rand.Next(1);
            if (rand.Next(0, 2) != 0)
                return true;
            else
                return false;
        }
    }
}
