using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelette.Items
{
    public sealed class ABigSword : Item
    {
        //Props exclusive to ABigSword
        public int GoldReturn { get; set; }
        public int Odds { get; set; }
        //Constructor for ABigSword
        public ABigSword()
        {
            Odds = 500;
            Price = 2;
            Durability = 5;
            Name = "A Giant Sword!";
        }
        public int IWait()
        {
            //Makes a form and opens it
            frmABigSwordOpt opt = new frmABigSwordOpt();
            opt.ShowDialog();
            //Checks the option user slected
            if (opt.sel == 0)
            {
                UsersSelection();
            }
            else
                UsersSelection(opt.sel);
            //Return the gold user most likely didnt gain
            return GoldReturn;
        }
        private void UsersSelection(int sel)
        {
            //Check wether user picked gamble or improve
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
        private void UsersSelection()
        {
            //Check to make sure user could pick both
            if(Durability < 0)
            {
                MessageBox.Show("You dont have enough durrability for both");
            }
            //Call both improve and gamble
            else
            {
                Improve();
                Gamble();
            }
            
        }
        private void Improve()
        {
            //Remove a durability
            Durability--;
            //Improve odds and make sure the odds arent higher than 2
            Odds = Odds / 2;
            if(Odds <= 2)
            {
                MessageBox.Show("You have reached the max forge level");
                Odds = 2;
            }
        }
        private void Gamble()
        {
            //Remove a durability
            Durability--;
            //If user hits one return 500 gold otherwise 0 (Probably gonna change the odds to be more fair for this by adding runner up prizes
            Random rand = new Random();
            int wait = rand.Next(1, Odds);
            if (wait == 1)
                GoldReturn = 500;
            else
                GoldReturn = 0;
        }
    }
}
