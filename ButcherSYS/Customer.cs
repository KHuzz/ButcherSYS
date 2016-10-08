using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace ButcherSYS
{
    class Customer
    {
        int custID; //Customer ID
        string custFore; //Customer Fore Name
        string custSur; //Customer Surname
        string buisName; //Buisness Name
        string add1; //Address 1
        string add2; //Address 2
        string add3; //Address 3
        string custPhone; //Customer Phone
        string custEMail; // Customer E-mail


        public Customer()
        {
            custID = 0;
            custFore = "";
            custSur = "";
            buisName = "";
            add1 = "";
            add2 = "";
            add3 = "";
            custPhone = "";
            custEMail = "";
        } //end no-arg-constructor

        public Customer(int CID, string CF,string CS, string BN, string A1, string A2, string A3, string CP,
            string CE)
        {
            custID = CID;
            custFore = CF;
            custSur = CS;
            buisName = BN;
            add1 = A1;
            add2 = A2;
            add3 = A3;
            custPhone = CP;
            custEMail = CE;
        } //end multi arg-constructor

        //Setters
        public void setCustID(int CID)
        {
            custID = CID;
        }
        public void setCustForeName(string CF)
        {
            custFore = CF;
        }
        public void setCustSurName(string CS)
        {
            custSur = CS;
        }
        public void setBuisNmae(string BN)
        {
            buisName = BN;
        }
        public void setAdd1(string A1)
        {
            add1 = A1;
        }
        public void setAdd2(string A2)
        {
            add2 = A2;
        }
        public void setAdd3(string A3)
        {
            add3 = A3;
        }
        public void setCustP(string CP)
        {
            custPhone = CP;
        }
        public void setCustE(string CE)
        {
            custEMail = CE;
        }
        //Getters
        public int getCustID()
        {
            return custID;
        }
        public string getCustForeName()
        {
            return custFore;
        }
        public string getCustSurName()
        {
            return custSur;
        }
        public string getBuisName()
        {
            return buisName;
        }
        public string getAdd1()
        {
            return add1;
        }
        public string getAdd2()
        {
            return add2;
        }
        public string getAdd3()
        {
            return add3;
        }
        public string getCustP()
        {
            return custPhone;
        }
        public string getCustE()
        {
            return custEMail;
        }
        public int getNextCustID()
        {
            int intNextCID;

            //ITTralee connection
            OracleConnection myConn = new OracleConnection(DBIT.oradb);

            //Home connection
            // OracleConnection myConnHome = new OracleConnection(DBIT.oradbHome);

            String strSQL = "SELECT MAX(CustID) FROM Customers";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                intNextCID = 1;
            else
                intNextCID = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();
            return intNextCID;
        } // end getNextCustID

        public void insCustomer()
        {
            //create database connectgion string
            OracleConnection myConn = new OracleConnection(DBIT.oradb);

            //defining the SQL query
            String strSQL = "INSERT INTO Customers VALUES (" + this.custID +",'"+ this.custFore.ToUpper() + "','"+this.custSur.ToUpper() +"','"
                + this.buisName + "','" + this.add1+"','"+ this.add2+"','"+ this.add3+ "','"+ this.custPhone +"','" + this.custEMail+"')";

            //define oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            //open connection
            myConn.Open();
            //excute
            cmd.ExecuteNonQuery();
            //close database connection
            myConn.Close();
        } //end insCustomer

        public void getCustDetails(int cno)
        {
            //ITTralee connection
            OracleConnection myConn = new OracleConnection(DBIT.oradb);

            //Home connection
            // OracleConnection myConnHome = new OracleConnection(DBIT.oradbHome);

            string strSQL = "SELECT * FROM Customers WHERE CustID = " + cno;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            custID = dr.GetInt32(0);
            custFore = dr.GetString(1);
            custSur = dr.GetString(2);
            buisName = dr.GetString(3);
            add1 = dr.GetString(4);
            add2 = dr.GetString(5);
            add3 = dr.GetString(6);
            custPhone = dr.GetString(7);
            custEMail = dr.GetString(8);

            myConn.Close();

        }

        public void updateCustomer()
        {
            //create database connectgion string
            OracleConnection myConn = new OracleConnection(DBIT.oradb);

            //defining the SQL query

            // Need to update the selected customer details with a sql statment 30-3-16
            //defining the SQL query
            String strSQL = "UPDATE Customers SET CustForeName = '" + this.custFore.ToUpper() + "', CustSurName = '" + this.custSur.ToUpper() + "', BuisName = '"
                + this.buisName + "', Add1 = '" + this.add1 + "',Add2 = '" + this.add2 + "', Add3 = '" + this.add3 + "', CustPhone = '" + this.custPhone + "', CustEMail = '"
                + this.custEMail + "' WHERE CustID = " + this.custID;

            //define oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            //open connection
            myConn.Open();
            //excute
            cmd.ExecuteNonQuery();
            //close database connection
            myConn.Close();
        }
        public void deleteCustomer(string custSur)
        {
            //ITTralee connection
            OracleConnection myConn = new OracleConnection(DBIT.oradb);

            //Home connection
            // OracleConnection myConnHome = new OracleConnection(DBIT.oradbHome);

            string strSQL = "DELETE FROM Customers WHERE CustSurname LIKE '" + custSur + "%'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            myConn.Close();
        }
    } //end class
} //end ButcherSYS
