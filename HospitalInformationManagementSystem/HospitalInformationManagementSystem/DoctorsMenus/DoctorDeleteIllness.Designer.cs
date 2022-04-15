
namespace HospitalInformationManagementSystem
{
    partial class DoctorDeleteIllness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDeleteIllness));
            this.dataGridViewDisplayIllnessInfo = new System.Windows.Forms.DataGridView();
            this.ColumnTreatmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIllness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIllnessType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTreatmentStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateCheckedIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateCheckedOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelErrorDisclaimerTextPart3 = new System.Windows.Forms.Label();
            this.labelErrorDisclaimerTextPart2 = new System.Windows.Forms.Label();
            this.labelErrorDisclaimerTextPart1 = new System.Windows.Forms.Label();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelDeleteIllnessText = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.textBoxTreatmentID = new System.Windows.Forms.MaskedTextBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.labelTreatmentID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayIllnessInfo)).BeginInit();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDisplayIllnessInfo
            // 
            this.dataGridViewDisplayIllnessInfo.AllowUserToAddRows = false;
            this.dataGridViewDisplayIllnessInfo.AllowUserToDeleteRows = false;
            this.dataGridViewDisplayIllnessInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplayIllnessInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTreatmentID,
            this.ColumnPatientID,
            this.ColumnIllness,
            this.ColumnIllnessType,
            this.ColumnTreatmentStage,
            this.ColumnDateCheckedIn,
            this.ColumnDateCheckedOut,
            this.ColumnNotes});
            this.dataGridViewDisplayIllnessInfo.Location = new System.Drawing.Point(12, 238);
            this.dataGridViewDisplayIllnessInfo.Name = "dataGridViewDisplayIllnessInfo";
            this.dataGridViewDisplayIllnessInfo.ReadOnly = true;
            this.dataGridViewDisplayIllnessInfo.Size = new System.Drawing.Size(877, 372);
            this.dataGridViewDisplayIllnessInfo.TabIndex = 13;
            // 
            // ColumnTreatmentID
            // 
            this.ColumnTreatmentID.DataPropertyName = "TreatmentID";
            this.ColumnTreatmentID.HeaderText = "TreatmentID";
            this.ColumnTreatmentID.Name = "ColumnTreatmentID";
            this.ColumnTreatmentID.ReadOnly = true;
            this.ColumnTreatmentID.Width = 75;
            // 
            // ColumnPatientID
            // 
            this.ColumnPatientID.DataPropertyName = "PatientID";
            this.ColumnPatientID.HeaderText = "PatientID";
            this.ColumnPatientID.Name = "ColumnPatientID";
            this.ColumnPatientID.ReadOnly = true;
            this.ColumnPatientID.Width = 60;
            // 
            // ColumnIllness
            // 
            this.ColumnIllness.DataPropertyName = "Illness";
            this.ColumnIllness.HeaderText = "Illness";
            this.ColumnIllness.Name = "ColumnIllness";
            this.ColumnIllness.ReadOnly = true;
            // 
            // ColumnIllnessType
            // 
            this.ColumnIllnessType.DataPropertyName = "IllnessType";
            this.ColumnIllnessType.HeaderText = "Illness Type";
            this.ColumnIllnessType.Name = "ColumnIllnessType";
            this.ColumnIllnessType.ReadOnly = true;
            // 
            // ColumnTreatmentStage
            // 
            this.ColumnTreatmentStage.DataPropertyName = "TreatmentStage";
            this.ColumnTreatmentStage.HeaderText = "Treatment Stage";
            this.ColumnTreatmentStage.Name = "ColumnTreatmentStage";
            this.ColumnTreatmentStage.ReadOnly = true;
            // 
            // ColumnDateCheckedIn
            // 
            this.ColumnDateCheckedIn.DataPropertyName = "DateCheckedIn";
            this.ColumnDateCheckedIn.HeaderText = "Date Checked In";
            this.ColumnDateCheckedIn.Name = "ColumnDateCheckedIn";
            this.ColumnDateCheckedIn.ReadOnly = true;
            this.ColumnDateCheckedIn.Width = 80;
            // 
            // ColumnDateCheckedOut
            // 
            this.ColumnDateCheckedOut.DataPropertyName = "DateCheckedOut";
            this.ColumnDateCheckedOut.HeaderText = "Date Checked Out";
            this.ColumnDateCheckedOut.Name = "ColumnDateCheckedOut";
            this.ColumnDateCheckedOut.ReadOnly = true;
            this.ColumnDateCheckedOut.Width = 80;
            // 
            // ColumnNotes
            // 
            this.ColumnNotes.DataPropertyName = "Notes";
            this.ColumnNotes.HeaderText = "Notes";
            this.ColumnNotes.Name = "ColumnNotes";
            this.ColumnNotes.ReadOnly = true;
            this.ColumnNotes.Width = 240;
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelErrorDisclaimerTextPart3);
            this.panelWhiteTop.Controls.Add(this.labelErrorDisclaimerTextPart2);
            this.panelWhiteTop.Controls.Add(this.labelErrorDisclaimerTextPart1);
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelDeleteIllnessText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-1, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(904, 118);
            this.panelWhiteTop.TabIndex = 14;
            // 
            // labelErrorDisclaimerTextPart3
            // 
            this.labelErrorDisclaimerTextPart3.AutoSize = true;
            this.labelErrorDisclaimerTextPart3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorDisclaimerTextPart3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelErrorDisclaimerTextPart3.Location = new System.Drawing.Point(323, 101);
            this.labelErrorDisclaimerTextPart3.Name = "labelErrorDisclaimerTextPart3";
            this.labelErrorDisclaimerTextPart3.Size = new System.Drawing.Size(143, 15);
            this.labelErrorDisclaimerTextPart3.TabIndex = 10;
            this.labelErrorDisclaimerTextPart3.Text = "comeback as an ERROR!";
            // 
            // labelErrorDisclaimerTextPart2
            // 
            this.labelErrorDisclaimerTextPart2.AutoSize = true;
            this.labelErrorDisclaimerTextPart2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorDisclaimerTextPart2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelErrorDisclaimerTextPart2.Location = new System.Drawing.Point(323, 86);
            this.labelErrorDisclaimerTextPart2.Name = "labelErrorDisclaimerTextPart2";
            this.labelErrorDisclaimerTextPart2.Size = new System.Drawing.Size(310, 15);
            this.labelErrorDisclaimerTextPart2.TabIndex = 9;
            this.labelErrorDisclaimerTextPart2.Text = "If you enter a number in the middle of the textbox it will  ";
            // 
            // labelErrorDisclaimerTextPart1
            // 
            this.labelErrorDisclaimerTextPart1.AutoSize = true;
            this.labelErrorDisclaimerTextPart1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorDisclaimerTextPart1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelErrorDisclaimerTextPart1.Location = new System.Drawing.Point(323, 71);
            this.labelErrorDisclaimerTextPart1.Name = "labelErrorDisclaimerTextPart1";
            this.labelErrorDisclaimerTextPart1.Size = new System.Drawing.Size(319, 15);
            this.labelErrorDisclaimerTextPart1.TabIndex = 8;
            this.labelErrorDisclaimerTextPart1.Text = "Note: Enter ID from the first available point in the textbox.";
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(865, 18);
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
            this.pictureBoxGoBack.Location = new System.Drawing.Point(845, 3);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelDeleteIllnessText
            // 
            this.labelDeleteIllnessText.AutoSize = true;
            this.labelDeleteIllnessText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelDeleteIllnessText.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteIllnessText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelDeleteIllnessText.Location = new System.Drawing.Point(216, 29);
            this.labelDeleteIllnessText.Name = "labelDeleteIllnessText";
            this.labelDeleteIllnessText.Size = new System.Drawing.Size(543, 42);
            this.labelDeleteIllnessText.TabIndex = 5;
            this.labelDeleteIllnessText.Text = "Delete Patient Illness Information";
            // 
            // pictureBoxHospitalLogo
            // 
            this.pictureBoxHospitalLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHospitalLogo.Image")));
            this.pictureBoxHospitalLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHospitalLogo.Name = "pictureBoxHospitalLogo";
            this.pictureBoxHospitalLogo.Size = new System.Drawing.Size(131, 116);
            this.pictureBoxHospitalLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHospitalLogo.TabIndex = 4;
            this.pictureBoxHospitalLogo.TabStop = false;
            // 
            // textBoxTreatmentID
            // 
            this.textBoxTreatmentID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTreatmentID.Location = new System.Drawing.Point(384, 168);
            this.textBoxTreatmentID.Mask = "00000";
            this.textBoxTreatmentID.Name = "textBoxTreatmentID";
            this.textBoxTreatmentID.Size = new System.Drawing.Size(132, 26);
            this.textBoxTreatmentID.TabIndex = 39;
            this.textBoxTreatmentID.ValidatingType = typeof(int);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(446, 200);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(70, 26);
            this.buttonDeleteUser.TabIndex = 38;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // labelTreatmentID
            // 
            this.labelTreatmentID.AutoSize = true;
            this.labelTreatmentID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTreatmentID.ForeColor = System.Drawing.Color.White;
            this.labelTreatmentID.Location = new System.Drawing.Point(380, 141);
            this.labelTreatmentID.Name = "labelTreatmentID";
            this.labelTreatmentID.Size = new System.Drawing.Size(136, 24);
            this.labelTreatmentID.TabIndex = 37;
            this.labelTreatmentID.Text = "Treatment ID:";
            // 
            // DoctorDeleteIllness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(902, 622);
            this.Controls.Add(this.textBoxTreatmentID);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.labelTreatmentID);
            this.Controls.Add(this.panelWhiteTop);
            this.Controls.Add(this.dataGridViewDisplayIllnessInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorDeleteIllness";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorDeleteIllness";
            this.Load += new System.EventHandler(this.DoctorDeleteIllness_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayIllnessInfo)).EndInit();
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDisplayIllnessInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTreatmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIllness;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIllnessType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTreatmentStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateCheckedIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateCheckedOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNotes;
        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.Label labelErrorDisclaimerTextPart3;
        private System.Windows.Forms.Label labelErrorDisclaimerTextPart2;
        private System.Windows.Forms.Label labelErrorDisclaimerTextPart1;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelDeleteIllnessText;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.MaskedTextBox textBoxTreatmentID;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Label labelTreatmentID;
    }
}