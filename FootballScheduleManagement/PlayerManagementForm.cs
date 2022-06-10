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
    public partial class PlayerManagementForm : DevExpress.XtraEditors.XtraForm
    {
        bool flag = false;
        BSPlayerManagementForm bsPlayerManagementForm = new BSPlayerManagementForm();
        public PlayerManagementForm()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PlayerManagementForm_Load(object sender, EventArgs e)
        {
            bsPlayerManagementForm.LoadData(ref dgvClubList);

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtId.Enabled = false;
            txtName.Enabled = false;
            txtAge.Enabled = false;
            cboClub.Enabled = false;
            cboPosition.Enabled = false;
            txtNation.Enabled = false;
            dtpDateOfBirth.Enabled = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            txtId.Text = "";
            txtName.Text = "";
            txtNation.Text = "";
            txtName.Focus();

            txtName.Enabled = true;
            txtAge.Enabled = true;
            dtpDateOfBirth.Enabled = true;
            cboPosition.Enabled = true;
            txtNation.Enabled = true;
            cboClub.Enabled = true;

            dgvClubList.Enabled = false;
            flag = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bsPlayerManagementForm.DeleteData(txtId.Text);
            bsPlayerManagementForm.LoadData(ref dgvClubList);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            //Enable textbox for edit except primary key
            txtName.Enabled = true;
            txtAge.Enabled = true;
            dtpDateOfBirth.Enabled = true;
            cboClub.Enabled = true;
            txtNation.Enabled = true;
            cboPosition.Enabled = true;
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
                    int Age = int.Parse(txtAge.Text);
                    int clubID = int.Parse(cboClub.Text);
                    bsPlayerManagementForm.AddData(txtName.Text, Age,cboPosition.Text, dtpDateOfBirth.Value, clubID, txtNation.Text);
                    dgvClubList.Enabled = true;
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
                    int Age = int.Parse(txtAge.Text);
                    bsPlayerManagementForm.UpdateData(txtId.Text, txtName.Text,Age ,cboPosition.Text, dtpDateOfBirth.Value, cboClub.SelectedIndex, txtNation.Text);
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
            cboClub.Enabled = false;
            cboPosition.Enabled = false;
            txtNation.Enabled = false;
            

            bsPlayerManagementForm.LoadData(ref dgvClubList);
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
            cboClub.Enabled = false;
            cboPosition.Enabled = false;
            txtNation.Enabled = false;
           

            txtId.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            
            txtNation.Text = "";
     
            txtName.Focus();

            dgvClubList.Enabled = true;

            flag = false;
        }

        private void dgvClubList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = e.RowIndex;

            this.txtId.Text = dgvClubList.Rows[position].Cells[0].Value.ToString();
            this.txtName.Text = dgvClubList.Rows[position].Cells[1].Value.ToString();
            this.txtAge.Text = dgvClubList.Rows[position].Cells[2].Value.ToString();
            this.dtpDateOfBirth.Value = (DateTime)dgvClubList.Rows[position].Cells[3].Value;
            this.cboClub.Text = dgvClubList.Rows[position].Cells[4].Value.ToString();
            this.cboPosition.Text = dgvClubList.Rows[position].Cells[4].Value.ToString();
            this.txtNation.Text = dgvClubList.Rows[position].Cells[5].Value.ToString();
  
        }

        public bool CheckEmpty()
        {
            if (txtName.Text == "" || txtAge.Text == "" ||  txtNation.Text == "" )
            {
                MessageBox.Show("Please fill full information");
                txtName.Focus();
                return true;
            }
            return false;
        }
    }
}