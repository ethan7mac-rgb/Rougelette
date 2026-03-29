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
            int spinRes;
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
                else
                {
                    RoundCount++;
                    lblRoundCount.Text = RoundCount.ToString();
                    if (selectedChar is Cowboy c)
                    {
                        spinRes = c.Spin();
                        showSpin(spinRes);
                    }
                    if (selectedChar is Pirate p)
                    {
                        spinRes = p.Spin();
                        showSpin(spinRes);
                    }
                    if (selectedChar is Monkey m)
                    {
                        spinRes = m.Spin();
                        showSpin(spinRes);
                    }
                    Bet();
                    lblCoins.Text = gold.ToString();
                    LoseCheck();
                }
            }
            else
            {
                MessageBox.Show("Please place a bet higher than 0");
                return;
            }
            
        }

        private void showSpin(int spinNum)
        {
            lblSpinRes.Text = spinNum.ToString();
            if (spinNum == 0)
                lblSpinResColour.Text = "Green";
            else if (spinNum % 2 == 0)
                lblSpinResColour.Text = "Red";
            else
                lblSpinResColour.Text = "Black";
        }

        private bool LoseCheck()
        {
            if (gold <= 0)
            {
                lblCoins.Text = "0";
                //Change this when we do a design pass
                MessageBox.Show("Its Joever");
                Reset();
                this.Hide();
                mainMenu.Show();
                return true; 
            }
            else
            {    
                return false;
            }

        }

        private void Reset()

        {
            gold = 0;
            fee = 0;
            RoundCount = 0;
            lblSpinRes.Text = "";
            cboColour.Items.Clear();
            cboNum.Items.Clear();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Reset();
            mainMenu.Show();
            this.Hide();
        }
        public void SetChar(Character character)
        {
            int blackCount = 0, redCount = 0, greenCount = 0;
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
            {
                cboNum.Items.Add(num);
                if(num == 0)
                {
                    greenCount++;
                }
                else if(num % 2 == 0)
                {
                    redCount++;
                }
                else
                {
                    blackCount++;
                }
            }
            cboColour.Items.Add($"Green ({greenCount})");
            cboColour.Items.Add($"Red ({redCount})");
            cboColour.Items.Add($"Black ({blackCount})");

        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            shop.ShowDialog();
        }


        private void Bet()
        {
            //Not working if user slects both also need to add a way to not bet on one and bet on another after betting on one first
            int bet = (int)nudBet.Value;
            if (RoundCount % 4 == 0 && RoundCount != 0)
            {
                fee++;
            }
            lblFee.Text = fee.ToString();
            gold = gold - fee;
            int winnings = 0;
            if(cboNum.SelectedIndex != -1)
            {
                if(cboNum.SelectedItem.ToString().ToLower() == lblSpinRes.Text.ToLower())
                {
                    winnings += bet * 3;
                }
                else
                {
                     winnings -= bet; 
                } 
            }
            if(cboColour.SelectedIndex != -1)
            {
                string colourText = cboColour.SelectedItem.ToString();
                string colour = colourText.Split(' ')[0];
                if(colour.ToLower() == lblSpinResColour.Text.ToLower())
                {
                    winnings+=(bet * 2);
                }
                else
                {
                    winnings -= bet;
                }
            }
            gold = gold + winnings;
            lblCoins.Text = gold.ToString();
        }
    }
}
