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
    public partial class frmMainMenuNew : Form
    {
        frmMainMenuNew parent;

        public frmMainMenuNew(frmMainMenuNew Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        public frmMainMenuNew()
        {
            InitializeComponent();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStockMenu frmNext = new frmStockMenu(this);
            this.Hide();
            frmNext.Show();
        }

        private void frmMainMenuNew_Load(object sender, EventArgs e)
        {

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSales frmNext = new frmSales(this);
            this.Hide();
            frmNext.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frmNext = new frmCustomer(this);
            this.Hide();
            frmNext.Show();
        }
    }
}
