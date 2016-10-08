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
    public partial class frmAmendStock : Form
    {
        frmStockMenu parent;
        Stock updStock = new Stock();

        public frmAmendStock(frmStockMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        public frmAmendStock()
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
            grdProducts.Visible = false;
            grpProduct.Visible = false;
            //validate the search criteria
            if(txtDescSearch.Text.Equals("") & txtStockID.Text.Equals(""))
            {
                MessageBox.Show("Please enter either Description of StockID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescSearch.Focus();
                return;

            }
            if (!txtDescSearch.Text.Equals("") & !txtStockID.Text.Equals(""))
            {
                MessageBox.Show("Please enter either StockID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescSearch.Focus();
                return;
            }
            if (!txtStockID.Text.Equals(""))
                displayStock(Convert.ToInt32(txtStockID.Text));
            else
            {
                fillGrid(txtDescSearch.Text.ToUpper());
  
            }
            //if search by Description
            grdProducts.Visible = true;
            //else search by StockID
            }

        private void frmAmendStock_Load(object sender, EventArgs e)
        {

        }
        public void fillGrid(string description)
        {
               
                grdProducts.DataSource = updStock.findStock(description).Tables["ss"];
                grdProducts.Visible = true;

        } //end fillGrid

        private void grdProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           displayStock(Convert.ToInt32(grdProducts.Rows[grdProducts.CurrentCell.RowIndex].Cells[0].Value));
           grpProduct.Visible = true;
        }

        public void displayStock(int stockID)
        {
            //invoke method updStock
            updStock.getStockDetails(stockID);

            //load data on form controls
            txtStockID.Text = updStock.getStockID().ToString("0000");
            txtDesc.Text = updStock.getDesc().ToString();
            txtBatchNo.Text = updStock.getBatchNo().ToString();
            txtWeightUnitQty.Text = updStock.getWeightUnitQty().ToString();
            txtBBD.Text = updStock.getBestBD().ToString();
            txtTemp.Text = updStock.getTemp().ToString();
            txtCostP.Text = updStock.getCostP().ToString();
            txtSaleP.Text = updStock.getSaleP().ToString();

            grdProducts.Visible = true;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updStock.setStockID(Convert.ToInt32(txtStockID.Text));
            updStock.setDesc(txtDesc.Text);
            updStock.setBatchNo(Convert.ToInt32(txtBatchNo.Text));
            updStock.setWeightUnitQty(Convert.ToInt32(txtWeightUnitQty.Text));
            updStock.setBestBD(Convert.ToInt32(txtBBD.Text));
            updStock.setTemp(Convert.ToInt32(txtTemp.Text));
            updStock.setCostPrice(Convert.ToDecimal(txtCostP.Text));
            updStock.setSalePrice(Convert.ToDecimal(txtSaleP.Text));


            //insert data into database
            updStock.updateStock();

            //display Confirmation message
            MessageBox.Show("Stock Details Amended", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtDescSearch.Text = "";
            txtStockID.Text = "";
            txtDesc.Text = "";
            txtWeightUnitQty.Text = "";
            txtBatchNo.Text = "";
            txtBBD.Text = "";
            txtTemp.Text = "";
            txtCostP.Text = "";
            txtSaleP.Text = "";

            //Make grpProducts and grdProducts Invisible
            grdProducts.Visible = false;
            grpProduct.Visible = false;



        }

     
    }
}
