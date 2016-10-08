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
    public partial class frmMainMenu : Form
    {
        frmMainMenu parent;
        public frmMainMenu(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mnuStockNew_Click(object sender, EventArgs e)
        {
           
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock frmNext = new frmStock(this);

            this.Hide();
            frmNext.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmStockmenu_Click(object sender, EventArgs e)
        {

        }

        private void frmSales_Click(object sender, EventArgs e)
        {

        }
    }
}
