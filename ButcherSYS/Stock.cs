using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using ButcherSYS;

namespace ButcherSYS
{

    class Stock
    {
        int stockID; //StockID
        string desc; //Stock Description
        int batchNo; //Batch No.
        int weightUnitQty; //Weight Unit Qty
        int bestBD; //Best Before date
        int temp; //Tempature
        decimal costPrice; //CostPrice
        decimal salePrice; //SalePrice

        public Stock()
        {
            stockID = 0;
            desc = "";
            weightUnitQty = 0;
            batchNo = 0;
            bestBD =0;
            temp = 0;
            costPrice = 00.00m;
            salePrice = 00.00m;
        }

        public Stock(int SID,string DES, int WUQ, int BN, int BBD, int TEM, decimal CP, decimal SP)
        {
            stockID = SID;
            desc = DES;
            weightUnitQty = WUQ;
            batchNo = BN;
            bestBD = BBD;
            temp = TEM;
            costPrice = CP;
            salePrice = SP;
        }

        //Setters
        public void setStockID(int SID)
        {
            stockID = SID;
        }
        public void setDesc(string DES)
        {
            desc = DES;
        }
        public void setWeightUnitQty(int WUQ)
        {
            weightUnitQty = WUQ;
        }
        public void setBatchNo(int BN)
        {
            batchNo = BN;
        }

        public void setBestBD(int BBD)
        {
            bestBD = BBD;
        }
        public void setTemp(int TEM)
        {
            temp = TEM;
        }
        public void setCostPrice(decimal CP)
        {
            costPrice = CP;
        }
        public void setSalePrice(decimal SP)
        {
            salePrice = SP;
        }
        //Getters
        public int getStockID()
        {
            return stockID;
        }
        public string getDesc()
        {
            return desc;
        }
        public int getWeightUnitQty()
        {
            return weightUnitQty;
        }
        public int getBatchNo()
        {
            return batchNo;
        }
        public int getBestBD()
        {
            return bestBD;
        }
        public int getTemp()
        {
            return temp;
        }
        public decimal getCostP()
        {
            return costPrice;
        }
        public decimal getSaleP()
        {
            return salePrice;
        }
        
        

        public int getNextStockID()
        {
            int intNextSID;

            //ITTralee connection
            OracleConnection myConn = new OracleConnection(DBIT.oradb);

            //Home connection
            //OracleConnection myConnHome = new OracleConnection(DBIT.oradbHome);

           String strSQL = "SELECT MAX(StockID) FROM Stock";

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
} //end getNextStockID


        public void getStockDetails(int sno)
        {
            //ITTralee connection
            OracleConnection myConn = new OracleConnection(DBIT.oradb);

            //Home connection
            // OracleConnection myConnHome = new OracleConnection(DBIT.oradbHome);

            string strSQL = "SELECT * FROM Stock WHERE StockID LIKE " + sno + "%"; 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            stockID = dr.GetInt32(0);
            desc = dr.GetString(1);
            weightUnitQty = dr.GetInt32(2);
            batchNo = dr.GetInt32(3);
            bestBD = dr.GetInt32(4);
            temp = dr.GetInt32(5);
            costPrice = dr.GetDecimal(6);
            salePrice = dr.GetDecimal(7);

            myConn.Close();

        }

        public void insStock()
        {
            //create database connectgion string
            OracleConnection myConn = new OracleConnection(DBIT.oradb);
            
            //OracleConnection myConnHome = new OracleConnection(DBIT.oradbHome);

            //defining the SQL query
            String strSQL = "INSERT INTO Stock VALUES (" + this.stockID + ",'" + this.desc.ToUpper() + "'," + this.weightUnitQty + "," +
                this.batchNo + ",'" + this.bestBD + "'," + this.temp + "," +
                this.costPrice + "," + this.salePrice + ")";

            //define oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            //open connectin
            myConn.Open();
            //excute
            cmd.ExecuteNonQuery();
            //close datatbase connection
            myConn.Close();
        }

        public void updateStock()
        {
            //create database connectgion string
            OracleConnection myConn = new OracleConnection(DBIT.oradb);

            //defining the SQL query

            // Need to update the selected customer details with a sql statment 30-3-16
            //defining the SQL query
            String strSQL = "UPDATE Stock SET Description = '" + this.desc.ToUpper() + "', WeightUnitQty = " + this.weightUnitQty + ", BatchNo = " +
                this.batchNo + ", BestBeforeDate = '" + this.bestBD + "', Temp = " + this.temp + ", CostPrice = " + this.costPrice + ", SalePrice = " + this.salePrice +
                " WHERE StockID = " + this.stockID;

            //define oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            //open connection
            myConn.Open();
            //excute
            cmd.ExecuteNonQuery();
            //close database connection
            myConn.Close();
        }

        public DataSet searchStock(String allstock)
        {
            OracleConnection conn = new OracleConnection(DBIT.oradb);

            //define SQL query
            string strSQL = "SELECT * FROM Stock WHERE Description LIKE '" + allstock +  "%' ";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");

            conn.Close();
            return ds;
        }

        public DataSet fillGridStockSales(String stockSales)
        {
            OracleConnection conn = new OracleConnection(DBIT.oradb);

            //define SQL query
            string strSQL = "SELECT StockID, Description, WeightUnitQty, SalePrice FROM Stock WHERE Description LIKE  '" + stockSales + "%' ";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");

            conn.Close();
            return ds;
        }

        public DataSet findStock(String descrip)
        {
            OracleConnection conn = new OracleConnection(DBIT.oradb);

            //define SQL query
            string strSQL = "SELECT StockID, Description FROM Stock WHERE Description LIKE '" + descrip + "%' ";

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


