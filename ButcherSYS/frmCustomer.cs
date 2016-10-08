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
    public partial class frmCustomer : Form
    {

        frmMainMenuNew parent;
        public frmCustomer(frmMainMenuNew Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            frmAddCustomer frmNext = new frmAddCustomer(this);
            this.Hide();
            frmNext.Show();
        }

        private void btnAmendCust_Click(object sender, EventArgs e)
        {
            frmAmendCustomer frmNext = new frmAmendCustomer(this);
            this.Hide();
            frmNext.Show();
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            frmDeleteCustomer frmNext = new frmDeleteCustomer(this);
            this.Hide();
            frmNext.Show();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
