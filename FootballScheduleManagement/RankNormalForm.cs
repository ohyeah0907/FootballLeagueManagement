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
    public partial class RankNormalForm : DevExpress.XtraEditors.XtraForm
    {
        bool flag = false;
        BSRankNormalForm bSRankManagementForm = new BSRankNormalForm();
        public RankNormalForm()
        {
            InitializeComponent();
        }

        private void RankNormalForm_Load(object sender, EventArgs e)
        {
            cboClub.DisplayMember = "name";
            cboClub.ValueMember = "id";
            cboClub.DataSource = bSRankManagementForm.GetClubName();
        }

        private void cboClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cboClub.SelectedValue;
            DataTable dt = bSRankManagementForm.GetInfoClub(id);
            MemoryStream ms = new MemoryStream((byte[])dt.Rows[0][3]);
            this.picAvatar.Image = Image.FromStream(ms);
            this.lbNumber.Text = dt.Rows[0][0].ToString();
        }
    }
}