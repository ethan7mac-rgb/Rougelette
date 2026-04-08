using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Items
{
    public sealed class ExtraMoney : Item
    {
        public ExtraMoney()
        {
            Name = "Extra Return from Number";
            Price = 10;
            Durability = 1;
        }
        public int MoneyMoney()
        {
            return 1;
        }
    }
}
