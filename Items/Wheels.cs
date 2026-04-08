using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Items
{
    public class Wheels : Item
    {
        public Wheels()
        {
            Name = "The Wheel";
            Price = 4;
            Durability = 2;
        }
        public int WheelSpin()
        {
            Durability--;
            Random rand = new Random();
            return rand.Next(1, 7);
        }
        public Item WheelDetermine()
        {
            Wheels wheel;
            bool coin = ItemHelper.CoinFlip();
            if (coin)
            {
                return wheel = new WheelOfFortune();
            }
            else
            {
                return wheel = new WheelOfMisfortune();
            }
        }
    }
}
