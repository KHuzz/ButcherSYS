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
using System.Text.RegularExpressions;

namespace ButcherSYS
{
    public partial class frmAddStock : Form
    {
        frmStockMenu parent;
        Stock newStock = new Stock();
        
        public frmAddStock(frmStockMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        public frmAddStock()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {

            parent.Visible = true;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // validate data
            Regex digitsOnly= new Regex(@"^[A-Z][a-z]+$");
            if (digitsOnly.IsMatch(txtSaleP.Text))
            {
                MessageBox.Show("Please enter didgits only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaleP.Focus();
                return;
            }

            if (txtSaleP.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid Sale Price","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaleP.Focus();
                return;
            }
            Regex charOnly = new Regex(@"^[0-9]*$");

            if (charOnly.IsMatch(txtDesc.Text))
            {
                MessageBox.Show("Please enter characters only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Focus();
                return;
            }
            if (txtDesc.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Focus();
                return;
            }
            if (digitsOnly.IsMatch(txtCostP.Text))
            {
                MessageBox.Show("Please enter digits only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCostP.Focus();
                return;
            }
            if (txtCostP.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid Cost Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCostP.Focus();
                return;
            }
            if (txtTemp.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid Tempature", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTemp.Focus();
                return;
            }
            if (digitsOnly.IsMatch(txtTemp.Text))
            {
                MessageBox.Show("Please enter digits only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTemp.Focus();
                return;
            }
            if (txtBBD.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid Best Before Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBBD.Focus();
                return;
            }
            if (digitsOnly.IsMatch(txtBBD.Text))
            {
                MessageBox.Show("Please enter digits only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBBD.Focus();
                return;
            }
            if (txtBatchNo.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid Batch Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBatchNo.Focus();
                return;
            }
            if (digitsOnly.IsMatch(txtBatchNo.Text))
            {
                MessageBox.Show("Please enter digits only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBatchNo.Focus();
                return;
            }
            if (txtWeightUnitQty.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid Weight/Unit Qty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWeightUnitQty.Focus();
                return;
            }
            if (digitsOnly.IsMatch(txtWeightUnitQty.Text))
            {
                MessageBox.Show("Please enter digits only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWeightUnitQty.Focus();
                return;
            }
            else
            //insert data into Stock Table
            newStock.setSalePrice(Convert.ToDecimal(txtSaleP.Text));
            newStock.setDesc(txtDesc.Text);
            newStock.setCostPrice(Convert.ToDecimal(txtCostP.Text));
            newStock.setTemp(Convert.ToInt16(txtTemp.Text));
            newStock.setBestBD(Convert.ToInt32(txtBBD.Text));
            newStock.setBatchNo(Convert.ToInt16(txtBatchNo.Text));
            newStock.setWeightUnitQty(Convert.ToInt16(txtWeightUnitQty.Text));
            newStock.setStockID(Convert.ToInt16(txtStockID.Text));
            
            //insert data in database
            newStock.insStock();
            
            
            //display confirmation message
            MessageBox.Show("Stock Item Added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
            //reset UI
            txtStockID.Text = newStock.getNextStockID().ToString("0000");
            txtDesc.Text = "";
            txtSaleP.Text = "";
            txtCostP.Text = "";
            txtTemp.Text = "";
            txtBBD.Text = "";
            txtBatchNo.Text = "";
            txtWeightUnitQty.Text = "";
            txtDesc.Focus();
            //this.Close();
        }

        private void txtStockID_Load(object sender, EventArgs e)
        {
            txtStockID.Text = newStock.getNextStockID().ToString("0000");
        }

    

        private void insStock_Load(object sender, EventArgs e)
        {
            
        }


        private void txtStockID_TextChanged(object sender, EventArgs e)
        {
            txtStockID.Text = newStock.getNextStockID().ToString("0000");
        }

        private void frmAddStock_Load(object sender, EventArgs e)
        {
            txtStockID.Text = newStock.getNextStockID().ToString("0000");
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
