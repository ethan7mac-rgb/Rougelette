using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette
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
    }
}
