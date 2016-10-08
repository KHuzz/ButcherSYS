using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;

namespace ButcherSYS
{
    class SaleItem
    {
        int saleIDItems;
        int stockID;
        int qtySold;
        decimal salePrice;
    
        public SaleItem()
        {
            saleIDItems = 0;
            stockID = 0;
            qtySold = 0;
            salePrice = 00.00m;
        
        } // end sale item

        public SaleItem (int SID, int StID,  int QTYS, decimal SP)
            {
             saleIDItems = SID;
                stockID = StID;
                qtySold = QTYS;
                salePrice = SP;
            } // end const.

        //Setters
        public void setSaleID(int SID)
        {
            saleIDItems = SID;
        }
        public void setStockID(int StID)
        {
          stockID = StID;
        }
        public void setQtySold(int QTYS)
        {
            qtySold = QTYS;
        }
        public void setsalePrice(decimal SP)
        {
            salePrice = SP;
        }
  
        //Getters
        public int getSaleID()
        {
            return saleIDItems;
        }
        public int getStockID()
        {
            return stockID;
        }
        public int getQtySold()
        {
            return qtySold;
        }
        public decimal getSalePrice()
        {
            return salePrice;
        }

        public DataSet fillGridCustDetails(String custSur)
        {
            OracleConnection conn = new OracleConnection(DBIT.oradb);

            //define SQL query
            string strSQL = "SELECT * FROM Customer WHERE CustSurname LIKE '" + custSur + "%' ORDER BY CustSurname ";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");

            conn.Close();
            return ds;
        }
        public DataSet fillGridSaleItems(int saleID)
        {
            OracleConnection conn = new OracleConnection(DBIT.oradb);

            //define SQL query
            string strSQL = "SELECT SaleID, StockID, QtySold, SalePrice FROM SaleItems WHERE SaleID =" + saleID ;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");

            conn.Close();
            return ds;
        }
        public void getSaleItems(int saleID)
        {
            OracleConnection conn = new OracleConnection(DBIT.oradb);

            String strSQL = "SELECT * FROM SaleItems WHERE SaleID = " + saleID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            conn.Open();
          

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            saleID = dr.GetInt32(0);
            stockID = dr.GetInt32(1);
            qtySold = dr.GetInt32(2);
            salePrice = dr.GetDecimal(3);

             conn.Close();
        }

        public void insSaleItems()
        {
            //create database connectgion string
            OracleConnection myConn = new OracleConnection(DBIT.oradb);
            /*For example, to reduce stock quantity by the quantity sold in a Table Stock:
            strSQL = "UPDATE Stock SET Qty = Qty - " + Convert.ToInt32(QtySold.text) + " WHERE StockID = " + txtStockID.Text; */
            //defining the SQL query
            String strSQL = "INSERT INTO SaleItems VALUES (" + this.saleIDItems + "," + this.stockID + "," + this.qtySold + ","
                     + this.salePrice + ")";
            //In the above is udating the qty in the Stock table by selecting the stock ID no. not the sale id as indicated.
            //define oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            //open connection
            myConn.Open();
            //excute
            cmd.ExecuteNonQuery();
            //         //close database connection
            myConn.Close();
        } //end insCustomer 

        public int getNextSaleIDItems()
        {
            int intNextSIDItems;

            //ITTralee connection
            OracleConnection myConn = new OracleConnection(DBIT.oradb);

            //Home connection
            // OracleConnection myConnHome = new OracleConnection(DBIT.oradbHome);

            String strSQL = "SELECT MAX(SaleID) FROM SaleItems";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                intNextSIDItems = 1;
            else
                intNextSIDItems = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();
            return intNextSIDItems;
        } // end getNextCustID
    } // end SaleItem
} // end class
