using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballScheduleManagement.DB.AdapterPattern
{
    //Adapter pattern
    class MySqlServer
    {
        //Database connection string
        string connectionString = @"server=localhost;uid=root;pwd=ohyeah0907@;database=footballschedulemanagement";

        MySqlConnection conn;
        MySqlDataAdapter sqlDataAdapter;
        public MySqlConnection getConnection
        {
            get { return conn; }
        }

        public MySqlServer()
        {
            conn = new MySqlConnection();
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
                sqlDataAdapter = new MySqlDataAdapter((MySqlCommand)sqlCommand);
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
