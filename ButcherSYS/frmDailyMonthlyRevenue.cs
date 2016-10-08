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
    public partial class frmDailyMonthlyRevenue : Form
    {
        frmSales parent;
        SaleItem saleItems = new SaleItem();
        Sale sale = new Sale();

        public frmDailyMonthlyRevenue(frmSales Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        public frmDailyMonthlyRevenue()
        {
             InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void btnTotalSales_Click(object sender, EventArgs e)
        {
          
            grpTotalSale.Visible = true;
        }

        private void btnSaleItems_Click(object sender, EventArgs e)
        {
         
            grpSaleItems.Visible = true;
        }

        private void grdViewSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnSTotalSale_Click(object sender, EventArgs e)
        {
            if (txtSaleID.Text.Equals(""))
            {
                MessageBox.Show("Please enter SaleID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaleID.Focus();
                return;
            }
            else
            {
                displaySaleItems(Convert.ToInt32(txtSaleID.Text));
            }
            grdViewSales.Visible = true;
            grdViewSales.Visible = true;
        }

        public void displaySales(int stockID)
        {
            grdViewSales.Visible = true;
        } //end displaySales
        public void fillGridSaleItems(int saleID)
        {
            grdViewSales.DataSource = saleItems.fillGridSaleItems(saleID).Tables["ss"];
            grdViewSales.Visible = true;

        } //end fillGrid
        public void displaySaleItems(int saleID)
        {
            grdViewSales.DataSource = sale.fillGridSales(saleID).Tables["ss"];
            grdViewSales.Visible = true;
               
        }

        private void btnSSaleItem_Click(object sender, EventArgs e)
        {
            if (txtSaleItemID.Text.Equals(""))
            {
                MessageBox.Show("Please enter either SaleID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaleID.Focus();
                return;
            }
            else
            {
                fillGridSaleItems(Convert.ToInt32(txtSaleItemID.Text));
            }
            grdViewSales.Visible = true;

        }

    }
 }

