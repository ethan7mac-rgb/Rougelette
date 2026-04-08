using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Items
{
    public sealed class ExtraMoney2 : Item
    {
        public ExtraMoney2()
        {
            Name = "Extra Return from Colour";
            Price = 10;
            Durability = 1;
        }
        public int MoneyMoney2()
        {
            Durability--;
            return 1;
        }
    }
}
