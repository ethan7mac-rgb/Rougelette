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
        //Globals used throughout the form
        private frmCharacterSelect charSelect;
        private frmRougelette rouge;
        public frmMainMenu()
        {
            InitializeComponent();
            //Creating our frms and sending in forms they need
            rouge = new frmRougelette(this);
            charSelect = new frmCharacterSelect(rouge);
            //hide them once made
            charSelect.Hide();
            rouge.Hide();
            CreateTextFile();
        }

        private void CreateTextFile()
        {
            //Creates text file if it doesnt exist
            string path = Path.Combine(Application.StartupPath, "users.txt");
            if (!File.Exists(path))
            {
                using StreamWriter writer = File.CreateText(path);
            }
        }

        //Grab the username from txtUser
        public string Username => txtUser.Text.Trim();
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //Check if user is blank
            if(Username == "")
            {
                MessageBox.Show("Enter a username");
            }
            else
            {
                //If not open charSelect and hide this
                charSelect.Show();
                this.Hide();
            }
        }
        //Closes the forms made when this form is made and this one
        private void btnExit_Click(object sender, EventArgs e)
        {
            charSelect.Close();
            rouge.Close();
            this.Close();
        }
    }
}
