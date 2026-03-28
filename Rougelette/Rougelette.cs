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
        int RoundCount = 1;
        private void btnSpin_Click(object sender, EventArgs e)
        {
            
            LoseCheck();
            if (nudBet.Value > 0)
            {
                if (nudBet.Value > gold)
                {
                    MessageBox.Show("You cant bet money you dont have");
                    return;
                }
                if(cboColour.SelectedIndex == -1 && cboNum.SelectedIndex == -1)
                {
                    MessageBox.Show("Choose something to bet on");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please place a bet higher than 0");
                return;
            }
            Bet();
            RoundCount++;
            lblRoundCount.Text = RoundCount.ToString();
            if (selectedChar is Cowboy c)
            {
                lblSpinRes.Text = c.Spin().ToString();
            }
        }

        private void LoseCheck()
        {
            if (RoundCount % 4 == 0)
            {
                fee++;
            }
            if (gold - fee <= 0)
            {
                //Change this when we do a design pass
                MessageBox.Show("Its Joever");
                Reset();
                this.Hide();
                mainMenu.Show();
                
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
            IEnumerable<int> nums = Enumerable.Range(selectedChar.Min, selectedChar.Max - selectedChar.Min + 1);
            int[] numsArr = nums.ToArray();
            foreach (int num in numsArr)
                cboNum.Items.Add(num);
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            shop.ShowDialog();
        }


        private void Bet()
        {
         
        }
    }
}
