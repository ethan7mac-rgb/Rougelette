using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rougelette
{
    public partial class frmCharacterSelect : Form
    {
        private frmRougelette roguelette;
        public frmCharacterSelect(frmRougelette rogue)
        {
            InitializeComponent();
            roguelette = rogue;
        }
        private void btnCowBoySelect_Click(object sender, EventArgs e)
        {
            //Makes the cowboy and sends it to main game feel free to use this as a template for the other characters
            Cowboy cowboy = new Cowboy { Name = "Cowboy", StartingMoney = 6 };
            roguelette.SetChar(cowboy);
            this.DialogResult = DialogResult.OK;
            //Make sure this is called last in any characters button click event otherwise the character wont be made first
            MainGameSwap();
        }
        private void MainGameSwap()
        {
            roguelette.Show();
            this.Hide();
        }
    }
}
