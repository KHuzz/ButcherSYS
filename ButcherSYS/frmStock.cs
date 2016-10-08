using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButcherSYS
{
    public partial class frmStock : Form
    {

        frmMainMenu parent;
        public frmStock(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {

        }

        private void btnAmendStock_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchStock_Click(object sender, EventArgs e)
        {

        }
     }


}
