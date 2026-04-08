using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Items
{
    public class WheelOfMisfortune : Wheels, IWheelsSpin
    {
        public int WheelSpinRes()
        {
            int res = WheelSpin();
            switch (res)
            {
                //Return -1 fee
                case 1:
                    MessageBox.Show("+1 fee");
                    return 1;
                //Return -2 fee
                case 2:
                    MessageBox.Show("+2 fee");
                    return 2;
                //Return 5 gold
                case 3:
                    MessageBox.Show("-5 gold");
                    return -5;
                //return 100 gold
                case 4:
                    MessageBox.Show("-100 gold!");
                    return -100;
                //Return 1 gold
                case 5:
                    MessageBox.Show("-1 gold");
                    return -1;
                //Return 0 gold
                default:
                    MessageBox.Show("Nothing");
                    return 0;
            }
        }
    }
}
