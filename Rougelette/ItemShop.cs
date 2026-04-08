using Rougelette.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rougelette
{
    public partial class frmItemShop : Form
    {
        //Globals
        public int gold;
        List<Item> shoppingList = new List<Item>();
        public List<Item> ShoppingList => shoppingList;
        public frmItemShop(int inGold)
        {
            InitializeComponent();
            //Set this forms gold = to the form opening this gold
            gold = inGold;
        }

        private void btnRouge_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }

        private void btnBigSword_Click(object sender, EventArgs e)
        {
            //Make a new bigsword and set our buyChk to the gold
            int buyChk = gold;
            ABigSword sword = new ABigSword();
            //Sets gold equal to gold - sword price all checking done in op overload
            gold = gold - sword;
            if (gold != buyChk)
            {
                //Add the sword to list and disable the button as you can only buy each item once a game
                shoppingList.Add(sword);
                btnBigSword.Enabled = false;
            }

        }

        private void btnBanana_Click(object sender, EventArgs e)
        {
            int buyChk = gold;
            Banana banana = new Banana();
            gold = gold - banana;
            if (gold != buyChk)
            {
                shoppingList.Add(banana);
                btnBanana.Enabled = false;
            }
        }
    }
}
