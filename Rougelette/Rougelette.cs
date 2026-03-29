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
            int bet = (int)nudBet.Value;
            int spinRes;
            if (nudBet.Value > 0)
            {
                if (nudBet.Value > gold)
                {
                    MessageBox.Show("You cant bet money you dont have");
                    return;
                }
                if (cboNum.SelectedIndex > 0 && cboColour.SelectedIndex > 0)
                {
                    if (gold - (bet * 2) < 0)
                    {
                        MessageBox.Show("Nice try I thought of that exploit");
                        return;
                    }
                    else
                    {
                        gold = gold - bet;
                    }
                }
                else if(gold - bet >= 0)
                {
                    gold = gold - bet;
                }
                if (cboColour.SelectedIndex <= 0 && cboNum.SelectedIndex <= 0)
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
                    
                    Bet(bet);
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
            if (RoundCount % 4 == 0 && RoundCount != 0)
            {
                fee++;
            }
            lblFee.Text = fee.ToString();
            gold = gold - fee;
            lblCoins.Text = gold.ToString();
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
            cboColour.Items.Add("None");
            cboNum.Items.Add("None");
            nudBet.Value = 0;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Reset();
            mainMenu.Show();
            this.Hide();
        }
        public void SetChar(Character character)
        {
            Reset();
            lblFee.Text = fee.ToString();
            lblRoundCount.Text = RoundCount.ToString();
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


        private void Bet(int bet)
        {
            int winnings = 0; 
            if(cboNum.SelectedIndex > 0)
            {
                if(cboNum.SelectedItem.ToString().ToLower() == lblSpinRes.Text.ToLower())
                {
                    winnings += bet * 3;
                }
            }
            if(cboColour.SelectedIndex > 0)
            {
                string colourText = cboColour.SelectedItem.ToString();
                string colour = colourText.Split(' ')[0];
                if(colour.ToLower() == lblSpinResColour.Text.ToLower())
                {
                    winnings+=(bet * 2);
                }

            }
            gold = gold + winnings;
            lblCoins.Text = gold.ToString();
        }
    }
}
