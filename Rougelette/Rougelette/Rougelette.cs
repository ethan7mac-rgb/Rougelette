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
        private void btnSpin_Click(object sender, EventArgs e)
        {
            RoundCount++;
            lblRoundCount.Text = RoundCount.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Hide();
        }

        public void SetChar(Character character)
        {
            selectedChar = character;

            lblCharName.Text = selectedChar.Name;
            lblCoins.Text = selectedChar.StartingMoney.ToString();

        }
    }
}
