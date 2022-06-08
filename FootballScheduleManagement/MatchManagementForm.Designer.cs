
namespace FootballScheduleManagement
{
    partial class MatchManagementForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvMatchList = new System.Windows.Forms.DataGridView();
            this.dtpDateOfMatch = new System.Windows.Forms.DateTimePicker();
            this.txtPeriodTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFirstClub = new System.Windows.Forms.ComboBox();
            this.cboSecondClub = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboReferee = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(1069, 571);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 46);
            this.btnClose.TabIndex = 67;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Location = new System.Drawing.Point(866, 571);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 46);
            this.btnCancel.TabIndex = 66;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.Location = new System.Drawing.Point(663, 571);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 46);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gray;
            this.btnEdit.Location = new System.Drawing.Point(471, 571);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 46);
            this.btnEdit.TabIndex = 64;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.Location = new System.Drawing.Point(269, 571);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 46);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.Location = new System.Drawing.Point(61, 571);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 46);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvMatchList
            // 
            this.dgvMatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatchList.Location = new System.Drawing.Point(61, 262);
            this.dgvMatchList.Name = "dgvMatchList";
            this.dgvMatchList.RowHeadersWidth = 51;
            this.dgvMatchList.RowTemplate.Height = 24;
            this.dgvMatchList.Size = new System.Drawing.Size(1094, 274);
            this.dgvMatchList.TabIndex = 61;
            this.dgvMatchList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatchList_CellClick);
            this.dgvMatchList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatchList_CellContentClick);
            // 
            // dtpDateOfMatch
            // 
            this.dtpDateOfMatch.Location = new System.Drawing.Point(866, 153);
            this.dtpDateOfMatch.Name = "dtpDateOfMatch";
            this.dtpDateOfMatch.Size = new System.Drawing.Size(287, 28);
            this.dtpDateOfMatch.TabIndex = 60;
            // 
            // txtPeriodTime
            // 
            this.txtPeriodTime.Location = new System.Drawing.Point(514, 158);
            this.txtPeriodTime.Name = "txtPeriodTime";
            this.txtPeriodTime.Size = new System.Drawing.Size(202, 28);
            this.txtPeriodTime.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(61, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 57;
            this.label6.Text = "Referee:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(744, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "Date of match:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(402, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 55;
            this.label4.Text = "Period time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(744, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Second Club:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(402, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "First club:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(471, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 28);
            this.label1.TabIndex = 50;
            this.label1.Text = "MATCH MANAGEMENT";
            // 
            // cboFirstClub
            // 
            this.cboFirstClub.FormattingEnabled = true;
            this.cboFirstClub.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboFirstClub.Location = new System.Drawing.Point(514, 87);
            this.cboFirstClub.Name = "cboFirstClub";
            this.cboFirstClub.Size = new System.Drawing.Size(202, 25);
            this.cboFirstClub.TabIndex = 68;
            // 
            // cboSecondClub
            // 
            this.cboSecondClub.FormattingEnabled = true;
            this.cboSecondClub.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboSecondClub.Location = new System.Drawing.Point(866, 85);
            this.cboSecondClub.Name = "cboSecondClub";
            this.cboSecondClub.Size = new System.Drawing.Size(202, 25);
            this.cboSecondClub.TabIndex = 69;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(183, 92);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(95, 28);
            this.txtId.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(61, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 18);
            this.label7.TabIndex = 70;
            this.label7.Text = "Id:";
            // 
            // cboReferee
            // 
            this.cboReferee.FormattingEnabled = true;
            this.cboReferee.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboReferee.Location = new System.Drawing.Point(183, 158);
            this.cboReferee.Name = "cboReferee";
            this.cboReferee.Size = new System.Drawing.Size(202, 25);
            this.cboReferee.TabIndex = 72;
            // 
            // MatchManagementForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(27)))), ((int)(((byte)(88)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 640);
            this.Controls.Add(this.cboReferee);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboSecondClub);
            this.Controls.Add(this.cboFirstClub);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvMatchList);
            this.Controls.Add(this.dtpDateOfMatch);
            this.Controls.Add(this.txtPeriodTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MatchManagementForm";
            this.Text = "MatchManagementForm";
            this.Load += new System.EventHandler(this.MatchManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvMatchList;
        private System.Windows.Forms.DateTimePicker dtpDateOfMatch;
        private System.Windows.Forms.TextBox txtPeriodTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFirstClub;
        private System.Windows.Forms.ComboBox cboSecondClub;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboReferee;
    }
}