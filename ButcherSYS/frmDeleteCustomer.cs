using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButcherSYS
{
    public partial class frmDeleteCustomer : Form
    {
        frmCustomer parent;
        Customer updCust = new Customer();
        SaleItem sale = new SaleItem();
        Customer deleteCust = new Customer();

        public frmDeleteCustomer(frmCustomer Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        public frmDeleteCustomer()
        {
            InitializeComponent();
        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
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
            grdCust.DataSource = ds.Tables["ss"];

            grdCust.Visible = true;

        } //end fillGrid

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchCust.Text.Equals(""))
            {
                MessageBox.Show("Please enter either Customer Surname ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchCust.Focus();
            }
            else
            {
                fillGrid(txtSearchCust.Text.ToUpper());
                grdCust.Visible = true;
            }
                //reset UI
                txtSearchCust.Clear();
            } //end search

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteCust.deleteCustomer(txtSearchCust.Text);
            MessageBox.Show("Customer Deleted ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            grdCust.Visible = false;
        }

        private void txtSearchCust_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdCust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}