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
    public partial class ClubManagementForm : DevExpress.XtraEditors.XtraForm
    {
        bool flag = false;
        string imgLoc;
        BSClubManagementForm bsClubManagementForm = new BSClubManagementForm();
        public ClubManagementForm()
        {
            InitializeComponent();
        }

        private void ClubManagementForm_Load(object sender, EventArgs e)
        {
            bsClubManagementForm.LoadData(ref dgvClubList);

            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtId.Enabled = false;
            txtName.Enabled = false;
            txtManager.Enabled = false;
            dtpFoundingDate.Enabled = false;
            txtCoach.Enabled = false;
            txtNation.Enabled = false;
            picAvatar.Enabled = false;
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
            txtManager.Text = "";
            txtCoach.Text = "";
            txtNation.Text = "";
            txtName.Focus();

            txtName.Enabled = true;
            txtManager.Enabled = true;
            dtpFoundingDate.Enabled = true;
            txtCoach.Enabled = true;
            txtNation.Enabled = true;
            picAvatar.Enabled = true;
            dgvClubList.Enabled = false;

            flag = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bsClubManagementForm.DeleteData(txtId.Text);
            bsClubManagementForm.LoadData(ref dgvClubList);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            //Enable textbox for edit except primary key
            txtName.Enabled = true;
            txtManager.Enabled = true;
            dtpFoundingDate.Enabled = true;
            txtCoach.Enabled = true;
            txtNation.Enabled = true;
            picAvatar.Enabled = true;
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
                    MemoryStream ms = new MemoryStream();
                    picAvatar.Image.Save(ms, picAvatar.Image.RawFormat);

                    bsClubManagementForm.AddData(txtName.Text, txtManager.Text, dtpFoundingDate.Value, txtCoach.Text, txtNation.Text, ms.ToArray());
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
                    MemoryStream ms = new MemoryStream();
                    picAvatar.Image.Save(ms, picAvatar.Image.RawFormat);
                    bsClubManagementForm.UpdateData(txtId.Text, txtName.Text, txtManager.Text, dtpFoundingDate.Value, txtCoach.Text, txtNation.Text, ms.ToArray());
                }
            }
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;

            txtName.Enabled = false;
            txtManager.Enabled = false;
            dtpFoundingDate.Enabled = false;
            txtCoach.Enabled = false;
            txtNation.Enabled = false;
            picAvatar.Enabled = false;

            bsClubManagementForm.LoadData(ref dgvClubList);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            txtName.Enabled = false;
            txtManager.Enabled = false;
            dtpFoundingDate.Enabled = false;
            txtCoach.Enabled = false;
            txtNation.Enabled = false;
            picAvatar.Enabled = false;

            txtId.Text = "";
            txtName.Text = "";
            txtManager.Text = "";
            txtCoach.Text = "";
            txtNation.Text = "";
            picAvatar.Image = null;
            txtName.Focus();

            dgvClubList.Enabled = true;

            flag = false;
        }

        private void dgvClubList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int position = e.RowIndex;

                this.txtId.Text = dgvClubList.Rows[position].Cells[0].Value.ToString();
                this.txtName.Text = dgvClubList.Rows[position].Cells[1].Value.ToString();
                this.txtManager.Text = dgvClubList.Rows[position].Cells[2].Value.ToString();
                this.dtpFoundingDate.Value = (DateTime)dgvClubList.Rows[position].Cells[3].Value;
                this.txtCoach.Text = dgvClubList.Rows[position].Cells[4].Value.ToString();
                this.txtNation.Text = dgvClubList.Rows[position].Cells[5].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])dgvClubList.Rows[position].Cells[6].Value);
                this.picAvatar.Image = Image.FromStream(ms);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool CheckEmpty()
        {
            if (txtName.Text == "" || txtManager.Text == "" || txtCoach.Text == ""|| txtNation.Text == "" || picAvatar.Image == null)
            {
                MessageBox.Show("Please fill full information");
                txtName.Focus();
                return true;
            }
            return false;
        }

        private void picAvatar_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                bsClubManagementForm.GetImage(ref picAvatar, ref imgLoc);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}