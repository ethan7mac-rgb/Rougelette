namespace Rougelette
{
    public partial class frmRougelette : Form
    {
        public frmRougelette()
        {
            InitializeComponent();
        }

        public static object Properties { get; internal set; }

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
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }
    }
}
