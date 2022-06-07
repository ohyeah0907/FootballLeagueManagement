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
    public partial class RefereeManagementForm : DevExpress.XtraEditors.XtraForm
    {
        bool flag = false;
        BSRefereeManagementForm bSRefereeManagementForm = new BSRefereeManagementForm();

        public RefereeManagementForm()
        {
            InitializeComponent();
        }

        private void RefereeManagementForm_Load(object sender, EventArgs e)
        {
            bSRefereeManagementForm.LoadData(ref dgvRefereeList);

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtId.Enabled = false;
            txtName.Enabled = false;
            txtAge.Enabled = false;
            dtpDateOfBirth.Enabled = false;
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
            txtName.Text = "";
            txtAge.Text = "";
            txtName.Focus();

            txtName.Enabled = true;
            txtAge.Enabled = true;
            dtpDateOfBirth.Enabled = true;

            dgvRefereeList.Enabled = false;

            flag = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bSRefereeManagementForm.DeleteData(txtId.Text);
            bSRefereeManagementForm.LoadData(ref dgvRefereeList);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtName.Enabled = true;
            txtAge.Enabled = true;
            dtpDateOfBirth.Enabled = true;
            txtName.Focus();
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
                    bSRefereeManagementForm.AddData(txtName.Text, txtAge.Text, dtpDateOfBirth.Value);
                    dgvRefereeList.Enabled = true;
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
                    bSRefereeManagementForm.UpdateData(txtId.Text, txtName.Text, txtAge.Text, dtpDateOfBirth.Value);
                }
            }
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;

            txtName.Enabled = false;
            txtAge.Enabled = false;
            dtpDateOfBirth.Enabled = false;

            bSRefereeManagementForm.LoadData(ref dgvRefereeList);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtName.Enabled = false;
            txtAge.Enabled = false;
            dtpDateOfBirth.Enabled = false;

            txtId.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtName.Focus();

            dgvRefereeList.Enabled = true;

            flag = false;
        }

        public bool CheckEmpty()
        {
            if (txtName.Text == "" || txtAge.Text == "" )
            {
                MessageBox.Show("Please fill full information");
                txtName.Focus();
                return true;
            }
            return false;
        }

        private void dgvRefereeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = e.RowIndex;

            this.txtId.Text = dgvRefereeList.Rows[position].Cells[0].Value.ToString();
            this.txtName.Text = dgvRefereeList.Rows[position].Cells[1].Value.ToString();
            this.txtAge.Text = dgvRefereeList.Rows[position].Cells[2].Value.ToString();
            this.dtpDateOfBirth.Value = (DateTime)dgvRefereeList.Rows[position].Cells[3].Value;
    }
}