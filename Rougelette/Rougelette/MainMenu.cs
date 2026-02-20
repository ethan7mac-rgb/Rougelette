using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rougelette
{
    public partial class frmMainMenu : Form
    {
        //DONT TOUCH THIS IDIOTS
        private frmCharacterSelect charSelect;
        private frmRougelette rouge;
        public frmMainMenu()
        {
            //AND THIS
            InitializeComponent();
            rouge = new frmRougelette(this);
            charSelect = new frmCharacterSelect(rouge);
            charSelect.Hide();
            rouge.Hide();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            charSelect.Show();
            this.Hide();
        }
    }
}
