using Rougelette.Characters;

namespace Rougelette
{
    public partial class frmRougelette : Form
    {
        private frmMainMenu mainMenu;
        private frmItemShop shop;
        private Character selectedChar;
        public frmRougelette(frmMainMenu main, frmItemShop itemShop)
        {
            InitializeComponent();
            mainMenu = main;
            shop = itemShop;
        }
        public int gold;
        private int fee = 0;
        int RoundCount = 0;
        private void btnSpin_Click(object sender, EventArgs e)
        {
            RoundCount++;
            LoseCheck();
            lblRoundCount.Text = RoundCount.ToString();
            if (selectedChar is Cowboy c)
            {
                lblSpinRes.Text = c.Spin().ToString();
            }

        }

        private void LoseCheck()
        {
            if(RoundCount % 4 == 0)
            {
                fee++;
            }
            if (gold - fee <= 0)
            {
                //Change this when we do a design pass
                MessageBox.Show("Its Joever");
                this.Hide();
                mainMenu.Show();
                Reset();
            }
            else
            {
                gold = gold - fee;
                lblCoins.Text = gold.ToString();
            }
                
        }

        private void Reset()
        {
            gold = 0;
            fee = 0;
            RoundCount = 0;
            lblSpinRes.Text = "";
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Reset();
            mainMenu.Show();
            this.Hide();
        }
        public void SetChar(Character character)
        {
            if (character is Character c)
                selectedChar = c;
            else
                MessageBox.Show("Please Select a Character!");

            lblCharName.Text = selectedChar.Name;
            gold = selectedChar.StartingMoney;
            lblCoins.Text = gold.ToString();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            shop.ShowDialog();
        }
    }
}
