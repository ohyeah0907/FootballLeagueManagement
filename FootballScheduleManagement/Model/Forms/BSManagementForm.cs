using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballScheduleManagement.Model.Forms
{
    class BSManagementForm
    {
        public void RedirectForm(ref User user, Form redirectForm, int index)
        {
            switch(index)
            {
                case 1:
                    if (user.Permission.Contains((int)PermissionOfRoles.Edit_Table_Match_Referee_Scores))
                    {
                        redirectForm.Dock = DockStyle.Fill;
                        redirectForm.Show();
                    }
                    break;
                case 2:
                    if (user.Permission.Contains((int)PermissionOfRoles.Edit_Table_Player_Club))
                    {
                        redirectForm.Dock = DockStyle.Fill;
                        redirectForm.Show();
                    }
                    break;
                case 3:
                    if (user.Permission.Contains((int)PermissionOfRoles.Edit_Table_Match_Referee_Scores))
                    {
                        redirectForm.Dock = DockStyle.Fill;
                        redirectForm.Show();
                    }
                    break;
                case 4:
                    if (user.Permission.Contains((int)PermissionOfRoles.Edit_Table_Player_Club))
                    {
                        redirectForm.Dock = DockStyle.Fill;
                        redirectForm.Show();
                    }
                    break;
                case 5:
                    if (user.Permission.Contains((int)PermissionOfRoles.Edit_Table_Match_Referee_Scores))
                    {
                        redirectForm.Dock = DockStyle.Fill;
                        redirectForm.Show();
                    }
                    break;
                case 6:
                    if (user.Permission.Contains((int)PermissionOfRoles.Enter_Normal_Form))
                        redirectForm.Show();
                    break;
            }
        }
    }
}
