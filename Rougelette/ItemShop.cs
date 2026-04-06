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
        public int gold;
        List<Item> shoppingList = new List<Item>();
        public List<Item> ShoppingList => shoppingList;
        public frmItemShop(int inGold)
        {
            InitializeComponent();
            gold = inGold;
        }

        private void btnRouge_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBigSword_Click(object sender, EventArgs e)
        {
            int buyChk = gold;
            ABigSword sword = new ABigSword();
            gold = gold - sword;
            if(gold != buyChk)
            {
                shoppingList.Add(sword);
                btnBigSword.Enabled = false;
            }
            
        }
    }
}
