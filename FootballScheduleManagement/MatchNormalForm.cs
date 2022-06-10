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
using System.Diagnostics;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;

namespace FootballScheduleManagement
{
    public partial class MatchNormalForm : DevExpress.XtraEditors.XtraForm
    {
        BSMatchNormalForm bSMatchNormalForm = new BSMatchNormalForm();
        GridView gridView = new GridView();
        public MatchNormalForm()
        {
            InitializeComponent();
            gcMatchList.MainView = gridView;
            gridView.OptionsBehavior.Editable = false;
        }

        private void MatchNormalForm_Load(object sender, EventArgs e)
        {
            bSMatchNormalForm.LoadData(ref this.gcMatchList);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string fileName = TryGetSolutionDirectoryInfo().FullName.Trim() + "\\ExportFiles";

            if (!Directory.Exists(fileName))
            {
                Directory.CreateDirectory(fileName);
            }
            string path = fileName + "\\Match.xls";
            this.gcMatchList.ExportToXls(path);
            Process.Start(path);

        }

        public static DirectoryInfo TryGetSolutionDirectoryInfo(string currentPath = null)
        {
            var directory = new DirectoryInfo(
                currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            return directory;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DataRow dt = gridView.GetFocusedDataRow();
            MatchDetailNormalForm matchDetailNormalForm = new MatchDetailNormalForm();
            matchDetailNormalForm.refereeId = dt["refereeId"].ToString();
            matchDetailNormalForm.club1Id = dt["club1Id"].ToString();
            matchDetailNormalForm.club2Id = dt["club2Id"].ToString();
            matchDetailNormalForm.dateMatch = (DateTime)dt["dateMatch"];
            matchDetailNormalForm.periodTime = dt["periodTime"].ToString();
            matchDetailNormalForm.Show();
            matchDetailNormalForm.MdiParent = this.MdiParent;
            matchDetailNormalForm.Dock = DockStyle.Fill;
            this.Hide();
        }
    }
}