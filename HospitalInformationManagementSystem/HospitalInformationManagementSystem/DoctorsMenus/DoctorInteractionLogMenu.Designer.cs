﻿
namespace HospitalInformationManagementSystem.DoctorsMenus
{
    partial class DoctorInteractionLogMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorInteractionLogMenu));
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelInteractionLogText = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewDisplayInteractionLoginfo = new System.Windows.Forms.DataGridView();
            this.ColumnLogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogInID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInteractionNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddInteractionLog = new System.Windows.Forms.Button();
            this.buttonEditInteractionLog = new System.Windows.Forms.Button();
            this.buttonDeleteInteractionLog = new System.Windows.Forms.Button();
            this.buttonViewSpecificInteractionLog = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchPatient = new System.Windows.Forms.TextBox();
            this.labelEnterPatientID = new System.Windows.Forms.Label();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayInteractionLoginfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelInteractionLogText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-2, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(1003, 125);
            this.panelWhiteTop.TabIndex = 9;
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(965, 18);
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
            this.pictureBoxGoBack.Location = new System.Drawing.Point(943, 3);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelInteractionLogText
            // 
            this.labelInteractionLogText.AutoSize = true;
            this.labelInteractionLogText.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInteractionLogText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelInteractionLogText.Location = new System.Drawing.Point(358, 46);
            this.labelInteractionLogText.Name = "labelInteractionLogText";
            this.labelInteractionLogText.Size = new System.Drawing.Size(366, 42);
            this.labelInteractionLogText.TabIndex = 5;
            this.labelInteractionLogText.Text = "Interaction Log Menu";
            // 
            // pictureBoxHospitalLogo
            // 
            this.pictureBoxHospitalLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHospitalLogo.Image")));
            this.pictureBoxHospitalLogo.Location = new System.Drawing.Point(0, 6);
            this.pictureBoxHospitalLogo.Name = "pictureBoxHospitalLogo";
            this.pictureBoxHospitalLogo.Size = new System.Drawing.Size(131, 116);
            this.pictureBoxHospitalLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHospitalLogo.TabIndex = 4;
            this.pictureBoxHospitalLogo.TabStop = false;
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
            this.dataGridViewDisplayInteractionLoginfo.Location = new System.Drawing.Point(155, 162);
            this.dataGridViewDisplayInteractionLoginfo.Name = "dataGridViewDisplayInteractionLoginfo";
            this.dataGridViewDisplayInteractionLoginfo.ReadOnly = true;
            this.dataGridViewDisplayInteractionLoginfo.Size = new System.Drawing.Size(833, 319);
            this.dataGridViewDisplayInteractionLoginfo.TabIndex = 13;
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
            // buttonAddInteractionLog
            // 
            this.buttonAddInteractionLog.Location = new System.Drawing.Point(12, 162);
            this.buttonAddInteractionLog.Name = "buttonAddInteractionLog";
            this.buttonAddInteractionLog.Size = new System.Drawing.Size(137, 55);
            this.buttonAddInteractionLog.TabIndex = 14;
            this.buttonAddInteractionLog.Text = "Add Interaction Log";
            this.buttonAddInteractionLog.UseVisualStyleBackColor = true;
            this.buttonAddInteractionLog.Click += new System.EventHandler(this.buttonAddInteractionLog_Click);
            // 
            // buttonEditInteractionLog
            // 
            this.buttonEditInteractionLog.Location = new System.Drawing.Point(12, 232);
            this.buttonEditInteractionLog.Name = "buttonEditInteractionLog";
            this.buttonEditInteractionLog.Size = new System.Drawing.Size(137, 55);
            this.buttonEditInteractionLog.TabIndex = 15;
            this.buttonEditInteractionLog.Text = "Edit Interaction Log";
            this.buttonEditInteractionLog.UseVisualStyleBackColor = true;
            this.buttonEditInteractionLog.Click += new System.EventHandler(this.buttonEditInteractionLog_Click);
            // 
            // buttonDeleteInteractionLog
            // 
            this.buttonDeleteInteractionLog.Location = new System.Drawing.Point(12, 305);
            this.buttonDeleteInteractionLog.Name = "buttonDeleteInteractionLog";
            this.buttonDeleteInteractionLog.Size = new System.Drawing.Size(137, 55);
            this.buttonDeleteInteractionLog.TabIndex = 16;
            this.buttonDeleteInteractionLog.Text = "Delete Interaction Log";
            this.buttonDeleteInteractionLog.UseVisualStyleBackColor = true;
            this.buttonDeleteInteractionLog.Click += new System.EventHandler(this.buttonDeleteInteractionLog_Click);
            // 
            // buttonViewSpecificInteractionLog
            // 
            this.buttonViewSpecificInteractionLog.Location = new System.Drawing.Point(12, 375);
            this.buttonViewSpecificInteractionLog.Name = "buttonViewSpecificInteractionLog";
            this.buttonViewSpecificInteractionLog.Size = new System.Drawing.Size(137, 55);
            this.buttonViewSpecificInteractionLog.TabIndex = 17;
            this.buttonViewSpecificInteractionLog.Text = "View Specific Interaction Log";
            this.buttonViewSpecificInteractionLog.UseVisualStyleBackColor = true;
            this.buttonViewSpecificInteractionLog.Click += new System.EventHandler(this.buttonViewSpecificInteractionLog_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(680, 134);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(71, 25);
            this.buttonReset.TabIndex = 53;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(603, 134);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(71, 25);
            this.buttonSearch.TabIndex = 52;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchPatient
            // 
            this.textBoxSearchPatient.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchPatient.Location = new System.Drawing.Point(471, 134);
            this.textBoxSearchPatient.Name = "textBoxSearchPatient";
            this.textBoxSearchPatient.Size = new System.Drawing.Size(126, 25);
            this.textBoxSearchPatient.TabIndex = 51;
            // 
            // labelEnterPatientID
            // 
            this.labelEnterPatientID.AutoSize = true;
            this.labelEnterPatientID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterPatientID.ForeColor = System.Drawing.Color.White;
            this.labelEnterPatientID.Location = new System.Drawing.Point(199, 135);
            this.labelEnterPatientID.Name = "labelEnterPatientID";
            this.labelEnterPatientID.Size = new System.Drawing.Size(266, 24);
            this.labelEnterPatientID.TabIndex = 54;
            this.labelEnterPatientID.Text = "Enter a Patient ID to search:";
            // 
            // DoctorInteractionLogMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1000, 495);
            this.Controls.Add(this.labelEnterPatientID);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchPatient);
            this.Controls.Add(this.buttonViewSpecificInteractionLog);
            this.Controls.Add(this.buttonDeleteInteractionLog);
            this.Controls.Add(this.buttonEditInteractionLog);
            this.Controls.Add(this.buttonAddInteractionLog);
            this.Controls.Add(this.dataGridViewDisplayInteractionLoginfo);
            this.Controls.Add(this.panelWhiteTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorInteractionLogMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorInteractionLogMenu";
            this.Load += new System.EventHandler(this.DoctorInteractionLogMenu_Load);
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayInteractionLoginfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelInteractionLogText;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.DataGridView dataGridViewDisplayInteractionLoginfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogInID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInteractionNotes;
        private System.Windows.Forms.Button buttonAddInteractionLog;
        private System.Windows.Forms.Button buttonEditInteractionLog;
        private System.Windows.Forms.Button buttonDeleteInteractionLog;
        private System.Windows.Forms.Button buttonViewSpecificInteractionLog;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchPatient;
        private System.Windows.Forms.Label labelEnterPatientID;
    }
}