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
        BSRankManagementForm bSRankManagementForm = new BSRankManagementForm();

        public RankNormalForm()
        {
            InitializeComponent();
        }

        private void RankNormalForm_Load(object sender, EventArgs e)
        {
            cboClub.DataSource = bSRankManagementForm.GetClubName();
            cboClub.DisplayMember = "name";
            cboClub.ValueMember = "id";
        }

        private void cboClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cboClub.SelectedValue.ToString();
            DataTable dt = bSRankManagementForm.GetInfoClub(id);
            MemoryStream ms = new MemoryStream((byte[])dt.Rows[0][3]);
            this.picAvatar.Image = Image.FromStream(ms);
            this.lbNumber.Text = dt.Rows[0][0].ToString();
        }
    }
}