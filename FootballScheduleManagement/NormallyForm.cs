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

namespace FootballScheduleManagement
{
    public partial class NormallyForm : DevExpress.XtraEditors.XtraForm
    {
        public User user;
        ClubNormalForm clubNormalForm;
        ManagementForm managementForm;
        MatchNormalForm matchNormalForm;
        RankNormalForm rankNormalForm;
        public NormallyForm()
        {
            InitializeComponent();
            clubNormalForm = new ClubNormalForm();
            managementForm = new ManagementForm();
            matchNormalForm = new MatchNormalForm();
            rankNormalForm = new RankNormalForm();
        }
        private void NormallyForm_Load(object sender, EventArgs e)
        {
            user.getPermission();
        }

        private void tsmiClubList_Click(object sender, EventArgs e)
        {
            CloseFormsExcept(this, clubNormalForm);
            if (clubNormalForm.IsDisposed == true)
                clubNormalForm = new ClubNormalForm();
            clubNormalForm.MdiParent = this;
            clubNormalForm.Dock = DockStyle.Fill;
            clubNormalForm.Show();
        }

        private void tsbtnBack_Click(object sender, EventArgs e)
        {
            //This event of button only active when the user go into this page has [Enter_Management_Form] permission
            //About the user has only [Enter_Normal_Form], this event does not work
            if(user.Permission.Contains((int)PermissionOfRoles.Enter_Management_Form))
            {
                managementForm.user = this.user; //Pass user's data which receive from ManagementForm
                managementForm.Show();
                this.Hide();
            }    
        }

        private void tsmiMatchList_Click(object sender, EventArgs e)
        {
            CloseFormsExcept(this, matchNormalForm);
            if (matchNormalForm.IsDisposed == true)
                matchNormalForm = new MatchNormalForm();
            matchNormalForm.MdiParent = this;
            matchNormalForm.Dock = DockStyle.Fill;
            matchNormalForm.Show();
        }

        private void tsmiPlayerList_Click(object sender, EventArgs e)
        {

        }

        private void tsmiRank_Click(object sender, EventArgs e)
        {
            CloseFormsExcept(this, rankNormalForm);
            if (rankNormalForm.IsDisposed == true)
                rankNormalForm = new RankNormalForm();
            rankNormalForm.MdiParent = this;
            rankNormalForm.Dock = DockStyle.Fill;
            rankNormalForm.Show();
        }
        private void tsbtnLogOut_Click(object sender, EventArgs e)
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