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
    public partial class frmSales : Form
    {
        frmMainMenuNew parent;

        public frmSales(frmMainMenuNew Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void btnCashSale_Click(object sender, EventArgs e)
        {
            frmCashSales frmNext = new frmCashSales(this);
            this.Hide();
            frmNext.Show();
        }

        private void btnDailyMRev_Click(object sender, EventArgs e)
        {
            frmDailyMonthlyRevenue frmNext = new frmDailyMonthlyRevenue(this);
            frmNext.Show();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {

        }
    }
}
