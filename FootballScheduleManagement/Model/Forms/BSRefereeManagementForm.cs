using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using FootballScheduleManagement.DB.AdapterPattern;

namespace FootballScheduleManagement.Model.Forms
{
    class BSRefereeManagementForm
    {
        IDBHandler db;
        DataSet dataSet;
        DataTable dataTable;
        SqlCommand sqlCommand;

        public BSRefereeManagementForm()
        {
            db = new SqlServerAdapter(new SqlServer());
            sqlCommand = new SqlCommand();
            dataSet = new DataSet();
            dataTable = new DataTable();
        }
        public void LoadData(ref DataGridView dataGridView)
        {
            sqlCommand.Parameters.Clear();
            string sql = "SELECT * FROM Referee";
            sqlCommand.CommandText = sql;
            dataSet = db.ExcecuteDataQuery(sqlCommand);
            dataTable = dataSet.Tables[0];
            dataGridView.DataSource = dataTable;
        }
        public void AddData(string name, string age, DateTime dateOfBirth)
        {
            string sql = "INSERT INTO Referee(name, age, dateOfBirth) VALUES(@name, @age, @dateOfBirth)";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            sqlCommand.Parameters.Add("@age", SqlDbType.NVarChar).Value = age;
            sqlCommand.Parameters.Add("@dateOfBirth", SqlDbType.DateTime).Value = dateOfBirth;

            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Insert data successfully");
        }

        public void DeleteData(string id)
        {
            string sql = "DELETE FROM Referee WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);


            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Delete data successfully");
        }

        public void UpdateData(string id, string name, string age, DateTime dateOfBirth)
        {
            string sql = "UPDATE Referee SET name = @name, age = @age, dateOfBirth = @dateOfBirth WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            sqlCommand.Parameters.Add("@age", SqlDbType.NVarChar).Value = age;
            sqlCommand.Parameters.Add("@dateOfBirth", SqlDbType.DateTime).Value = dateOfBirth;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);

            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Update data successfully");
        }
        public DataTable GetRefereeList()
        {
            sqlCommand.Parameters.Clear();
            string sql = "SELECT * FROM Referee";
            sqlCommand.CommandText = sql;
            dataSet = db.ExcecuteDataQuery(sqlCommand);
            dataTable = dataSet.Tables[0];
            return dataTable;
        }

        public DataTable GetSpecificReferee(string id)
        {
            sqlCommand.Parameters.Clear();
            string sql = "SELECT id, name FROM Referee WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);
            dataSet = db.ExcecuteDataQuery(sqlCommand);
            dataTable = dataSet.Tables[0];
            return dataTable;
        }
    }
}