
namespace FootballScheduleManagement
{
    partial class NormallyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NormallyForm));
            this.mnsNavigation = new System.Windows.Forms.MenuStrip();
            this.tsmiMatchList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClubList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlayerList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRank = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnsNavigation.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsNavigation
            // 
            this.mnsNavigation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMatchList,
            this.tsmiClubList,
            this.tsmiPlayerList,
            this.tsmiRank});
            this.mnsNavigation.Location = new System.Drawing.Point(0, 0);
            this.mnsNavigation.Name = "mnsNavigation";
            this.mnsNavigation.Size = new System.Drawing.Size(898, 28);
            this.mnsNavigation.TabIndex = 0;
            this.mnsNavigation.Text = "menuStrip1";
            // 
            // tsmiMatchList
            // 
            this.tsmiMatchList.Name = "tsmiMatchList";
            this.tsmiMatchList.Size = new System.Drawing.Size(87, 24);
            this.tsmiMatchList.Text = "&Match list";
            this.tsmiMatchList.Click += new System.EventHandler(this.tsmiMatchList_Click);
            // 
            // tsmiClubList
            // 
            this.tsmiClubList.Name = "tsmiClubList";
            this.tsmiClubList.Size = new System.Drawing.Size(76, 24);
            this.tsmiClubList.Text = "&Club list";
            this.tsmiClubList.Click += new System.EventHandler(this.tsmiClubList_Click);
            // 
            // tsmiPlayerList
            // 
            this.tsmiPlayerList.Name = "tsmiPlayerList";
            this.tsmiPlayerList.Size = new System.Drawing.Size(86, 24);
            this.tsmiPlayerList.Text = "&Player list";
            this.tsmiPlayerList.Click += new System.EventHandler(this.tsmiPlayerList_Click);
            // 
            // tsmiRank
            // 
            this.tsmiRank.Name = "tsmiRank";
            this.tsmiRank.Size = new System.Drawing.Size(55, 24);
            this.tsmiRank.Text = "&Rank";
            this.tsmiRank.Click += new System.EventHandler(this.tsmiRank_Click);
            // 
            // tsbtnBack
            // 
            this.tsbtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnBack.Image")));
            this.tsbtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBack.Name = "tsbtnBack";
            this.tsbtnBack.Size = new System.Drawing.Size(29, 24);
            this.tsbtnBack.Text = "toolStripButton1";
            this.tsbtnBack.Click += new System.EventHandler(this.tsbtnBack_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 24);
            this.toolStripLabel1.Text = "Back";
            // 
            // tsbtnLogOut
            // 
            this.tsbtnLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLogOut.Image")));
            this.tsbtnLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLogOut.Name = "tsbtnLogOut";
            this.tsbtnLogOut.Size = new System.Drawing.Size(29, 24);
            this.tsbtnLogOut.Text = "toolStripButton1";
            this.tsbtnLogOut.Click += new System.EventHandler(this.tsbtnLogOut_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(56, 24);
            this.toolStripLabel2.Text = "Logout";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnBack,
            this.toolStripLabel1,
            this.tsbtnLogOut,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(898, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NormallyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 754);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnsNavigation);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsNavigation;
            this.Name = "NormallyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NormallyForm";
            this.Load += new System.EventHandler(this.NormallyForm_Load);
            this.mnsNavigation.ResumeLayout(false);
            this.mnsNavigation.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsNavigation;
        private System.Windows.Forms.ToolStripMenuItem tsmiMatchList;
        private System.Windows.Forms.ToolStripMenuItem tsmiClubList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayerList;
        private System.Windows.Forms.ToolStripMenuItem tsmiRank;
        private System.Windows.Forms.ToolStripButton tsbtnBack;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbtnLogOut;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}