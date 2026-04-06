using Microsoft.VisualBasic.ApplicationServices;
using Rougelette.Characters;
using Rougelette.Items;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Rougelette
{
    public partial class frmRougelette : Form
    {
        private frmMainMenu mainMenu;
        private List<Item> items = new List<Item>();
        private Character selectedChar;
        public frmRougelette(frmMainMenu main)
        {
            InitializeComponent();
            mainMenu = main;
        }
        private int gold;
        private int fee = 0;
        private int RoundCount = 0;
        //Gross amount of ifs checking for various gold states
        private void btnSpin_Click(object sender, EventArgs e)
        {
            try
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
                    else if (gold - bet >= 0)
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
                        //Check which char is playing
                        if (selectedChar is Cowboy c)
                        {
                            spinRes = c.Spin();
                            showSpin(spinRes);
                        }
                        else if (selectedChar is Pirate p)
                        {
                            spinRes = p.Spin();
                            showSpin(spinRes);
                        }
                        else if (selectedChar is Monkey m)
                        {
                            spinRes = m.Spin();
                            showSpin(spinRes);
                        }

                        Bet(bet);
                        lblCoins.Text = gold.ToString();
                        LoseCheck();
                        HighScoreCheck();
                    }
                }
                else
                {
                    MessageBox.Show("Please place a bet higher than 0");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error With Betting: {ex}");
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
            HighScoreCheck();
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
                if (num == 0)
                {
                    greenCount++;
                }
                else if (num % 2 == 0)
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
            HighScoreSet();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            try
            {
                frmItemShop shop = new frmItemShop(gold);
                shop.ShowDialog();
                gold = shop.gold;
                lblCoins.Text = gold.ToString();
                foreach (Item i in shop.ShoppingList)
                    items.Add(i);
                RepopLst();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening the shop {ex.Message}");
            }
        }

        
        private void Bet(int bet)
        {
            int winnings = 0;
            if (cboNum.SelectedIndex > 0)
            {
                if (cboNum.SelectedItem.ToString().ToLower() == lblSpinRes.Text.ToLower())
                {
                    winnings += bet * 3;
                }
            }
            if (cboColour.SelectedIndex > 0)
            {
                string colourText = cboColour.SelectedItem.ToString();
                string colour = colourText.Split(' ')[0];
                if (colour.ToLower() == lblSpinResColour.Text.ToLower())
                {
                    winnings += (bet * 2);
                }

            }
            gold = gold + winnings;
            lblCoins.Text = gold.ToString();
        }

        private void lstItemDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selItem = lstItemDisplay.SelectedItem;
            if (selItem is ABigSword s)
            {
                gold += s.IWait();
                if (DurCheck(s.Durability))
                    items.Remove(s);
            }
            RepopLst();
        }

        private void RepopLst()
        {
            lstItemDisplay.Items.Clear();
            foreach (Item i in items)
                lstItemDisplay.Items.Add(i);
        }

        private bool DurCheck(int dur)
        {
            if (dur <= 0)
                return true;
            else
                return false;
        }
        private void HighScoreCheck()
        {
            string highScore = "0";
            if (Convert.ToInt32(highScore) < RoundCount)
                highScore = RoundCount.ToString();
            lblHS.Text = highScore;
        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> users = UserCheck();
                string user = mainMenu.Username;
                string path = Path.Combine(Application.StartupPath, "users.txt");

                bool found = false;
                for (int i = 0; i < users.Count; i++)
                {
                    string[] pieces = users[i].Split(" : ");
                    if (pieces[0].ToString().ToLower() == user.ToLower())
                    {
                        users[i] = $"{user} : {lblHS.Text}";
                        File.WriteAllLines(path, users);
                        found = true;
                        return;
                    }
                }

                if (!found)
                {
                    using StreamWriter writer = new StreamWriter(path, true);
                    writer.WriteLine($"{user} : {lblHS.Text}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Saving Highscore {ex.Message}");
            }
        }

        private List<string> UserCheck()
        { 
            List<string> users = new List<string>();
            try
            {
                string user, path;
                user = mainMenu.Username;
                path = Path.Combine(Application.StartupPath, "users.txt");
                using StreamReader reader = new StreamReader(path);
               
                while (reader.EndOfStream == false)
                    users.Add(reader.ReadLine());
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error With Getting All Users {ex.Message}");
            }

            return users;
        }

        private void HighScoreSet()
        {
            try
            {
                List<string> users = UserCheck();
                string user = mainMenu.Username;
                string path = Path.Combine(Application.StartupPath, "users.txt");
                for (int i = 0; i < users.Count; i++)
                {
                    string[] pieces = users[i].Split(" : ");
                    if (pieces[0].ToString().ToLower() == user.ToLower())
                    {
                        lblHS.Text = pieces[1].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Saving Highscore {ex.Message}");
            }
        }
    }
}
