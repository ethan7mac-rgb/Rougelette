using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Items
{
    public sealed class ABigSword : Item
    {
        public int GoldReturn { get; set; }
        public int Odds { get; set; }
        public ABigSword()
        {
            Odds = 500;
            Price = 2;
            Durability = 5;
            Name = "A Giant Sword!";
        }
        public int IWait()
        {
            frmABigSwordOpt opt = new frmABigSwordOpt();
            opt.ShowDialog();
            if (opt.sel == 0)
            {
                UsersSelection();
            }
            else
                UsersSelection(opt.sel);
            return GoldReturn;
        }
        public void UsersSelection(int sel)
        {
            
            switch (sel)
            {
                case 1:
                    Gamble();
                    break;
                case 2:
                    Improve();
                    break;
            }
        }
        //bug here fix later will still call if dur = 1 and make dur -1
        public void UsersSelection()
        {
            Improve();
            Gamble();
        }
        public void Improve()
        {
            Durability--;
            int tempOdd = Odds;
            Odds = Odds / 2;
            if(Odds < 0)
                MessageBox.Show("You have reached the max forge level");
        }
        public void Gamble()
        {
            Durability--;
            Random rand = new Random();
            int wait = rand.Next(1, Odds);
            if (wait == 1)
                GoldReturn = 500;
            else
                GoldReturn = 0;
        }
    }
}
