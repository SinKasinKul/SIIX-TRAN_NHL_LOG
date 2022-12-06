using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;
using System.Collections;

namespace TRAN_NHL_LOG
{
    class ConnectDB
    {
        public SqlConnection ConnectionDB()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string Server = appSettings.Get("Server");
                string DataBase = appSettings.Get("DBNane");
                string User = appSettings.Get("User");
                string PW = appSettings.Get("PW");
                string PoolSize = appSettings.Get("PoolSize");
                string Timeout = appSettings.Get("Timeout");
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=" + Server + ";"
                                + "Initial Catalog=" + DataBase + ";"
                                + "User ID=" + User + ";"
                                + "Password=" + PW + ";"
                                + "Max Pool Size=" + PoolSize + ";"
                                + "Connect Timeout=" + Timeout + ";";
                cnn = new SqlConnection(connetionString);
                return cnn;
            }
            catch (SqlException e)
            {
                SqlConnection cnn;
                cnn = new SqlConnection();
                //Error = (e.ToString());
                return cnn;
            }
        }
        public string TRAN_FCT_LOG(string DATE_ADD, string STN, string BARCODE, string BARCODE2, string BARCODE3, string TYPE, string STATE)
        {
            try
            {
                SqlConnection cnn = ConnectionDB();
                SqlCommand objCmd = new SqlCommand();
                SqlDataAdapter dtAdapter = new SqlDataAdapter();

                DataSet ds = new DataSet();
                DataTable dt;
                string strStored;
                string Result;
                using (cnn)
                {
                    strStored = "TRAN_FCT_LOG";
                    objCmd.Parameters.Add(new SqlParameter("@pDATE_ADD", DATE_ADD));
                    objCmd.Parameters.Add(new SqlParameter("@pSTN", STN));
                    objCmd.Parameters.Add(new SqlParameter("@pBARCODE", BARCODE));
                    objCmd.Parameters.Add(new SqlParameter("@pBARCODE2", BARCODE2));
                    objCmd.Parameters.Add(new SqlParameter("@pBARCODE3", BARCODE3));
                    objCmd.Parameters.Add(new SqlParameter("@pTYPE", TYPE));
                    objCmd.Parameters.Add(new SqlParameter("@pSTATE", STATE));

                    objCmd.Connection = cnn;
                    objCmd.CommandText = strStored;
                    objCmd.CommandType = CommandType.StoredProcedure;

                    dtAdapter.SelectCommand = objCmd;

                    dtAdapter.Fill(ds);
                    dt = ds.Tables[0];

                    try
                    {
                        Result = dt.Rows[0]["result"].ToString();
                        return Result;
                    }
                    catch
                    {
                        Result = "SQL Error";
                        return Result;
                    }
                }
            }
            catch (SqlException e)
            {
                string Result = e.ToString();
                return Result;
            }
        }
    }
}
