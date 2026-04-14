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
            //Set this forms gold = to the form opening this gold and checks it is above 0
            if(inGold > 0)
                gold = inGold; 
            else
                gold = 0;

            if (gold <= 0)
                this.Close();
            lblCoins.Text = gold.ToString();
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
                shoppingList.Add(sword);
            }
            UpdateGold();
        }

        private void btnWheelBuy_Click(object sender, EventArgs e)
        {
            //Make a new wheel and set our buyChk to the gold
            int buyChk = gold;
            Wheels wheel = new Wheels();
            //Sets gold equal to gold - wheel price all checking done in op overload
            gold = gold - wheel;
            if (gold != buyChk)
            {
                Item returnWheel;
                returnWheel = wheel.WheelDetermine();
                shoppingList.Add(returnWheel);
            }
            UpdateGold();
        }

        private void btnExtraMoney_Click(object sender, EventArgs e)
        {
            int buyChk = gold;
            ExtraMoney money = new ExtraMoney();

            gold = gold - money;
            if (gold != buyChk)
            {
                shoppingList.Add(money);
            }
            UpdateGold();
        }

        private void btnExtraMoney2_Click(object sender, EventArgs e)
        {
            int buyChk = gold;
            ExtraMoney2 money2 = new ExtraMoney2();

            gold = gold - money2;
            if (gold != buyChk)
            {
                shoppingList.Add(money2);
            }
            UpdateGold();
        }

        private void btnExtraLife_Click(object sender, EventArgs e)
        {
            int buyChk = gold;
            ExtraLife life = new ExtraLife();

            gold = gold - life;
            if (gold != buyChk)
            {
                shoppingList.Add(life);
            }
            UpdateGold();
        }

        private void UpdateGold()
        {
            lblCoins.Text = gold.ToString();
        }
    }
}
