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
using System.IO;
using FootballScheduleManagement.Model.Forms;
using FootballScheduleManagement.Model;

namespace FootballScheduleManagement
{
    public partial class MatchManagementForm : DevExpress.XtraEditors.XtraForm
    {
        bool flag = false;
        BSMatchManagement bsMatchManagement = new BSMatchManagement();
        BSClubManagementForm bsClubManagementForm = new BSClubManagementForm();
        BSRefereeManagementForm bsRefereeManagementForm = new BSRefereeManagementForm();
        List<Club> firstClubList = new List<Club>();
        DataTable dt = new DataTable();
        public MatchManagementForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtId.Text = "";
            txtPeriodTime.Text = "";
            cboFirstClub.Text = "";
            cboReferee.Text = "";
            cboSecondClub.Text = "";

            txtPeriodTime.Focus();

            txtId.Enabled = false;
            txtPeriodTime.Enabled = true;
            dtpDateOfMatch.Enabled = true;
            cboFirstClub.Enabled = true;
            cboReferee.Enabled = true;
            cboSecondClub.Enabled = true;

            dgvMatchList.Enabled = false;

            flag = true;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            int refereeId = Int32.Parse(cboReferee.SelectedValue.ToString());
            int club1Id = Int32.Parse(cboFirstClub.SelectedValue.ToString());
            int club2Id = Int32.Parse(cboSecondClub.SelectedValue.ToString());
            DateTime dateMatch = dtpDateOfMatch.Value;
            string periodTime = txtPeriodTime.Text.ToString();
            if (flag == true)
            {
                if (CheckEmpty() == true)
                    return;
                //Insert new record to database
                else
                { 
                    bsMatchManagement.addMatch(refereeId, club1Id, club2Id, dateMatch, periodTime);
                    dgvMatchList.Enabled = true;
                    flag = false;
                }
            }
            else
            {
                if (txtId.Text == "" || CheckEmpty() == true)
                    return;
                //Update new record to database
                else
                { 
                    bsMatchManagement.updateMatch(Int32.Parse(txtId.Text), refereeId, club1Id, club2Id, dateMatch, periodTime);
                }
            }
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;

            txtId.Enabled = false;
            txtPeriodTime.Enabled = false;
            dtpDateOfMatch.Enabled = false;
            cboFirstClub.Enabled = false;
            cboReferee.Enabled = false;
            cboSecondClub.Enabled = false;
            dgvMatchList.Enabled = true;

            bsMatchManagement.loadMatch(ref dgvMatchList);
        }

        public bool CheckEmpty()
        {
            if ( txtPeriodTime.Text == "" || cboFirstClub.Text == "" || cboSecondClub.Text == "" || cboReferee.Text == "")
            {
                MessageBox.Show("Please fill full information");
                txtId.Focus();
                return true;
            }
            return false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            //Enable textbox for edit except primary key
            txtId.Enabled = false;
            txtPeriodTime.Enabled = true;
            dtpDateOfMatch.Enabled = true;
            cboFirstClub.Enabled = true;
            cboReferee.Enabled = true;
            cboSecondClub.Enabled = true;

            dgvMatchList.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bsMatchManagement.deleteMatch(Int32.Parse( txtId.Text));
            bsMatchManagement.loadMatch(ref dgvMatchList);
        }

        private void dgvMatchList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MatchManagementForm_Load(object sender, EventArgs e)
        {
            bsMatchManagement.loadMatch(ref dgvMatchList);

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtId.Enabled = false;
            txtPeriodTime.Enabled = false;
            dtpDateOfMatch.Enabled = false;
            cboFirstClub.Enabled = false;
            cboReferee.Enabled = false;
            cboSecondClub.Enabled = false;

            dt = bsClubManagementForm.GetClubListWithCondition("''");
            foreach (DataRow row in dt.Rows)
            {
                Club club = new Club(row["id"].ToString(), row["name"].ToString());
                DataTable secondClubList = bsClubManagementForm.GetClubListWithCondition(club.Name);
                foreach (DataRow secondClub in secondClubList.Rows)
                {
                    club.OpponentList.Add(new Club(secondClub["id"].ToString(), secondClub["name"].ToString()));
                }
                firstClubList.Add(club);
            }
            cboFirstClub.DataSource = firstClubList;
            cboFirstClub.DisplayMember = "name";
            cboFirstClub.ValueMember = "id";
            dt = bsRefereeManagementForm.GetRefereeList();
            cboReferee.DataSource = dt;
            cboReferee.DisplayMember = "name";
            cboReferee.ValueMember = "id";
        }

        private void dgvMatchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = e.RowIndex;

            this.txtId.Text = dgvMatchList.Rows[position].Cells[0].Value.ToString();
            this.cboReferee.Text = bsRefereeManagementForm.GetSpecificReferee(dgvMatchList.Rows[position].Cells[1].Value.ToString()).Rows[0][1].ToString();
            this.cboFirstClub.Text = bsClubManagementForm.GetSpecificClubName(dgvMatchList.Rows[position].Cells[2].Value.ToString()).Rows[0][1].ToString();
            this.cboSecondClub.Text = bsClubManagementForm.GetSpecificClubName(dgvMatchList.Rows[position].Cells[3].Value.ToString()).Rows[0][1].ToString();
            this.dtpDateOfMatch.Value = (DateTime)dgvMatchList.Rows[position].Cells[4].Value;
            this.txtPeriodTime.Text = dgvMatchList.Rows[position].Cells[5].Value.ToString();
            
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtId.Enabled = false;
            txtPeriodTime.Enabled = false;
            dtpDateOfMatch.Enabled = false;
            cboFirstClub.Enabled = false;
            cboReferee.Enabled = false;
            cboSecondClub.Enabled = false;

            txtId.Text = "";
            txtPeriodTime.Text = "";
            cboFirstClub.Text = "";
            cboReferee.Text = "";
            cboSecondClub.Text = "";

            txtPeriodTime.Focus();

            dgvMatchList.Enabled = true;

            flag = false;
        }

        private void cboFirstClub_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cboFirstClub.SelectedItem != null)
            {
                Club club = cboFirstClub.SelectedItem as Club;
                cboSecondClub.DataSource = club.OpponentList;
                cboSecondClub.DisplayMember = "name";
                cboSecondClub.ValueMember = "id";
            }    
        }
    }
}