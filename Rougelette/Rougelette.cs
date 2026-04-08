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
        //Globals
        private frmMainMenu mainMenu;
        private List<Item> items = new List<Item>();
        private Character selectedChar;
        private int gold;
        private int fee = 0;
        private int RoundCount = 0;
        public frmRougelette(frmMainMenu main)
        {
            InitializeComponent();
            mainMenu = main;
        }
        
        //Gross amount of ifs checking for various gold states
        private void btnSpin_Click(object sender, EventArgs e)
        {
            try
            {
                //set the bet to the users input bet and set up the Spin Results
                int bet = (int)nudBet.Value;
                int spinRes;
                //Makes sure the bet is greater than 0
                if (bet > 0)
                {
                    //Ensures you bet only gold you have
                    if (bet > gold)
                    {
                        MessageBox.Show("You cant bet money you dont have");
                        return;
                    }
                    //Checks if user is double betting on both colour and num
                    if (cboNum.SelectedIndex > 0 && cboColour.SelectedIndex > 0)
                    {
                        //Checks to make sure they can afford both bets
                        if (gold - (bet * 2) < 0)
                        {
                            MessageBox.Show("Nice try I thought of that exploit");
                            return;
                        }
                        //Take the bet away
                        else
                        {
                            gold = gold - (bet*2);
                        }
                    }
                    //Take the bet away
                    else if (gold - bet >= 0)
                    {
                        gold = gold - bet;
                    }
                    //Make sure user bets on something
                    if (cboColour.SelectedIndex <= 0 && cboNum.SelectedIndex <= 0)
                    {
                        MessageBox.Show("Choose something to bet on");
                        return;
                    }
                    else
                    {
                        //Increment round count
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
                        //Call bet
                        Bet(bet);
                        //Refresh gold
                        lblCoins.Text = gold.ToString();
                        //Check both lose and highscore
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
            //Display the spin result to the user
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
            //Checks if we need to up the fee user pays each round
            if (RoundCount % 4 == 0 && RoundCount != 0)
            {
                fee++;
            }
            //Update lbls and gold global
            lblFee.Text = fee.ToString();
            gold = gold - fee;
            lblCoins.Text = gold.ToString();
            //Executes when the user loses
            if (gold <= 0)
            {
                lblCoins.Text = "0";
                MessageBox.Show("You Lost");
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
            //Resets the entire game
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
            //When you go to mainmenu resets this form
            Reset();
            mainMenu.Show();
            this.Hide();
        }
        public void SetChar(Character character)
        {
            //Call reset and check the highscore
            Reset();
            //Update labels
            lblFee.Text = fee.ToString();
            lblRoundCount.Text = RoundCount.ToString();
            int blackCount = 0, redCount = 0, greenCount = 0;
            //Check that you selected a character and sets the selectedChar to the character you picked
            if (character is Character c)
                selectedChar = c;
            else
                MessageBox.Show("Please Select a Character!");
            //Sets up the details filled by character properties
            lblCharName.Text = selectedChar.Name;
            gold = selectedChar.StartingMoney;
            lblCoins.Text = gold.ToString();
            //Get every number between and including the min and max of the character and makes it an array
            IEnumerable<int> nums = Enumerable.Range(selectedChar.Min, selectedChar.Max - selectedChar.Min + 1);
            int[] numsArr = nums.ToArray();
            //Populate the combo box with every number the character has
            foreach (int num in numsArr)
            {
                cboNum.Items.Add(num);
                //Increments the counters for displaying how many of each colour we have
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
            //Update the colour cbo with the colour selections
            cboColour.Items.Add($"Green ({greenCount})");
            cboColour.Items.Add($"Red ({redCount})");
            cboColour.Items.Add($"Black ({blackCount})");
            HighScoreSet();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            try
            {
                //Opens shop and sends in the gold
                frmItemShop shop = new frmItemShop(gold);
                shop.ShowDialog();
                //Makes gold = to shop gold
                gold = shop.gold;
                lblCoins.Text = gold.ToString();
                //Updates the items with whatever was purchased
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
            //Sets up winnings
            int winnings = 0;
            //Check what was bet on nums and/or colour
            if (cboNum.SelectedIndex > 0)
            {
                //Checks if user won and adds it to winnings
                if (cboNum.SelectedItem.ToString().ToLower() == lblSpinRes.Text.ToLower())
                {
                    winnings += (bet * 3);
                }
            }
            if (cboColour.SelectedIndex > 0)
            {
                //Checks if user won and adds it to winnings
                string colourText = cboColour.SelectedItem.ToString();
                string colour = colourText.Split(' ')[0];
                if (colour.ToLower() == lblSpinResColour.Text.ToLower())
                {
                    winnings += (bet * 2);
                }

            }
            //Updates gold
            gold = gold + winnings;
            lblCoins.Text = gold.ToString();
        }

        private void lstItemDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Checks what item was selected
                Item selItem = (Item)lstItemDisplay.SelectedItem;
                if (selItem is ABigSword s)
                {
                    //adds it to gold if the bigsword gamble succeds
                    gold += s.IWait();
                    //Checks the durrability and removes it if its true
                    if (ItemHelper.DurCheck(s.Durability))
                        items.Remove(s);
                }
                //Refresh our list
                RepopLst();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error selecting item {ex}");
            }
        }

        private void RepopLst()
        {
            //Clears the lst and repops it with all the items
            lstItemDisplay.Items.Clear();
            foreach (Item i in items)
                lstItemDisplay.Items.Add(i);
        }
        private void HighScoreCheck()
        {
            //Checks if the roundcount is greater than hs if it is update lblHS
            int highScore = Convert.ToInt32(lblHS.Text);
            if (lblHS.Text == "")
                highScore = 0;
            if (Convert.ToInt32(lblHS.Text) < RoundCount)
                lblHS.Text = RoundCount.ToString();
        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            try
            {
                //Makes a list of users from UserCheck
                List<string> users = UserCheck();
                //Gets the entered user from main menu
                string user = mainMenu.Username;
                //Sets up our path to the text file
                string path = Path.Combine(Application.StartupPath, "users.txt");
                bool exUser = false;
                //Loop through all users
                for (int i = 0; i < users.Count; i++)
                {
                    //Split our data into two sections [0] = Username [1] = Highscore of user
                    string[] pieces = users[i].Split(" : ");
                    //Looking for a user in the text file matching the username entered
                    if (pieces[0].ToString().ToLower() == user.ToLower())
                    {
                        //Makes sure we are only updating the score if its higher
                        if (Convert.ToInt32(lblHS.Text) > Convert.ToInt32(pieces[1]))
                        {
                            users[i] = $"{user} : {lblHS.Text}";
                            File.WriteAllLines(path, users);
                        }
                        //Update bool to indicate we found a matching user
                        exUser = true;
                        return;
                    }
                }
                //Create a new entry in users.txt if we didnt find a matching user
                if (!exUser)
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
            //Create empty list of strings
            List<string> users = new List<string>();
            try
            {
                //Grab username from main menu
                string user = mainMenu.Username;
                //Setup path
                string path = Path.Combine(Application.StartupPath, "users.txt");
                //Read path
                using StreamReader reader = new StreamReader(path);
                //Add all users in users.txt into list
                while (reader.EndOfStream == false)
                    users.Add(reader.ReadLine());
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error With Getting All Users {ex.Message}");
            }
            //Return list
            return users;
        }

        private void HighScoreSet()
        {
            try
            {
                //Grab all users
                List<string> users = UserCheck();
                //Setup user and path
                string user = mainMenu.Username;
                string path = Path.Combine(Application.StartupPath, "users.txt");
                //Loop through all users if you entered the same name as one in the .txt then set the highscore
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
