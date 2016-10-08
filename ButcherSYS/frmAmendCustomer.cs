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
    public partial class frmAmendCustomer : Form
    {
        frmCustomer parent;
        Customer updCust = new Customer();

        public frmAmendCustomer(frmCustomer Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        public frmAmendCustomer()
        {
            InitializeComponent();
        }
       

        public void fillGrid(string sname)
        {
                OracleConnection conn = new OracleConnection(DBIT.oradb);

                //define SQL query
                string strSQL = "SELECT CustId, CustForename, CustSurname, BuisName FROM Customers WHERE CustSurname LIKE '" + sname + "%' ORDER BY CustSurname, CustForename";

                OracleCommand cmd = new OracleCommand(strSQL, conn);
                cmd.CommandType = CommandType.Text;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                grdCustomer.DataSource = ds.Tables["ss"];

        } //end fillGrid


        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
                //reset UI
            grdCustomer.Visible = false;
            grpCustDetails.Visible = false;

            //validate search criteria
            if (txtSearchCustSur.Text.Equals("") && txtCustID.Text.Equals(""))
            {
                MessageBox.Show("Please enter either Customer Surname or Customer ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchCustSur.Focus();
                return;
            }

            if (!txtSearchCustSur.Text.Equals("") && !txtCustID.Text.Equals(""))
            {
                MessageBox.Show("Please enter ONLY Customer Surname or Customer ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchCustSur.Focus();
                return;
            }

            if (!txtCustID.Text.Equals(""))
                displayCustomer(Convert.ToInt32(txtCustID.Text));
            else
            {
                fillGrid(txtSearchCustSur.Text.ToUpper());
                grdCustomer.Visible = true;
            }
        }

        private void grdCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            displayCustomer(Convert.ToInt32(grdCustomer.Rows[grdCustomer.CurrentCell.RowIndex].Cells[0].Value));

        }

        private void frmAmendCustomer_Load(object sender, EventArgs e)
        {

        }
        public void displayCustomer(int custid)
        {
            //int strSID = Convert.ToInt32(grdCustomer.Rows[grdCustomer.CurrentCell.RowIndex].Cells[0].Value);

            //invoke method updCust
            updCust.getCustDetails(custid);

            //load data on form controls
            txtCustID_1.Text = updCust.getCustID().ToString("0000");
            txtCustForeName.Text = updCust.getCustForeName();
            txtCustSurname.Text = updCust.getCustSurName();
            txtBuisName.Text = updCust.getBuisName();
            txtAdd1.Text = updCust.getAdd1();
            txtAdd2.Text = updCust.getAdd2();
            txtAdd3.Text = updCust.getAdd3();
            txtCustP.Text = updCust.getCustP();
            txtCustE.Text = updCust.getCustE();

            grpCustDetails.Visible = true;
        } //end displayCustomer

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           // updCust.setCustID(Convert.ToInt16(txtCustID.Text));
            updCust.setCustForeName(txtCustForeName.Text);
            updCust.setCustSurName(txtCustSurname.Text);
            updCust.setBuisNmae(txtBuisName.Text);
            updCust.setAdd1(txtAdd1.Text);
            updCust.setAdd2(txtAdd2.Text);
            updCust.setAdd3(txtAdd3.Text);
            updCust.setCustP(txtCustP.Text);
            updCust.setCustE(txtCustE.Text);

            //insert data into datatbase
            updCust.updateCustomer();

            //display Confirmation box
            MessageBox.Show("Customer Details Amended", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtSearchCustSur.Text = "";
            txtCustForeName.Text = "";
            txtCustSurname.Text = "";
            txtBuisName.Text = "";
            txtAdd1.Text = "";
            txtAdd2.Text = "";
            txtAdd3.Text = "";
            txtCustP.Text = "";
            txtCustE.Text = "";
            txtCustForeName.Focus();

            //Make grdCustmer and grpCust Invisible
            grdCustomer.Visible = false;
            grpCustDetails.Visible = false;
        }

        private void grdCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }   // end Update

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
