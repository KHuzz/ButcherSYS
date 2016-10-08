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
    public partial class frmStockMenu : Form
    {
        frmMainMenuNew parent;
        public frmStockMenu(frmMainMenuNew Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void btnAmendStock_Click(object sender, EventArgs e)
        {
            frmAmendStock frmNext = new frmAmendStock(this);
            this.Hide();
            frmNext.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchStock frmNext = new frmSearchStock(this);
            this.Hide();
            frmNext.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddStock frmNext = new frmAddStock(this);
            this.Hide();
            frmNext.Show();
        }
       }

   
    }
