using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballScheduleManagement.DB.AdapterPattern;

namespace FootballScheduleManagement.Model.Forms
{
    class BSLoginForm
    {
        IDBHandler db;
        SqlCommand sqlCommand;
        public BSLoginForm()
        {
            db = new SqlServerAdapter(new SqlServer());
            sqlCommand = new SqlCommand();
        }

        public bool CheckInfo(string account, string password)
        {
            sqlCommand.Parameters.Clear();
            string sql = "SELECT id FROM UserDB WHERE account=@account AND password=@password";
            sqlCommand.Parameters.Add("@account", SqlDbType.NVarChar).Value = account;
            sqlCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            sqlCommand.CommandText = sql;
            DataSet result = db.ExcecuteDataQuery(sqlCommand);
            if (result.Tables[0].Rows.Count == 0)
                return false;
            return true;
        }
    }
}
