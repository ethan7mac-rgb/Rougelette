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
            //If you cant afford an item it just closes
            if (gold <= 0)
                this.Close();
            //Refresh
            RefreshDisplay();
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
            //Check if you can afford it
            if (gold != buyChk)
            {
                //If you can add it to list
                shoppingList.Add(sword);
            }
            //Refresh
            RefreshDisplay();
        }

        private void btnWheelBuy_Click(object sender, EventArgs e)
        {
            //Make a new wheel and set our buyChk to the gold
            int buyChk = gold;
            Wheels wheel = new Wheels();
            //Sets gold equal to gold - wheel price all checking done in op overload
            gold = gold - wheel;
            //Check if you can afford it
            if (gold != buyChk)
            {
                //If you can add it to list
                Item returnWheel;
                //Determines the wheel you get
                returnWheel = wheel.WheelDetermine();
                shoppingList.Add(returnWheel);
            }
            //Refresh
            RefreshDisplay();
        }

        private void btnExtraMoney_Click(object sender, EventArgs e)
        {
            //Make a new ExtraMoney and set our buyChk to the gold
            int buyChk = gold;
            ExtraMoney money = new ExtraMoney();
            //Sets gold equal to gold - money price all checking done in op overload
            gold = gold - money;
            //Check if you can afford it
            if (gold != buyChk)
            {
                //If you can add it to list
                shoppingList.Add(money);
            }
            //Refresh
            RefreshDisplay();
        }

        private void btnExtraMoney2_Click(object sender, EventArgs e)
        {
            //Make a new ExtraMoney2 and set our buyChk to the gold
            int buyChk = gold;
            ExtraMoney2 money2 = new ExtraMoney2();
            //Sets gold equal to gold - money2 price all checking done in op overload
            gold = gold - money2;
            //Check if you can afford it
            if (gold != buyChk)
            {
                //If you can add it to list
                shoppingList.Add(money2);
            }
            //Refresh
            RefreshDisplay();
        }

        private void btnExtraLife_Click(object sender, EventArgs e)
        {
            //Make a new ExtraLife and set our buyChk to the gold
            int buyChk = gold;
            ExtraLife life = new ExtraLife();
            //Sets gold equal to gold - life price all checking done in op overload
            gold = gold - life;
            //Check if you can afford it
            if (gold != buyChk)
            {
                //If you can add it to list
                shoppingList.Add(life);
            }
            //Refresh
            RefreshDisplay();
        }
        //Helper method for refreshing the display elements
        private void RefreshDisplay()
        {
            lblCoins.Text = gold.ToString();
            lstItems.Items.Clear();
            foreach (Item i in shoppingList)
                lstItems.Items.Add(i);
        }
    }
}
