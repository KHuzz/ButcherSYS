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
    public partial class frmFinaliseOrders : Form
    {
        frmSales parent;
        public frmFinaliseOrders(frmSales Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void txtOrderNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStockID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnitQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSaleP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkConfirm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkOutStand_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmFinaliseOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
