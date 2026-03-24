using Rougelette.Characters;

namespace Rougelette
{
    public partial class frmRougelette : Form
    {
        private frmMainMenu mainMenu;

        private Character selectedChar;
        public frmRougelette(frmMainMenu main)
        {
            InitializeComponent();
            mainMenu = main;
        }

        int RoundCount = 0;
        int[] WheelNums = [];
        private void btnSpin_Click(object sender, EventArgs e)
        {
            RoundCount++;
            lblRoundCount.Text = RoundCount.ToString();

            Random rand = new Random();
            //rand.Next(WheelNums.Min, WheelNums.Max);
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
            WheelNums = selectedChar.WheelNums();
            MessageBox.Show(WheelNums.ToString());
        }
    }
}
