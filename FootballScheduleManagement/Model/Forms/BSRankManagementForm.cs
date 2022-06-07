using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using FootballScheduleManagement.DB.AdapterPattern;

namespace FootballScheduleManagement.Model.Forms
{
    class BSRankManagementForm
    {
        IDBHandler db;
        DataSet dataSet;
        DataTable dataTable;
        SqlCommand sqlCommand;

        public BSRankManagementForm()
        {
            db = new SqlServerAdapter(new SqlServer());
            sqlCommand = new SqlCommand();
            dataSet = new DataSet();
            dataTable = new DataTable();
        }

        public void AddData(string rank, string clubId, string score)
        {
            string sql = "INSERT INTO Club(rank, clubId, score) VALUES(@rank, @clubId, @score)";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@rank", SqlDbType.Int).Value = rank;
            sqlCommand.Parameters.Add("@clubId", SqlDbType.Int).Value = clubId;
            sqlCommand.Parameters.Add("@score", SqlDbType.Int).Value = score;

            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Insert data successfully");
        }

        public void DeleteData(string id)
        {
            string sql = "DELETE FROM Rank WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);


            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Delete data successfully");
        }

        public void UpdateData(string id, string rank, string clubId, string score)
        {
            string sql = "UPDATE Club SET  rank = @rank, clubId = @clubId, score = @score WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@rank", SqlDbType.Int).Value = rank;
            sqlCommand.Parameters.Add("@clubId", SqlDbType.Int).Value = clubId;
            sqlCommand.Parameters.Add("@score", SqlDbType.Int).Value = score;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);

            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Update data successfully");
        }

        public DataTable GetInfoClub(int clubId)
        {
            sqlCommand.Parameters.Clear();
            string sql = "SELECT rank, clubId, score, avatar FROM Rank Join Club On Rank.clubId = Club.id Where clubId = @clubId";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@clubId", SqlDbType.Int).Value = clubId;
            dataSet = db.ExcecuteDataQuery(sqlCommand);
            dataTable = dataSet.Tables[0];
            return dataTable;
        }

        public DataTable GetClubName()
        {
            sqlCommand.Parameters.Clear();
            string sql = "SELECT name, id FROM Club";
            sqlCommand.CommandText = sql;
            DataSet dataSet = db.ExcecuteDataQuery(sqlCommand);
            DataTable dataTable = dataSet.Tables[0];
            return dataTable;
        }
    }
}
