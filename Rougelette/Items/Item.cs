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
        //Props for all items
        public string Name { get; set; }
        public int Price { get; set; }

        public int Durability { get; set; }

        //Operator overload for - 
        //Ex of implementation int gold = gold - selectedItem;
        public static int operator -(int gold, Item item)
        {
            //Sets finalGold that we send out = to gold we get in - item price
            int finalGold = gold - item.Price;
            //Checks to make sure user can afford item
            if (finalGold < 0)
            {
                //If not mbox and return gold sent in
                MessageBox.Show("Not enough to buy this gold!");
                return gold;
            }
            //Send out the finalGold
            return finalGold;
        }
        //Override toString to display item name and durability
        public override string ToString()
        {
            return $"{Name} Durability: {Durability}";
        }
    }
}
