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
using FootballScheduleManagement.Model.Forms;
using System.IO;

namespace FootballScheduleManagement
{
    public partial class ScoresManagementForm : DevExpress.XtraEditors.XtraForm
    {
        bool flag = false;
        int position;
        BSScoresManagementForm bsScoresManagementForm = new BSScoresManagementForm();
        BSClubManagementForm bsClubManagementForm = new BSClubManagementForm();
        BSPlayerManagement bsPlayerManagement = new BSPlayerManagement();
        BSRefereeManagementForm bsRefereeManagementForm = new BSRefereeManagementForm();

        public ScoresManagementForm()
        {
            InitializeComponent();
        }

        private void ScoresManagementForm_Load(object sender, EventArgs e)
        {
            bsScoresManagementForm.LoadData(ref dgvScoreList);

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtId.Enabled = false;
            cboPlayer.Enabled = false;
            txtMatchId.Enabled = false;
            cboClub.Enabled = false;
            txtOwnGoal.Enabled = false;
            txtMinute.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtId.Text = "";
            cboPlayer.Text = "";
            txtMatchId.Text = "";
            cboClub.Text = "";
            txtOwnGoal.Text = "";
            txtMinute.Text = "";
            txtMatchId.Focus();

            cboPlayer.Enabled = false;
            txtMatchId.Enabled = true;
            cboClub.Enabled = false;
            txtOwnGoal.Enabled = true;
            txtMinute.Enabled = true;

           

            dgvScoreList.Enabled = false;

            flag = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bsScoresManagementForm.DeleteData(txtId.Text);
            bsScoresManagementForm.LoadData(ref dgvScoreList);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            cboPlayer.Enabled = true;
            txtMatchId.Enabled = true;
            cboClub.Enabled = true;
            txtOwnGoal.Enabled = true;
            txtMinute.Enabled = true;
            cboPlayer.Focus();
            cboClub.DataSource = bsClubManagementForm.GetSpecificClubName(txtMatchId.Text);
            cboClub.DisplayMember = "name";
            cboClub.ValueMember = "id";
            cboPlayer.DataSource = bsPlayerManagement.GetPlayerNameList(dgvScoreList.Rows[position].Cells[3].Value.ToString());
            cboPlayer.DisplayMember = "name";
            cboPlayer.ValueMember = "id";
            cboPlayer.Text = bsPlayerManagement.GetPlayerName(dgvScoreList.Rows[position].Cells[1].Value.ToString()).Rows[0][1].ToString();
            cboClub.Text = bsClubManagementForm.GetSpecificClubName(dgvScoreList.Rows[position].Cells[3].Value.ToString()).Rows[0][1].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                if (CheckEmpty() == true)
                    return;
                //Insert new record to database
                else
                {
                    bsScoresManagementForm.AddData(cboPlayer.SelectedValue.ToString(), txtMatchId.Text, cboClub.SelectedValue.ToString(), txtOwnGoal.Text, txtMinute.Text);
                    dgvScoreList.Enabled = true;
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
                    bsScoresManagementForm.UpdateData(txtId.Text, cboPlayer.SelectedValue.ToString(), txtMatchId.Text, cboClub.SelectedValue.ToString(), txtOwnGoal.Text, txtMinute.Text);
                }
            }
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;

            cboPlayer.Enabled = false;
            txtMatchId.Enabled = false;
            cboClub.Enabled = false;
            txtOwnGoal.Enabled = false;
            txtMinute.Enabled = false;

            bsScoresManagementForm.LoadData(ref dgvScoreList);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            cboPlayer.Enabled = false;
            txtMatchId.Enabled = false;
            cboClub.Enabled = false;
            txtOwnGoal.Enabled = false;
            txtMinute.Enabled = false;

            txtId.Text = "";
            cboPlayer.Text = "";
            txtMatchId.Text = "";
            cboClub.Text = "";
            txtOwnGoal.Text = "";
            txtMinute.Text = "";
            cboPlayer.Focus();

            dgvScoreList.Enabled = true;

            flag = false;
        }

        private void dgvScoreList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.position = e.RowIndex;

            this.txtId.Text = dgvScoreList.Rows[position].Cells[0].Value.ToString();
            this.cboPlayer.Text = bsPlayerManagement.GetPlayerName(dgvScoreList.Rows[position].Cells[1].Value.ToString()).Rows[0][1].ToString();
            this.txtMatchId.Text = dgvScoreList.Rows[position].Cells[2].Value.ToString();
            this.cboClub.Text = bsClubManagementForm.GetSpecificClubName(dgvScoreList.Rows[position].Cells[3].Value.ToString()).Rows[0][1].ToString();
            this.txtOwnGoal.Text = dgvScoreList.Rows[position].Cells[4].Value.ToString();
            this.txtMinute.Text = dgvScoreList.Rows[position].Cells[5].Value.ToString();
        }

        public bool CheckEmpty()
        {
            if (cboPlayer.Text == "" || txtMatchId.Text == "" || cboClub.Text == "" || txtOwnGoal.Text == "" || txtMinute.Text == "")
            {
                MessageBox.Show("Please fill full information");
                cboPlayer.Focus();
                return true;
            }
            return false;
        }

        private void txtMatchId_TextChanged(object sender, EventArgs e)
        {
            if(btnAdd.Enabled == false || btnDelete.Enabled == false)
            {
                if (txtMatchId.Text != "")
                {
                    cboClub.Enabled = true;
                    cboClub.DataSource = bsClubManagementForm.GetClubNameList(txtMatchId.Text);
                    cboClub.DisplayMember = "name";
                    cboClub.ValueMember = "id";
                }
            }
        }

        private void cboClub_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboClub.SelectedValue != null)
            {
                cboPlayer.Enabled = true;
                cboPlayer.DisplayMember = "name";
                cboPlayer.ValueMember = "id";
                cboPlayer.DataSource = bsPlayerManagement.GetPlayerNameList(cboClub.SelectedValue.ToString());
            }
        }
    }
}