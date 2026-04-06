using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rougelette
{
    public partial class frmMainMenu : Form
    {
        //DONT TOUCH THIS IDIOTS
        private frmCharacterSelect charSelect;
        private frmRougelette rouge;
        private frmItemShop shop;
        private record SaveData(string Character, int Gold, int Fee, int RoundCount);
        public frmMainMenu()
        {
            //AND THIS
            InitializeComponent();
            rouge = new frmRougelette(this);
            charSelect = new frmCharacterSelect(rouge);
            
            charSelect.Hide();
            rouge.Hide();
        }
        public string Username => txtUser.Text.Trim();
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //grab the username and ensure it doesnt contain any empty spaces
            string userName  = txtUser.Text.Trim();
            if(userName == "")
            {
                MessageBox.Show("Enter a username");
            }
            else
            {
                charSelect.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            charSelect.Close();
            rouge.Close();
            this.Close();
        }
    }
}
