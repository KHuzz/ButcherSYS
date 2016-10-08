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
    public partial class frmStockList : Form
    {
        public frmStockList()
        {
            InitializeComponent();
        }

        private void frmStockList_Load(object sender, EventArgs e)
        {
            //display current date on form
            lblDate.Text = DateTime.Today.ToString("dd/MM/yyyy");

            //Fill grid in order of StockNo
          //  FillGrid("StockNo");
        }

 
        private void grdStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strStockID = grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[0].Value.ToString();
        }

     

    }
}
