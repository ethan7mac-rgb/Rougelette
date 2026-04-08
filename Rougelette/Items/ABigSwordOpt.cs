using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rougelette.Items
{
    public partial class frmABigSwordOpt : Form
    {
        public int sel;
        public frmABigSwordOpt()
        {
            InitializeComponent();
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            sel = 1;
            Exit();
        }

        private void btnBoth_Click(object sender, EventArgs e)
        {
            sel = 0;
            Exit();
        }

        private void btnOdds_Click(object sender, EventArgs e)
        {
            sel = 2;
            Exit();
        }
        private void Exit()
        {
            DialogResult= DialogResult.OK;
            Close();
        }
    }
}
