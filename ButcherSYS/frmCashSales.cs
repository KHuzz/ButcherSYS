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
    public partial class frmCashSales : Form
    {
        frmSales parent;
        Customer updCust = new Customer();
        Stock updStock = new Stock();
        Stock fillGridStockSales = new Stock();
        SaleItem newSaleItem = new SaleItem();
        Sale sale = new Sale();
        

        public frmCashSales(frmSales Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        public frmCashSales()
        {
            InitializeComponent();
        }

        public void fillGrid(string sname)
        {
            OracleConnection conn = new OracleConnection(DBIT.oradb);

            //define SQL query
            string strSQL = "SELECT * FROM Customers WHERE CustSurname LIKE '" + sname + "%' ORDER BY CustSurname ";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "ss");
            conn.Close();
            grdCustDetails.DataSource = ds.Tables["ss"];

            grdCustDetails.Visible = true;

        } //end fillGrid


        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void frmCashSales_Load(object sender, EventArgs e)
        {
            txtSaleID.Text = sale.getNextSaleID().ToString("0000");
            txtSaleItemID.Text = newSaleItem.getNextSaleIDItems().ToString("0000");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //validate search criteria
            if (txtCustSur.Text.Equals(""))
            {
                MessageBox.Show("Please enter Customer Surname ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustSur.Focus();
                return;
            }
            else
            {
                fillGrid(txtCustSur.Text.ToUpper());
            }
           
        } // end btnFind

        private void grdCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            displayCustomer(Convert.ToInt32(grdCustDetails.Rows[grdCustDetails.CurrentCell.RowIndex].Cells[0].Value));

        }
        public void displayCustomer(int custid)
        {
            //invoke method updCust
            updCust.getCustDetails(custid);

            //load data on form controls
            txtCustID.Text = updCust.getCustID().ToString("0000");
            txtCustFore.Text = updCust.getCustForeName();
            txtCustSur1.Text = updCust.getCustSurName();
            txtBuisName.Text = updCust.getBuisName();
            txtAdd1.Text = updCust.getAdd1();
            txtAdd2.Text = updCust.getAdd2();
            txtAdd3.Text = updCust.getAdd3();
            txtCustPhone.Text = updCust.getCustP();
            txtCustEMail.Text = updCust.getCustE();

            grpCustDetails1.Visible = true;
        } //end displayCustomer

        private void grdCustDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            displayCustomer(Convert.ToInt32(grdCustDetails.Rows[grdCustDetails.CurrentCell.RowIndex].Cells[0].Value));
            grpCustDetails.Visible = true;
        }

        private void btnSelectCust_Click(object sender, EventArgs e)
        {
            txtTotalSale.Text = "0.00";
            grpStockDetails.Visible = true;
            grpShopping.Visible = true;
        }

        private void txtFindStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFindStock_Click(object sender, EventArgs e)
        {
            grdStock.Visible = false;
            //validate the search criteria
            if (txtFindStock.Text.Equals(""))
            {
                MessageBox.Show("Please enter Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFindStock.Focus();
                return;

            }
            else
            {
                fillGridStock(txtFindStock.Text.ToUpper());

            }
          
           grdStock.Visible = true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtQty.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid quantity !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQty.Focus();
            }
            else
            {
                lstShopping.Items.Add(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[0].Value.ToString().PadLeft(4, '0') + " " + txtQty.Text.PadLeft(3, '0') + " " + grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[3].Value.ToString().PadLeft(6, '0') + " " +
                   grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[1].Value.ToString().PadLeft(20, ' '));

                txtTotalSale.Text = (Convert.ToDecimal(txtTotalSale.Text) + (Convert.ToDecimal(txtQty.Text) * Convert.ToDecimal(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[3].Value))).ToString();

               // grpShopping.Visible = true;
                txtQty.Clear();
                txtFindStock.Clear();
            }
            grpShopping.Visible = true;
        }
        public void fillGridStock(string description)
        {
            grdStock.DataSource = updStock.fillGridStockSales(description).Tables["ss"];
            grdStock.Visible = true;

        } //end fillGrid

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            String saleDate = DateTime.Now.ToString("dd/MMM/yy");
          
             //insert data into Sales Table
            sale.setSaleID(Convert.ToInt32(txtSaleID.Text));
            sale.setSaleDate(Convert.ToDateTime(saleDate.ToString()));
            sale.setCustID(Convert.ToInt32(txtCustID.Text));
            sale.setTotalSale(Convert.ToDecimal(txtTotalSale.Text));

            sale.insSale();

            //For each item in the basket (list box)
            lstShopping.SelectedIndex = 0;
          //  lstShopping.SelectedItem = 0;
            //Loop to retrive selected items 
           foreach (int i in lstShopping.SelectedIndex.ToString())
            // for (int i = 0; i < lstShopping.Items.Count; i++)
              {
                    //Insert each sale Item into SaleItems Table
                    newSaleItem.setSaleID(Convert.ToInt32(txtSaleID.Text));
                    newSaleItem.setStockID(Convert.ToInt32(lstShopping.Text.Substring(0, 4)));
                    newSaleItem.setQtySold(Convert.ToInt32(lstShopping.Text.Substring(6, 3)));
                    newSaleItem.setsalePrice(Convert.ToDecimal(lstShopping.Text.Substring(10, 5)));

                    newSaleItem.insSaleItems();

                    //defining the SQL query
                    OracleConnection myConn = new OracleConnection(DBIT.oradb);
                    String strSQL1 = "UPDATE Stock SET WeightUnitQty = WeightUnitQty - " + Convert.ToInt32(lstShopping.Text.Substring(6, 3)) + " WHERE StockID = " + (Convert.ToInt32(lstShopping.Text.Substring(0, 4)));
                    //define oracle command
                    OracleCommand cmd = new OracleCommand(strSQL1, myConn);
                    //open connection
                    myConn.Open();
                    //excute
                    cmd.ExecuteNonQuery();
                    //close database connection
                    myConn.Close();

              
               } //end loop

            // MessageBox.Show("Qty is: " + lstShopping.Text.Substring(27, 3));
            //  MessageBox.Show("Price is: " + lstShopping.Text.Substring(31, 5));
            MessageBox.Show("Sale Confirmed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCustSur.Focus();

            txtSaleID.Text = sale.getNextSaleID().ToString("0000");
            grpStockDetails.Visible = false;
            grpShopping.Visible = false;
            grpShopping.Visible = false;
            grpCustDetails1.Visible = false;
            grdCustDetails.Visible = false;
            grdStock.Visible = false;
            lstShopping.Items.Clear();
            return;
        }
    } //end frmCashSales
} //end class

//PadLeft(20,'0')