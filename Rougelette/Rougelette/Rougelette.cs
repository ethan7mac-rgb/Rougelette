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

        int RoundCount = 0;
        private void btnSpin_Click(object sender, EventArgs e)
        {
            //Not working currently pls fix ethan - ethan
            RoundCount++;
            lblRoundCount.Text = RoundCount.ToString();
            if (selectedChar is Cowboy c)
            {
                MessageBox.Show(c.Spin().ToString());
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblCoins.Text = "";
            RoundCount = 0;
            lblCharName.Text = "";
            mainMenu.Show();
            this.Hide();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
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
            lblCoins.Text = selectedChar.StartingMoney.ToString();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            shop.ShowDialog();
        }
    }
}
