namespace Rougelette
{
    public partial class frmRougelette : Form
    {
        public frmRougelette()
        {
            InitializeComponent();
        }

        public static object Properties { get; internal set; }

        private void btnSpin_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            
            main.Show();
            this.Close();
        }
    }
}
