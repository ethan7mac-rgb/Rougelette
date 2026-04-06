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
        public string Name { get; set; }
        public int Price { get; set; }

        public int Durability { get; set; }

        //Ex of implementation int finalGold = gold - selectedItem;
        public static int operator -(int gold, Item item)
        {
            int finalGold = gold - item.Price;
            if (finalGold < 0)
            {
                MessageBox.Show("Not enough to buy this gold!");
                return gold;
            }
            return finalGold;
        }
    }
}
