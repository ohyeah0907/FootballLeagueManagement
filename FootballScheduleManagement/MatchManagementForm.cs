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
    public partial class MatchManagementForm : DevExpress.XtraEditors.XtraForm
    {
        bool flag = false;
        BSMatchManagement bSMatchManagement = new BSMatchManagement();


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
            int refereeId = Int32.Parse(cboReferee.SelectedItem.ToString());
            int club1Id = Int32.Parse(cboFirstClub.SelectedItem.ToString());
            int club2Id = Int32.Parse(cboSecondClub.SelectedItem.ToString());
            DateTime dateMatch = dtpDateOfMatch.Value;

            string periodTime = txtPeriodTime.Text.ToString();
            if (flag == true)
            {
                if (CheckEmpty() == true)
                    return;
                //Insert new record to database
                else
                { 
                    bSMatchManagement.addMatch(refereeId, club1Id, club2Id, dateMatch, periodTime);
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
                    bSMatchManagement.updateMatch(Int32.Parse(txtId.Text), refereeId, club1Id, club2Id, dateMatch, periodTime);

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

            bSMatchManagement.loadMatch(ref dgvMatchList);
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
            bSMatchManagement.deleteMatch(Int32.Parse( txtId.Text));
            bSMatchManagement.loadMatch(ref dgvMatchList);
        }

        private void dgvMatchList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MatchManagementForm_Load(object sender, EventArgs e)
        {
            bSMatchManagement.loadMatch(ref dgvMatchList);

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtId.Enabled = false;
            txtPeriodTime.Enabled = true;
            dtpDateOfMatch.Enabled = true;
            cboFirstClub.Enabled = true;
            cboReferee.Enabled = true;
            cboSecondClub.Enabled = true;
        }

        private void dgvMatchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = e.RowIndex;

            this.txtId.Text = dgvMatchList.Rows[position].Cells[0].Value.ToString();
            this.cboReferee.Text = dgvMatchList.Rows[position].Cells[1].Value.ToString();
            this.cboFirstClub.Text = dgvMatchList.Rows[position].Cells[2].Value.ToString();
            this.cboSecondClub.Text = dgvMatchList.Rows[position].Cells[3].Value.ToString();
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
    }
}