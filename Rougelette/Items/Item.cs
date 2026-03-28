using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Items
{
    public abstract class Item
    {
        public int Price { get; set; }

        public virtual int Buy(int gold)
        {
            int finalGold = gold - Price;
            if(finalGold < 0)
            {
                return finalGold = gold;
            }
            else
            {
                return finalGold;
            }
        }
    }
}
