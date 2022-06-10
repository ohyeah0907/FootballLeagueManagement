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
    public partial class MatchDetailNormalForm : DevExpress.XtraEditors.XtraForm
    {
        public string refereeId;
        public string club1Id;
        public string club2Id;
        public DateTime dateMatch;
        public string periodTime;
        BSClubManagementForm bsClubManagementForm = new BSClubManagementForm();
        BSRefereeManagementForm bsRefereeManagementForm = new BSRefereeManagementForm();
        BSMatchDetailNormalForm bsMatchDetailNormalForm = new BSMatchDetailNormalForm();
        public MatchDetailNormalForm()
        {
            InitializeComponent();
        }

        private void MatchDetailNormalForm_Load(object sender, EventArgs e)
        {
            lblDateMatch.Text = dateMatch.ToShortDateString();
            lblReferee.Text = bsRefereeManagementForm.GetSpecificReferee(refereeId).Rows[0][1].ToString();
            lblPeriodTime.Text = periodTime;
            lblFirstClub.Text = bsClubManagementForm.GetSpecificClubName(club1Id).Rows[0][1].ToString();
            lblSecondClub.Text = bsClubManagementForm.GetSpecificClubName(club2Id).Rows[0][1].ToString(); ;
            MemoryStream ms = new MemoryStream((byte[])bsMatchDetailNormalForm.getClubAvatar(club1Id).Rows[0][0]);
            this.picFirstClub.Image = Image.FromStream(ms);
            ms = new MemoryStream((byte[])bsMatchDetailNormalForm.getClubAvatar(club2Id).Rows[0][0]);
            this.picSecondClub.Image = Image.FromStream(ms);
        }
    }
}