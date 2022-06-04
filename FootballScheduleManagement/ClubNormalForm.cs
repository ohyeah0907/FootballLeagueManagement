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
    public partial class ClubNormalForm : DevExpress.XtraEditors.XtraForm
    {
        BSClubNormalForm bsClubNormalForm;
        public ClubNormalForm()
        {
           bsClubNormalForm = new BSClubNormalForm();
            InitializeComponent();
        }

        private void ClubNormalForm_Load(object sender, EventArgs e)
        {
            bsClubNormalForm.LoadData(ref this.gcClubList);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string fileName = TryGetSolutionDirectoryInfo().FullName.Trim() + "\\ExportFiles";

            if (!Directory.Exists(fileName))
            {
                Directory.CreateDirectory(fileName);
            }
            string path = fileName + "\\Club.xls";
            this.gcClubList.ExportToXls(path);
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
    }
}