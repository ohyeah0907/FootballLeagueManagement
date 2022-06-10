using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballScheduleManagement.DB.AdapterPattern;

namespace FootballScheduleManagement.Model
{
    //List of permission
    enum PermissionOfRoles
    {
        Edit_Table_Player_Club = 1,
        Edit_Table_Match_Referee_Scores = 2,
        Enter_Management_Form = 3,
        Enter_Normal_Form = 4
    }
    class Permission
    {
        public static bool CheckPermission(string account, string password, PermissionOfRoles permissionOfRoles)
        {
            IDBHandler db = new SqlServerAdapter(new SqlServer());
            SqlCommand sqlCommand = new SqlCommand();
            string sql = "SELECT permissionId  FROM UserDB, PermissionOfRoles WHERE UserDB.roleId = PermissionOfRoles.roleId AND account = @account AND password = @password";
            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.Add("@account", SqlDbType.NVarChar).Value = account;
            sqlCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            DataSet result = db.ExcecuteDataQuery(sqlCommand);
            int permissionId = (int)permissionOfRoles;

            foreach (DataRow item in result.Tables[0].Rows)
            {
                if (permissionId == (int)item["permissionId"])
                    return true;
            }
            return false;
        }
    }
}
