using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballScheduleManagement.DB.AdapterPattern;
using FootballScheduleManagement.Model.BridgePattern;

namespace FootballScheduleManagement.Model
{
    public class User
    {
        private IForm form;
        private string account;
        private string password;
        private List<int> permission;

        public IForm Form { get => form; set => form = value; }
        public string Account { get => account; set => account = value; }
        public string Password { get => password; set => password = value; }
        public List<int> Permission { get => permission; set => permission = value; }

        public User(IForm form, string account, string password)
        {
            this.Form = form;
            this.Account = account;
            this.Password = password;
            Permission = new List<int>();
        }

        public void getPermission()
        {
            IDBHandler db = new SqlServerAdapter(new SqlServer());
            SqlCommand sqlCommand = new SqlCommand();
            string sql ="SELECT permissionId  FROM UserDB, PermissionOfRoles WHERE UserDB.roleId = PermissionOfRoles.roleId AND account = @account AND password = @password";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@account", SqlDbType.NVarChar).Value = this.Account;
            sqlCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = this.Password;
            DataSet dataSet = db.ExcecuteDataQuery(sqlCommand);

            foreach (DataRow item in dataSet.Tables[0].Rows)
            {
                Permission.Add(Convert.ToInt32(item["permissionId"]));
            }
        }

        public void Login()
        {
            this.Form.Login();
        }

    }
}
