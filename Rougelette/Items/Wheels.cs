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
        //Constructor
        public Wheels()
        {
            Name = "The Wheel";
            Price = 4;
            Durability = 2;
        }
        //S{ins the wheel
        public int WheelSpin()
        {
            Durability--;
            Random rand = new Random();
            return rand.Next(1, 7);
        }
        //Determines the wheel you get
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
