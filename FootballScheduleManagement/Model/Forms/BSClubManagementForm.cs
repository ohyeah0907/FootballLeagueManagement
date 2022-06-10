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
    class BSClubManagementForm
    {
        IDBHandler db;
        DataSet dataSet;
        DataTable dataTable;
        SqlCommand sqlCommand;

        public BSClubManagementForm()
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
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(dlg.FileName);
                imgLoc = dlg.FileName;
            }
        }
        public void LoadData(ref DataGridView dataGridView)
        {
            sqlCommand.Parameters.Clear();
            string sql = "SELECT * FROM Club";
            sqlCommand.CommandText = sql;
            dataSet = db.ExcecuteDataQuery(sqlCommand);
            dataTable = dataSet.Tables[0];
            dataGridView.DataSource = dataTable;
        }
        public void AddData(string name, string manager, DateTime foundingDate, string coachName, string nation, Array img)
        {
            sqlCommand.Parameters.Clear();
            string sql = "INSERT INTO Club(name, manager, foundingDate, coachName, nation, avatar) VALUES(@name, @manager, @foundingDate, @coachName, @nation, @img)";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            sqlCommand.Parameters.Add("@manager", SqlDbType.NVarChar).Value = manager;
            sqlCommand.Parameters.Add("@foundingDate", SqlDbType.DateTime).Value = foundingDate;
            sqlCommand.Parameters.Add("@coachName", SqlDbType.NVarChar).Value = coachName;
            sqlCommand.Parameters.Add("@nation", SqlDbType.NVarChar).Value = nation;
            sqlCommand.Parameters.Add("@img", SqlDbType.Image).Value = img;

            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Insert data successfully");
        }
        public void DeleteData(string id)
        {
            sqlCommand.Parameters.Clear();
            string sql = "DELETE FROM Club WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);


            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Delete data successfully");
        }

        public void UpdateData(string id, string name, string manager, DateTime foundingDate, string coachName, string nation, Array img)
        {
            sqlCommand.Parameters.Clear();
            string sql = "UPDATE Club SET  name = @name, manager = @manager, foundingDate = @foundingDate, coachName = @coachName, nation = @nation, avatar = @img WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            sqlCommand.Parameters.Add("@manager", SqlDbType.NVarChar).Value = manager;
            sqlCommand.Parameters.Add("@foundingDate", SqlDbType.DateTime).Value = foundingDate;
            sqlCommand.Parameters.Add("@coachName", SqlDbType.NVarChar).Value = coachName;
            sqlCommand.Parameters.Add("@nation", SqlDbType.NVarChar).Value = nation;
            sqlCommand.Parameters.Add("@img", SqlDbType.Image).Value = img;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);

            int rowsAffect = db.ExcecuteDataNonQuery(sqlCommand);
            if (rowsAffect != 0)
                MessageBox.Show("Update data successfully");
        }
        public DataTable GetClubListWithCondition(string condition)
        {
            sqlCommand.Parameters.Clear();
            string sql = "SELECT id, name FROM Club WHERE name != @condition";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@condition", SqlDbType.NVarChar).Value = condition;
            dataSet = db.ExcecuteDataQuery(sqlCommand);
            dataTable = dataSet.Tables[0];
            return dataTable;
        }
        public DataTable GetClubNameList(string matchId)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("Id", typeof(int));
            sqlCommand.Parameters.Clear();
            string sql = "SELECT c1.name, c1.id FROM Match m Join Club c1 On c1.id = m.club1Id Where m.id = @matchId";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@matchId", SqlDbType.Int).Value = Convert.ToInt32(matchId);
            dataSet = db.ExcecuteDataQuery(sqlCommand);
            dataTable.Merge(dataSet.Tables[0]);
            sqlCommand.Parameters.Clear();
            sql = "SELECT c2.name, c2.id FROM Match m Join Club c2 On c2.id = m.club2Id Where m.id = @matchId";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@matchId", SqlDbType.Int).Value = Convert.ToInt32(matchId);
            dataSet = db.ExcecuteDataQuery(sqlCommand);
            dataTable.Merge(dataSet.Tables[0]);
            sqlCommand.Parameters.Clear();
            return dataTable;
        }
        public DataTable GetSpecificClubName(string id)
        {
            string sql = "SELECT id, name FROM Club WHERE id = @id";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);
            dataSet = db.ExcecuteDataQuery(sqlCommand);
            dataTable = dataSet.Tables[0];
            sqlCommand.Parameters.Clear();
            return dataTable;
        }
    }
}
