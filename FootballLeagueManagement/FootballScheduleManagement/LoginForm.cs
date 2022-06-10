using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FootballScheduleManagement.Model;
using FootballScheduleManagement.Model.FactoryPattern;
using FootballScheduleManagement.Model.BridgePattern;
using FootballScheduleManagement.Model.Forms;

namespace FootballScheduleManagement
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        BSLoginForm bsLogin;
        CreateUser createUser;
        User user;

        public LoginForm()
        {
            bsLogin = new BSLoginForm();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = txtUsername.Text;
            string password = txtPassword.Text;

            if (account == "" || password == "")
            {
                MessageBox.Show("Please fill full information");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
            else
            {
                if (bsLogin.CheckInfo(txtUsername.Text, txtPassword.Text))
                {
                    //Check permission of user before redirect to ManagementForm or NormallyForm
                    if (Permission.CheckPermission(account, password, PermissionOfRoles.Enter_Management_Form))
                    {
                        ManagementForm managementForm = new ManagementForm();
                        ManagerForm managerForm = new ManagerForm(managementForm);
                        createUser = new ManagerUserCreator(managerForm, account, password);
                        user = createUser.UserFactoryMethod();
                        managementForm.user = this.user; //Pass user object to redirect form
                        user.Login();
                        this.Hide();
                    }
                    else
                    {
                        NormallyForm normallyForm = new NormallyForm();
                        NormalForm normalForm = new NormalForm(normallyForm);
                        createUser = new NormalUserCreator(normalForm, account, password);
                        user = createUser.UserFactoryMethod();
                        normallyForm.user = this.user;
                        user.Login();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong account or password");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
            }
        }
    }
}
