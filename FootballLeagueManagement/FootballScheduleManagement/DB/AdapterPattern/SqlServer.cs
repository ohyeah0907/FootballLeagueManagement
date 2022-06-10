using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballScheduleManagement.DB.AdapterPattern
{
    //Adapter pattern
    class SqlServer
    {
        //Database connection string
        string connectionString = @"Data Source=DESKTOP-I36H1BN\MSSQLSERVER1;Initial Catalog=FootballScheduleManagement;
        Persist Security Info=True;Integrated Security=SSPI";

        SqlConnection conn;
        SqlDataAdapter sqlDataAdapter;
        public SqlConnection getConnection
        {
            get { return conn; }
        }

        public SqlServer()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
        }

        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        //Use for SELECT
        public DataSet ExcecuteDataQuery(DbCommand sqlCommand)
        {
            DataSet dataSet = new DataSet();
            try
            {
                sqlCommand.Connection = conn;
                OpenConnection();
                sqlDataAdapter = new SqlDataAdapter((SqlCommand)sqlCommand);
                sqlDataAdapter.Fill(dataSet);
                CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return dataSet;
        }
        //Use for INSERT, UPDATE, DELETE
        public int ExcecuteDataNonQuery(DbCommand sqlCommand)
        {
            int rowsAffect = 0;
            try
            {
                sqlCommand.Connection = conn;
                OpenConnection();
                rowsAffect = sqlCommand.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return rowsAffect;
        }
    }
}
