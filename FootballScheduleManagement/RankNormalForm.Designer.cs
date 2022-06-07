
namespace FootballScheduleManagement
{
    partial class RankNormalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboClub = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRank = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(361, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "RANK INFORMATION";
            // 
            // cboClub
            // 
            this.cboClub.FormattingEnabled = true;
            this.cboClub.Location = new System.Drawing.Point(182, 196);
            this.cboClub.Name = "cboClub";
            this.cboClub.Size = new System.Drawing.Size(228, 24);
            this.cboClub.TabIndex = 6;
            this.cboClub.SelectedIndexChanged += new System.EventHandler(this.cboClub_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(113, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Club:";
            // 
            // lbRank
            // 
            this.lbRank.AutoSize = true;
            this.lbRank.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRank.ForeColor = System.Drawing.Color.White;
            this.lbRank.Location = new System.Drawing.Point(554, 333);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(44, 18);
            this.lbRank.TabIndex = 8;
            this.lbRank.Text = "Rank:";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.ForeColor = System.Drawing.Color.White;
            this.lbNumber.Location = new System.Drawing.Point(621, 333);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(59, 18);
            this.lbNumber.TabIndex = 9;
            this.lbNumber.Text = "Number";
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAvatar.Location = new System.Drawing.Point(547, 155);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(142, 151);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 10;
            this.picAvatar.TabStop = false;
            // 
            // RankNormalForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(27)))), ((int)(((byte)(88)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 559);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbRank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboClub);
            this.Controls.Add(this.label1);
            this.Name = "RankNormalForm";
            this.Text = "RankNormalForm";
            this.Load += new System.EventHandler(this.RankNormalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRank;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.PictureBox picAvatar;
    }
}