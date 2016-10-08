using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;

namespace ButcherSYS
{
    class Sale
    {
        int saleID;
        DateTime saleDate;
        int custID;
        decimal totalSale;

        public Sale()
        {
            saleID = 0;
            saleDate = DateTime.Today;
            custID = 0;
            totalSale = 00.00m;
        } //end sale

        public Sale(int SID, DateTime SD, int CID, decimal TS)
        {
            saleID = SID;
            saleDate = SD;
            custID = CID;
            totalSale = TS;
        }
        //Setters
        public void setSaleID(int SID)
        {
            saleID = SID;
        }
        public void setSaleDate(DateTime SD)
        {
            saleDate = SD;
        }
        public void setCustID(int CID)
        {
            custID = CID;
        }
        public void setTotalSale(decimal TS)
        {
            totalSale = TS;
        } //end Setters

        //Getters
        public int getSaleID()
        {
            return saleID;
        }
        public DateTime getSaleDate()
        {
            return saleDate;
        }
        public int getCustID()
        {
            return custID;
        }
        public decimal getToatlSale()
        {
            return totalSale;
        } // end Getters

        public void insSale()
        {
            //create database connectgion string
            OracleConnection myConn = new OracleConnection(DBIT.oradb);

            //defining the SQL query
            String strSQL = "INSERT INTO Sales VALUES (" + this.saleID  + ",'" + this.saleDate + "',"
                + this.custID+ "," + this.totalSale  +")";

            //define oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            //open connection
            myConn.Open();
            //excute
            cmd.ExecuteNonQuery();
            //close database connection
            myConn.Close();
        } //end insCustomer

        public int getNextSaleID()
        {
            int intNextSID;

            //ITTralee connection
            OracleConnection myConn = new OracleConnection(DBIT.oradb);

            //Home connection
            // OracleConnection myConnHome = new OracleConnection(DBIT.oradbHome);

            String strSQL = "SELECT MAX(SaleID) FROM Sales";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                intNextSID = 1;
            else
                intNextSID = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();
            return intNextSID;
        } // end getNextCustID

        public DataSet fillGridSales(int saleID)
        {
            OracleConnection conn = new OracleConnection(DBIT.oradb);

            //define SQL query
            string strSQL = "SELECT SaleID, SaleDate, CustID, TotalSale FROM Sales WHERE SaleID =" + saleID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");

            conn.Close();
            return ds;
        }

    }
}
