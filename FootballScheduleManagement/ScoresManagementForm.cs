﻿using DevExpress.XtraEditors;
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
        BSScoresManagementForm bSScoresManagementForm = new BSScoresManagementForm();

        public ScoresManagementForm()
        {
            InitializeComponent();
        }

        private void ScoresManagementForm_Load(object sender, EventArgs e)
        {
            bSScoresManagementForm.LoadData(ref dgvScoreList);

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

            if (txtMatchId.Text != "")
            {
                cboClub.Enabled = true;
                DataTable table = bSScoresManagementForm.GetClubName(txtMatchId.Text);
                cboClub.Items.Add(table.Rows[0][0].ToString());
                cboClub.Items.Add(table.Rows[0][1].ToString());

                if (cboClub.Text != "")
                {
                    cboPlayer.Enabled = true;
                    cboPlayer.DataSource = bSScoresManagementForm.GetPlayerName(cboClub.Text);
                    cboPlayer.DisplayMember = "name";
                    cboPlayer.ValueMember = "id";
                }
            }

            dgvScoreList.Enabled = false;

            flag = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bSScoresManagementForm.DeleteData(txtId.Text);
            bSScoresManagementForm.LoadData(ref dgvScoreList);
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
                    bSScoresManagementForm.AddData(cboPlayer.Text, txtMatchId.Text, cboClub.Text, txtOwnGoal.Text, txtMinute.Text);
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
                    bSScoresManagementForm.UpdateData(txtId.Text, cboPlayer.Text, txtMatchId.Text, cboClub.Text, txtOwnGoal.Text, txtMinute.Text);
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

            bSScoresManagementForm.LoadData(ref dgvScoreList);
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
            int position = e.RowIndex;

            this.txtId.Text = dgvScoreList.Rows[position].Cells[0].Value.ToString();
            this.cboPlayer.Text = dgvScoreList.Rows[position].Cells[1].Value.ToString();
            this.txtMatchId.Text = dgvScoreList.Rows[position].Cells[2].Value.ToString();
            this.cboClub.Text = dgvScoreList.Rows[position].Cells[3].Value.ToString();
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
    }
}