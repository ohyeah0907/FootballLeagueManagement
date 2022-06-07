using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using FootballScheduleManagement.DB.AdapterPattern;

namespace FootballScheduleManagement.Model.Forms
{
    class BSScoresManagementForm
    {
        IDBHandler db;
        DataSet dataSet;
        DataTable dataTable;
        SqlCommand sqlCommand;

        public BSScoresManagementForm()
        {
            db = new SqlServerAdapter(new SqlServer());
            sqlCommand = new SqlCommand();
            dataSet = new DataSet();
            dataTable = new DataTable();
        }

        public void LoadData(ref DataGridView dataGridView)
        {
            sqlCommand.Parameters.Clear();
            string sql = "SELECT * FROM Scores";
            sqlCommand.CommandText = sql;
            dataSet = db.ExcecuteDataQuery(sqlCommand);
            dataTable = dataSet.Tables[0];
            dataGridView.DataSource = dataTable;
        }
        public void AddData(string playerId, string matchId, string clubId, string ownGoal, string minute)
        {
            string sql = "INSERT INTO Scores(playerId, matchId, clubId, ownGoal, minute) VALUES(@playerId, @matchId, @clubId, @ownGoal, @minute)";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@playerId", SqlDbType.Int).Value = playerId;
            sqlCommand.Parameters.Add("@matchId", SqlDbType.Int).Value = matchId;
            sqlCommand.Parameters.Add("@clubId", SqlDbType.Int).Value = clubId;
            sqlCommand.Parameters.Add("@ownGoal", SqlDbType.Int).Value = ownGoal;
            sqlCommand.Parameters.Add("@minute", SqlDbType.Int).Value = minute;

            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Insert data successfully");
        }

        public void DeleteData(string id)
        {
            string sql = "DELETE FROM Scores WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);


            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Delete data successfully");
        }

        public void UpdateData(string id, string playerId, string matchId, string clubId, string ownGoal, string minute)
        {
            string sql = "UPDATE Scores SET  playerId = @playerId, matchId = @matchId, clubId = @clubId, ownGoal = @ownGoal, minute = @minute WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@playerId", SqlDbType.Int).Value = playerId;
            sqlCommand.Parameters.Add("@matchId", SqlDbType.Int).Value = matchId;
            sqlCommand.Parameters.Add("@clubId", SqlDbType.Int).Value = clubId;
            sqlCommand.Parameters.Add("@ownGoal", SqlDbType.Int).Value = ownGoal;
            sqlCommand.Parameters.Add("@minute", SqlDbType.Int).Value = minute;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);

            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Update data successfully");
        }

        public DataTable GetPlayerName()
        {
            string sql = "SELECT name FROM Player";
            SqlCommand command1 = new SqlCommand(sql);
            DataSet dataSet = db.ExcecuteDataQuery(sqlCommand);
            DataTable dataTable = dataSet.Tables[0];
            return dataTable;
        }

        public DataTable GetClubName()
        {
            string sql = "SELECT name FROM Club";
            SqlCommand command1 = new SqlCommand(sql);
            DataSet dataSet = db.ExcecuteDataQuery(sqlCommand);
            DataTable dataTable = dataSet.Tables[0];
            return dataTable;
        }
    }
}
