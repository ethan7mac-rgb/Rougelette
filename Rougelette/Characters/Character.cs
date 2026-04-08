using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Characters
{
    public abstract class Character
    {
        //Props for all characters
        public string Name { get; set; }

        public int StartingMoney { get; set; }

        public int Min { get; set; } = 0;
        public int Max { get; set; } = 36;
        //Abstract method to get our random int we roll (Check cowboy for example of implementation in derived class)
        public abstract int Spin();
    }
}
