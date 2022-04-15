
namespace HospitalInformationManagementSystem
{
    partial class DoctorDeleteInteractionLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDeleteInteractionLog));
            this.dataGridViewDisplayInteractionLoginfo = new System.Windows.Forms.DataGridView();
            this.ColumnLogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogInID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInteractionNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelDeleteInteractionLogText = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.textBoxLogID = new System.Windows.Forms.MaskedTextBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.labelLogID = new System.Windows.Forms.Label();
            this.labelErrorDisclaimerTextPart3 = new System.Windows.Forms.Label();
            this.labelErrorDisclaimerTextPart2 = new System.Windows.Forms.Label();
            this.labelErrorDisclaimerTextPart1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayInteractionLoginfo)).BeginInit();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDisplayInteractionLoginfo
            // 
            this.dataGridViewDisplayInteractionLoginfo.AllowUserToAddRows = false;
            this.dataGridViewDisplayInteractionLoginfo.AllowUserToDeleteRows = false;
            this.dataGridViewDisplayInteractionLoginfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplayInteractionLoginfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLogID,
            this.ColumnLogInID,
            this.ColumnStaffName,
            this.ColumnPatientID,
            this.ColumnDate,
            this.ColumnShift,
            this.ColumnInteractionNotes});
            this.dataGridViewDisplayInteractionLoginfo.Location = new System.Drawing.Point(12, 207);
            this.dataGridViewDisplayInteractionLoginfo.Name = "dataGridViewDisplayInteractionLoginfo";
            this.dataGridViewDisplayInteractionLoginfo.ReadOnly = true;
            this.dataGridViewDisplayInteractionLoginfo.Size = new System.Drawing.Size(833, 319);
            this.dataGridViewDisplayInteractionLoginfo.TabIndex = 14;
            // 
            // ColumnLogID
            // 
            this.ColumnLogID.DataPropertyName = "LogID";
            this.ColumnLogID.HeaderText = "LogID";
            this.ColumnLogID.Name = "ColumnLogID";
            this.ColumnLogID.ReadOnly = true;
            this.ColumnLogID.Width = 70;
            // 
            // ColumnLogInID
            // 
            this.ColumnLogInID.DataPropertyName = "LogInID";
            this.ColumnLogInID.HeaderText = "LoginID";
            this.ColumnLogInID.Name = "ColumnLogInID";
            this.ColumnLogInID.ReadOnly = true;
            this.ColumnLogInID.Width = 70;
            // 
            // ColumnStaffName
            // 
            this.ColumnStaffName.DataPropertyName = "StaffName";
            this.ColumnStaffName.HeaderText = "Staff Name";
            this.ColumnStaffName.Name = "ColumnStaffName";
            this.ColumnStaffName.ReadOnly = true;
            this.ColumnStaffName.Width = 90;
            // 
            // ColumnPatientID
            // 
            this.ColumnPatientID.DataPropertyName = "PatientID";
            this.ColumnPatientID.HeaderText = "PatientID";
            this.ColumnPatientID.Name = "ColumnPatientID";
            this.ColumnPatientID.ReadOnly = true;
            this.ColumnPatientID.Width = 80;
            // 
            // ColumnDate
            // 
            this.ColumnDate.DataPropertyName = "Date";
            this.ColumnDate.HeaderText = "Date Logged";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnShift
            // 
            this.ColumnShift.DataPropertyName = "Shift";
            this.ColumnShift.HeaderText = "Shift";
            this.ColumnShift.Name = "ColumnShift";
            this.ColumnShift.ReadOnly = true;
            this.ColumnShift.Width = 80;
            // 
            // ColumnInteractionNotes
            // 
            this.ColumnInteractionNotes.DataPropertyName = "InteractionNotes";
            this.ColumnInteractionNotes.HeaderText = "Interaction Notes";
            this.ColumnInteractionNotes.Name = "ColumnInteractionNotes";
            this.ColumnInteractionNotes.ReadOnly = true;
            this.ColumnInteractionNotes.Width = 300;
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelErrorDisclaimerTextPart3);
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.labelErrorDisclaimerTextPart2);
            this.panelWhiteTop.Controls.Add(this.labelErrorDisclaimerTextPart1);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelDeleteInteractionLogText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-1, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(857, 107);
            this.panelWhiteTop.TabIndex = 82;
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(810, 18);
            this.labelGoBack.Name = "labelGoBack";
            this.labelGoBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGoBack.Size = new System.Drawing.Size(36, 15);
            this.labelGoBack.TabIndex = 7;
            this.labelGoBack.Text = "Back";
            this.labelGoBack.Click += new System.EventHandler(this.labelGoBack_Click);
            // 
            // pictureBoxGoBack
            // 
            this.pictureBoxGoBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGoBack.Image")));
            this.pictureBoxGoBack.Location = new System.Drawing.Point(788, 3);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelDeleteInteractionLogText
            // 
            this.labelDeleteInteractionLogText.AutoSize = true;
            this.labelDeleteInteractionLogText.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteInteractionLogText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelDeleteInteractionLogText.Location = new System.Drawing.Point(264, 18);
            this.labelDeleteInteractionLogText.Name = "labelDeleteInteractionLogText";
            this.labelDeleteInteractionLogText.Size = new System.Drawing.Size(369, 42);
            this.labelDeleteInteractionLogText.TabIndex = 5;
            this.labelDeleteInteractionLogText.Text = "Delete Interaction Log";
            // 
            // pictureBoxHospitalLogo
            // 
            this.pictureBoxHospitalLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHospitalLogo.Image")));
            this.pictureBoxHospitalLogo.Location = new System.Drawing.Point(0, -9);
            this.pictureBoxHospitalLogo.Name = "pictureBoxHospitalLogo";
            this.pictureBoxHospitalLogo.Size = new System.Drawing.Size(131, 116);
            this.pictureBoxHospitalLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHospitalLogo.TabIndex = 4;
            this.pictureBoxHospitalLogo.TabStop = false;
            // 
            // textBoxLogID
            // 
            this.textBoxLogID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogID.Location = new System.Drawing.Point(342, 143);
            this.textBoxLogID.Mask = "00000";
            this.textBoxLogID.Name = "textBoxLogID";
            this.textBoxLogID.Size = new System.Drawing.Size(132, 26);
            this.textBoxLogID.TabIndex = 85;
            this.textBoxLogID.ValidatingType = typeof(int);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(404, 175);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(70, 26);
            this.buttonDeleteUser.TabIndex = 84;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // labelLogID
            // 
            this.labelLogID.AutoSize = true;
            this.labelLogID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogID.ForeColor = System.Drawing.Color.White;
            this.labelLogID.Location = new System.Drawing.Point(338, 116);
            this.labelLogID.Name = "labelLogID";
            this.labelLogID.Size = new System.Drawing.Size(80, 24);
            this.labelLogID.TabIndex = 83;
            this.labelLogID.Text = "Log ID:";
            // 
            // labelErrorDisclaimerTextPart3
            // 
            this.labelErrorDisclaimerTextPart3.AutoSize = true;
            this.labelErrorDisclaimerTextPart3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorDisclaimerTextPart3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelErrorDisclaimerTextPart3.Location = new System.Drawing.Point(282, 90);
            this.labelErrorDisclaimerTextPart3.Name = "labelErrorDisclaimerTextPart3";
            this.labelErrorDisclaimerTextPart3.Size = new System.Drawing.Size(143, 15);
            this.labelErrorDisclaimerTextPart3.TabIndex = 88;
            this.labelErrorDisclaimerTextPart3.Text = "comeback as an ERROR!";
            // 
            // labelErrorDisclaimerTextPart2
            // 
            this.labelErrorDisclaimerTextPart2.AutoSize = true;
            this.labelErrorDisclaimerTextPart2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorDisclaimerTextPart2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelErrorDisclaimerTextPart2.Location = new System.Drawing.Point(282, 75);
            this.labelErrorDisclaimerTextPart2.Name = "labelErrorDisclaimerTextPart2";
            this.labelErrorDisclaimerTextPart2.Size = new System.Drawing.Size(310, 15);
            this.labelErrorDisclaimerTextPart2.TabIndex = 87;
            this.labelErrorDisclaimerTextPart2.Text = "If you enter a number in the middle of the textbox it will  ";
            // 
            // labelErrorDisclaimerTextPart1
            // 
            this.labelErrorDisclaimerTextPart1.AutoSize = true;
            this.labelErrorDisclaimerTextPart1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorDisclaimerTextPart1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelErrorDisclaimerTextPart1.Location = new System.Drawing.Point(282, 60);
            this.labelErrorDisclaimerTextPart1.Name = "labelErrorDisclaimerTextPart1";
            this.labelErrorDisclaimerTextPart1.Size = new System.Drawing.Size(319, 15);
            this.labelErrorDisclaimerTextPart1.TabIndex = 86;
            this.labelErrorDisclaimerTextPart1.Text = "Note: Enter ID from the first available point in the textbox.";
            // 
            // DoctorDeleteInteractionLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(856, 538);
            this.Controls.Add(this.textBoxLogID);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.labelLogID);
            this.Controls.Add(this.panelWhiteTop);
            this.Controls.Add(this.dataGridViewDisplayInteractionLoginfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorDeleteInteractionLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorDeleteInteractionLog";
            this.Load += new System.EventHandler(this.DoctorDeleteInteractionLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayInteractionLoginfo)).EndInit();
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDisplayInteractionLoginfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogInID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInteractionNotes;
        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelDeleteInteractionLogText;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.MaskedTextBox textBoxLogID;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Label labelLogID;
        private System.Windows.Forms.Label labelErrorDisclaimerTextPart3;
        private System.Windows.Forms.Label labelErrorDisclaimerTextPart2;
        private System.Windows.Forms.Label labelErrorDisclaimerTextPart1;
    }
}