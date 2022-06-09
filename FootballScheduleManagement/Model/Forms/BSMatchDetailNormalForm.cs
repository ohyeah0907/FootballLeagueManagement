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
    class BSMatchDetailNormalForm
    {
        IDBHandler db;
        DataSet dataSet;
        DataTable dataTable;
        SqlCommand sqlCommand;

        public BSMatchDetailNormalForm()
        {
            db = new SqlServerAdapter(new SqlServer());
            sqlCommand = new SqlCommand();
            dataSet = new DataSet();
            dataTable = new DataTable();
        }

        public DataTable getClubAvatar(string id)
        {
            sqlCommand.Parameters.Clear();
            string sql = "SELECT avatar FROM Club WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);
            dataSet = db.ExcecuteDataQuery(sqlCommand);
            dataTable = dataSet.Tables[0];
            return dataTable;
        }
    }
}
