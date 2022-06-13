using MySql.Data.MySqlClient;
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
    class MySqlServer
    {
        //Database connection string
        string connectionString = @"server=localhost;uid=root;pwd=ohyeah0907@;database=footballschedulemanagement";

        MySqlConnection conn;
        MySqlDataAdapter sqlDataAdapter;
        MySqlCommand mySqlCommand;
        public MySqlConnection getConnection
        {
            get { return conn; }
        }

        public MySqlServer()
        {
            conn = new MySqlConnection();
            mySqlCommand = new MySqlCommand();
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
                mySqlCommand.Parameters.Clear();
                mySqlCommand.CommandText = sqlCommand.CommandText;
                //Get parameters of sqlCommand and add it to mySqlCommand.Parameters
                object[] parameterOfSqlcommand = new object[sqlCommand.Parameters.Count];
                sqlCommand.Parameters.CopyTo(parameterOfSqlcommand, 0);
                string[] parameterOfMysql = new string[sqlCommand.Parameters.Count];
                for (int i = 0; i < parameterOfSqlcommand.Length; i++)
                {
                    parameterOfMysql[i] = parameterOfSqlcommand[i].ToString();
                }
                for (int i = 0; i < parameterOfMysql.Length; i++)
                {
                    mySqlCommand.Parameters.AddWithValue(parameterOfMysql[i], sqlCommand.Parameters[i].Value);
                }
                mySqlCommand.Connection = conn;
                OpenConnection();
                sqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
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
                mySqlCommand.Parameters.Clear();
                mySqlCommand.CommandText = sqlCommand.CommandText;
                //Get parameters of sqlCommand and add it to mySqlCommand.Parameters
                object[] parameterOfSqlcommand = new object[sqlCommand.Parameters.Count];
                sqlCommand.Parameters.CopyTo(parameterOfSqlcommand, 0);
                string[] parameterOfMysql = new string[sqlCommand.Parameters.Count];
                for (int i = 0; i < parameterOfSqlcommand.Length; i++)
                {
                    parameterOfMysql[i] = parameterOfSqlcommand[i].ToString();
                }
                for (int i = 0; i < parameterOfMysql.Length; i++)
                {
                    mySqlCommand.Parameters.AddWithValue(parameterOfMysql[i], sqlCommand.Parameters[i].Value);
                }
                mySqlCommand.Connection = conn;
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