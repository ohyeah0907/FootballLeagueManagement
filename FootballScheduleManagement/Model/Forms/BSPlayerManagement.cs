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
    class BSPlayerManagement
    {
        IDBHandler db;
        DataSet dataSet;
        DataTable dataTable;
        SqlCommand sqlCommand;

        public BSPlayerManagement()
        {
            db = new SqlServerAdapter(new SqlServer());
            sqlCommand = new SqlCommand();
            dataSet = new DataSet();
            dataTable = new DataTable();
        }
        public DataTable GetPlayerNameList(string clubId)
        {
            string sql = "SELECT name, id FROM Player Where clubId = @clubId";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@clubId", SqlDbType.Int).Value = Convert.ToInt32(clubId);
            dataSet = db.ExcecuteDataQuery(sqlCommand);
            dataTable = dataSet.Tables[0];
            sqlCommand.Parameters.Clear();
            return dataTable;
        }

        public DataTable GetPlayerName(string id)
        {
            string sql = "SELECT id, name FROM Player WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);
            dataSet = db.ExcecuteDataQuery(sqlCommand);
            dataTable = dataSet.Tables[0];
            sqlCommand.Parameters.Clear();
            return dataTable;
        }
    }
}
