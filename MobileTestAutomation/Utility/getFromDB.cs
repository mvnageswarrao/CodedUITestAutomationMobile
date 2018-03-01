using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Xml;
using System.Configuration;
using MobileTestAutomation.UIMap.Generic.openBrowser_MapClasses;


namespace MobileTestAutomation.Utility
{
    class getFromDB
    {
        public getFromDB()
        {

        }

        public SqlDataReader getData(string SQLquery,string InitialCatalog)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

            //string InitialCatalog = "";
            scsb.DataSource = ConfigurationManager.AppSettings["DataSource"].ToString();
            if (InitialCatalog != "")
            {
                scsb.InitialCatalog = InitialCatalog;
            }else
            {
                scsb.InitialCatalog = ConfigurationManager.AppSettings["InitialCatalog"].ToString();
            }
            scsb.IntegratedSecurity = false; // set to true is using Windows Authentication
            scsb.UserID = ConfigurationManager.AppSettings["UserID"].ToString();
            scsb.Password = ConfigurationManager.AppSettings["Password"].ToString();

            SqlConnection conn = new SqlConnection(scsb.ConnectionString);
            SqlDataReader rdr = null;
            try
            {
                SqlCommand cmd = new SqlCommand(SQLquery);
                conn.Open();
                cmd.Connection = conn;
                rdr = cmd.ExecuteReader();

                return rdr;
            }
            catch (SqlException ex)
            {
                Console.Write("Error in connection : " + ex.Message);
                return null;
            }
        }
        public DataSet getdatafrmdtset(string SQLquery)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

            scsb.DataSource = ConfigurationManager.AppSettings["DataSource"].ToString();
            scsb.InitialCatalog = ConfigurationManager.AppSettings["InitialCatalog"].ToString();
            scsb.IntegratedSecurity = false; // set to true is using Windows Authentication
            scsb.UserID = ConfigurationManager.AppSettings["UserID"].ToString();
            scsb.Password = ConfigurationManager.AppSettings["Password"].ToString();

            SqlConnection conn = new SqlConnection(scsb.ConnectionString);

            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = SQLquery;
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                conn.Open();
                da.Fill(ds);
                conn.Close();
                return ds;
            }
            catch (SqlException ex)
            {
                Console.Write("Error in connection : " + ex.Message);
                return null;
            }
        }
        
    }

}