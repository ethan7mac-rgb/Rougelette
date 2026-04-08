using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Items
{
    public static class ItemHelper
    {
        public static bool DurCheck(int dur)
        {
            if (dur <= 0)
                return true;
            else
                return false;
        }
<<<<<<< Updated upstream:Rougelette/ItemHelper.cs
=======
        public static bool CoinFlip()
        {
            Random rand = new Random();
            int coinFlip = rand.Next(1);
            switch (coinFlip)
            {
                case 1:
                    return true;
                default:
                    return false;
            }
        }
>>>>>>> Stashed changes:Rougelette/Items/ItemHelper.cs
    }
}
