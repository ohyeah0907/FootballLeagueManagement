using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballScheduleManagement.Model;
using FootballScheduleManagement.Model.Forms;

namespace FootballScheduleManagement
{
    public partial class ManagementForm : DevExpress.XtraEditors.XtraForm
    {
        public User user;
        int index;
        BSManagementForm bsManagementForm;
        MatchManagementForm matchManagementForm;
        ClubManagementForm clubManagementForm;
        NormallyForm normallyForm;

        public ManagementForm()
        {
            InitializeComponent();
        }
        private void ManagementForm_Load(object sender, EventArgs e)
        {
            user.getPermission();
            bsManagementForm = new BSManagementForm();
            clubManagementForm = new ClubManagementForm();
            matchManagementForm = new MatchManagementForm();
            normallyForm = new NormallyForm();
        }

        private void tsmiClubManagement_Click(object sender, EventArgs e)
        {
            index = 2;

            CloseFormsExcept(this,clubManagementForm);
            // If the object is disposed, create it again
            if (clubManagementForm.IsDisposed == true)
                clubManagementForm = new ClubManagementForm();
            clubManagementForm.MdiParent = this;
            bsManagementForm.RedirectForm(ref user, clubManagementForm, index);
        }
        private void tsmiMatchManagement_Click(object sender, EventArgs e)
        {
            index = 1;
            CloseFormsExcept(this, matchManagementForm);
            if (matchManagementForm.IsDisposed == true)
                matchManagementForm = new MatchManagementForm();
            matchManagementForm.MdiParent = this;
            bsManagementForm.RedirectForm(ref user, matchManagementForm, index);
        }
        private void tsmiScoreManagement_Click(object sender, EventArgs e)
        {

        }

        private void tsmiPlayerManagement_Click(object sender, EventArgs e)
        {

        }

        private void tsmiRefereeManagement_Click(object sender, EventArgs e)
        {

        }
        private void tsmiNormallyForm_Click(object sender, EventArgs e)
        {
            index = 6;
            normallyForm.user = this.user; //Pass the user's data to NormallyForm
            bsManagementForm.RedirectForm(ref user, normallyForm, index);
            this.Hide();
        }

        private void tsbLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        //Close all forms in ManagementForm execpt current form
        public void CloseFormsExcept(Form managementForm, Form currentForm)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in managementForm.MdiChildren)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != currentForm.Name)
                    f.Close();
            }
        }

    }
}