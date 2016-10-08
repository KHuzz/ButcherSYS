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
    public partial class frmAddCustomer : Form
    {
        frmCustomer parent;
        Customer newCustomer = new Customer();

        public frmAddCustomer(frmCustomer Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        public frmAddCustomer()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            txtCustID.Text = newCustomer.getNextCustID().ToString("0000");
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //validate data
            if (txtCustForeName.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a valid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustForeName.Focus();
                return;
            }
            if (txtCustSurName.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a valid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustSurName.Focus();
                return;
            }
            if (txtBuisName.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a valid Buisness Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustForeName.Focus();
                return;
            }
            if (txtAdd1.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a valid address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustForeName.Focus();
                return;
            }
            if (txtAdd2.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a valid address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustForeName.Focus();
                return;
            }
            if (txtAdd3.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a valid address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustForeName.Focus();
                return;
            }
            if (txtCustP.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a valid Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustForeName.Focus();
                return;
            }
            if (txtCustE.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a valid E-Mail Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustForeName.Focus();
                return;
            }

            //insert data into Customer Table
            newCustomer.setCustID(Convert.ToInt16(txtCustID.Text));
            newCustomer.setCustForeName(txtCustForeName.Text);
            newCustomer.setCustSurName(txtCustSurName.Text);
            newCustomer.setBuisNmae(txtBuisName.Text);
            newCustomer.setAdd1(txtAdd1.Text);
            newCustomer.setAdd2(txtAdd2.Text);
            newCustomer.setAdd3(txtAdd3.Text);
            newCustomer.setCustP(txtCustP.Text);
            newCustomer.setCustE(txtCustE.Text);

            //insert data into datatbase
            newCustomer.insCustomer();

            //display Confirmation box
            MessageBox.Show("New Customer Added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtCustID.Text = newCustomer.getNextCustID().ToString("0000");
            txtCustForeName.Text = "";
            txtCustSurName.Text = "";
            txtBuisName.Text = "";
            txtAdd1.Text = "";
            txtAdd2.Text = "";
            txtAdd3.Text = "";
            txtCustP.Text = "";
            txtCustE.Text = "";
            txtCustForeName.Focus();

        } //end confirmation

        private void txtCustID_TextChanged(object sender, EventArgs e)
        {
            txtCustID.Text = newCustomer.getNextCustID().ToString("0000");

        }
     
    } //end class
} // end ButcherSYS

