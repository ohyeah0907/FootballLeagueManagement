
namespace FootballScheduleManagement
{
    partial class ManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            this.mnsNavigation = new System.Windows.Forms.MenuStrip();
            this.tsmiMatchManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClubManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScoreManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlayerManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefereeManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNormallyForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.mnsNavigation.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsNavigation
            // 
            this.mnsNavigation.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsNavigation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMatchManagement,
            this.tsmiClubManagement,
            this.tsmiScoreManagement,
            this.tsmiPlayerManagement,
            this.tsmiRefereeManagement,
            this.tsmiNormallyForm});
            this.mnsNavigation.Location = new System.Drawing.Point(0, 0);
            this.mnsNavigation.Name = "mnsNavigation";
            this.mnsNavigation.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.mnsNavigation.Size = new System.Drawing.Size(1119, 28);
            this.mnsNavigation.TabIndex = 1;
            this.mnsNavigation.Text = "menuStrip1";
            // 
            // tsmiMatchManagement
            // 
            this.tsmiMatchManagement.Name = "tsmiMatchManagement";
            this.tsmiMatchManagement.Size = new System.Drawing.Size(160, 24);
            this.tsmiMatchManagement.Text = "&Match management";
            this.tsmiMatchManagement.Click += new System.EventHandler(this.tsmiMatchManagement_Click);
            // 
            // tsmiClubManagement
            // 
            this.tsmiClubManagement.Name = "tsmiClubManagement";
            this.tsmiClubManagement.Size = new System.Drawing.Size(148, 24);
            this.tsmiClubManagement.Text = "&Club management";
            this.tsmiClubManagement.Click += new System.EventHandler(this.tsmiClubManagement_Click);
            // 
            // tsmiScoreManagement
            // 
            this.tsmiScoreManagement.Name = "tsmiScoreManagement";
            this.tsmiScoreManagement.Size = new System.Drawing.Size(162, 24);
            this.tsmiScoreManagement.Text = "Scores management";
            this.tsmiScoreManagement.Click += new System.EventHandler(this.tsmiScoreManagement_Click);
            // 
            // tsmiPlayerManagement
            // 
            this.tsmiPlayerManagement.Name = "tsmiPlayerManagement";
            this.tsmiPlayerManagement.Size = new System.Drawing.Size(158, 24);
            this.tsmiPlayerManagement.Text = "&Player management";
            this.tsmiPlayerManagement.Click += new System.EventHandler(this.tsmiPlayerManagement_Click);
            // 
            // tsmiRefereeManagement
            // 
            this.tsmiRefereeManagement.Name = "tsmiRefereeManagement";
            this.tsmiRefereeManagement.Size = new System.Drawing.Size(168, 24);
            this.tsmiRefereeManagement.Text = "&Referee management";
            this.tsmiRefereeManagement.Click += new System.EventHandler(this.tsmiRefereeManagement_Click);
            // 
            // tsmiNormallyForm
            // 
            this.tsmiNormallyForm.Name = "tsmiNormallyForm";
            this.tsmiNormallyForm.Size = new System.Drawing.Size(118, 24);
            this.tsmiNormallyForm.Text = "&Normally form";
            this.tsmiNormallyForm.Click += new System.EventHandler(this.tsmiNormallyForm_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnLogOut,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1119, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnLogOut
            // 
            this.tsbtnLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLogOut.Image")));
            this.tsbtnLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLogOut.Name = "tsbtnLogOut";
            this.tsbtnLogOut.Size = new System.Drawing.Size(29, 24);
            this.tsbtnLogOut.Text = "toolStripButton1";
            this.tsbtnLogOut.Click += new System.EventHandler(this.tsbLogOut_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 24);
            this.toolStripLabel1.Text = "Log out";
            // 
            // ManagementForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 754);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnsNavigation);
            this.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Name = "ManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementForm";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.mnsNavigation.ResumeLayout(false);
            this.mnsNavigation.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsNavigation;
        private System.Windows.Forms.ToolStripMenuItem tsmiMatchManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmiClubManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmiScoreManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayerManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefereeManagement;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnLogOut;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem tsmiNormallyForm;
    }
}