using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Items
{
    public sealed class ExtraLife : Item
    {
        public ExtraLife()
        {
            Name = "Extra Chance to Roll";
            Price = 3;
            Durability = 1;
        }
        public int ExtraChance()
        {
            Durability--;
            return 1;
        }
    }
}
