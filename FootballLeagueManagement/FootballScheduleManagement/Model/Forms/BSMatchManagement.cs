using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballScheduleManagement.DB.AdapterPattern;

namespace FootballScheduleManagement.Model.Forms
{
    class BSMatchManagement
    {
        IDBHandler db;
        DataSet dataSet;
        DataTable dataTable;
        SqlCommand sqlCommand;

        public BSMatchManagement()
        {
            db = new SqlServerAdapter(new SqlServer());
            sqlCommand = new SqlCommand();
            dataSet = new DataSet();
            dataTable = new DataTable();
        }
        public void loadMatch(ref DataGridView dataGridView)
        {
            sqlCommand.Parameters.Clear();
            string sql = "SELECT * FROM Match";
            sqlCommand.CommandText = sql;
            dataSet = db.ExcecuteDataQuery(sqlCommand);
            dataTable = dataSet.Tables[0];
            dataGridView.DataSource = dataTable;
        }

        public void addMatch(int refereeId, int club1Id, int club2Id, DateTime dateMatch, string periodTime)
        {
            string sql = "INSERT INTO Match(refereeId, club1Id, club2Id, dateMatch, periodTime) VALUES(@refereeId, @club1Id, @club2Id, @dateMatch, @periodTime)";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@refereeId", SqlDbType.Int).Value = refereeId;
            sqlCommand.Parameters.Add("@club1Id", SqlDbType.Int).Value = club1Id;
            sqlCommand.Parameters.Add("@club2Id", SqlDbType.Int).Value = club2Id;
            sqlCommand.Parameters.Add("@dateMatch", SqlDbType.Date).Value = dateMatch;
            sqlCommand.Parameters.Add("@periodTime", SqlDbType.NVarChar).Value = periodTime;

            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Insert data successfully");

        }
        public void updateMatch(int id, int refereeId, int club1Id, int club2Id, DateTime dateMatch, string periodTime)
        {
            string sql = "UPDATE Match SET  refereeId = @refereeId, club1Id = @club1Id, club2Id = @club2Id, dateMatch = @dateMatch, periodTime = @periodTime WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@refereeId", SqlDbType.Int).Value = refereeId;
            sqlCommand.Parameters.Add("@club1Id", SqlDbType.Int).Value = club1Id;
            sqlCommand.Parameters.Add("@club2Id", SqlDbType.Int).Value = club2Id;
            sqlCommand.Parameters.Add("@dateMatch", SqlDbType.Date).Value = dateMatch;
            sqlCommand.Parameters.Add("@periodTime", SqlDbType.NVarChar).Value = periodTime;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Update data successfully");
        }
        public void deleteMatch(int id)
        {
            string sql = "DELETE FROM Match WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;


            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Delete data successfully");
        }

    }
}
