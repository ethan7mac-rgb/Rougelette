using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Characters
{
    public class Character
    {
        private int _min;
        private int _max;
        public string Name { get; set; }

        public int StartingMoney { get; set; }

        public int Min { get { return _min; } set { _min = 0; } }
        public int Max { get { return _max; } set { _max = 36; } }
    }
}
