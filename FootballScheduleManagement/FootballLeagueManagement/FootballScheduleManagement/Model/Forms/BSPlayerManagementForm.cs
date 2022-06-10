using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballScheduleManagement.DB.AdapterPattern;

namespace FootballScheduleManagement.Model.Forms
{
    class BSPlayerManagementForm
    {
        IDBHandler db;
        DataSet dataSet;
        DataTable dataTable;
        SqlCommand sqlCommand;

        public BSPlayerManagementForm()
        {
            db = new SqlServerAdapter(new SqlServer());
            sqlCommand = new SqlCommand();
            dataSet = new DataSet();
            dataTable = new DataTable();
        }

        public void GetImage(ref PictureBox pic, ref string imgLoc)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
            dlg.Title = "Select club's avatar";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(dlg.FileName);
                imgLoc = dlg.FileName;
            }
        }
        public void LoadData(ref DataGridView dataGridView)
        {
            sqlCommand.Parameters.Clear();
            string sql = "SELECT * FROM Player";
            sqlCommand.CommandText = sql;
            dataSet = db.ExcecuteDataQuery(sqlCommand);
            dataTable = dataSet.Tables[0];
            dataGridView.DataSource = dataTable;
        }
        public void AddData(string name, int age, string position, DateTime dateOfBirth, int clubId, string nation)
        {
            string sql = "INSERT INTO Player(name, age, position, dateOfBirth, clubId, nation) VALUES(@name, @age, @position, @dateOfBirth, @clubId, @nation)";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            sqlCommand.Parameters.Add("@age", SqlDbType.NVarChar).Value = age;
            sqlCommand.Parameters.Add("@position", SqlDbType.DateTime).Value = position;
            sqlCommand.Parameters.Add("@dateOfBirth", SqlDbType.NVarChar).Value = dateOfBirth;
            sqlCommand.Parameters.Add("@clubId", SqlDbType.NVarChar).Value = clubId;
            sqlCommand.Parameters.Add("@nation", SqlDbType.Image).Value =nation;

            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Insert data successfully");
        }

        public void DeleteData(string id)
        {
            string sql = "DELETE FROM Club WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);


            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Delete data successfully");
        }

        public void UpdateData(string id, string name, int age, string position, DateTime dateOfBirth, int clubId, string nation)
        {
            string sql = "UPDATE Club SET  name = @name, age = @age, position = @position, dateOfBirth = @dateOfBirth, nation = @nation, clubId = @clubId WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            sqlCommand.Parameters.Add("@age", SqlDbType.NVarChar).Value = age;
            sqlCommand.Parameters.Add("@position", SqlDbType.DateTime).Value = position;
            sqlCommand.Parameters.Add("@dateOfBirth", SqlDbType.NVarChar).Value = dateOfBirth;
            sqlCommand.Parameters.Add("@clubId", SqlDbType.NVarChar).Value = clubId;
            sqlCommand.Parameters.Add("@nation", SqlDbType.Image).Value = nation;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);

            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Update data successfully");
        }
    }
}
