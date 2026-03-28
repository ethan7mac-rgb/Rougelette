using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Items
{
    public class ABigSword : Item
    {
        public ABigSword()
        {
            Price = 1;
        }
        public void IWait()
        {
            Random rand = new Random();
            int waiting = rand.Next(0, 1000);
            if(waiting == 1000)
            {

            }
        }
    }
}
