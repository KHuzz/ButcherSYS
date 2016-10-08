using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ButcherSYS
{
    public partial class frmSearchStock : Form
    {
         frmStockMenu parent;
        Stock updStock = new Stock();

        public frmSearchStock(frmStockMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        public frmSearchStock()
        {
            InitializeComponent();
        }
        private void FillGrid(string descr)
        {
            grdStock.DataSource = updStock.searchStock(descr).Tables["ss"];
            grdStock.Visible = true;
         }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            grdStock.Visible = false;

            if (txtDescription.Text.Equals("") & txtStockID.Text.Equals(""))
            {
                MessageBox.Show("Please enter either Stock ID or Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }
            if (!txtDescription.Text.Equals("") & !txtStockID.Text.Equals(""))
            {
                MessageBox.Show("Please enter either StockID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                txtDescription.Clear();
                txtStockID.Clear();
                return;
            }
            else
            {
                FillGrid(txtDescription.Text.ToUpper());
            }

            grdStock.Visible = true;
          

        }
        public void displayStock(int stockID)
        {
            updStock.getStockDetails(stockID);
            txtStockID.Text = updStock.getStockID().ToString("0000");
            txtDescription.Text = updStock.getDesc().ToString();

            grdStock.Visible = true;

        }
    }
}
