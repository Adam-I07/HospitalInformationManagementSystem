
namespace HospitalInformationManagementSystem.DoctorsMenus
{
    partial class DoctorIllnessMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorIllnessMenu));
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelIllnessInformationMenuText = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.buttonAddNewIllness = new System.Windows.Forms.Button();
            this.buttonEditIllnessInformation = new System.Windows.Forms.Button();
            this.buttonDeleteIllnessInformation = new System.Windows.Forms.Button();
            this.buttonSpecificIllnessInformation = new System.Windows.Forms.Button();
            this.ColumnNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateCheckedOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateCheckedIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTreatmentStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIllnessType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIllness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTreatmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDisplayIllnessInfo = new System.Windows.Forms.DataGridView();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayIllnessInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelIllnessInformationMenuText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-2, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(1183, 107);
            this.panelWhiteTop.TabIndex = 11;
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(1042, 18);
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
            this.pictureBoxGoBack.Location = new System.Drawing.Point(1020, 3);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelIllnessInformationMenuText
            // 
            this.labelIllnessInformationMenuText.AutoSize = true;
            this.labelIllnessInformationMenuText.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIllnessInformationMenuText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelIllnessInformationMenuText.Location = new System.Drawing.Point(338, 38);
            this.labelIllnessInformationMenuText.Name = "labelIllnessInformationMenuText";
            this.labelIllnessInformationMenuText.Size = new System.Drawing.Size(418, 42);
            this.labelIllnessInformationMenuText.TabIndex = 5;
            this.labelIllnessInformationMenuText.Text = "Illness Information Menu";
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
            // buttonAddNewIllness
            // 
            this.buttonAddNewIllness.Location = new System.Drawing.Point(12, 180);
            this.buttonAddNewIllness.Name = "buttonAddNewIllness";
            this.buttonAddNewIllness.Size = new System.Drawing.Size(181, 55);
            this.buttonAddNewIllness.TabIndex = 13;
            this.buttonAddNewIllness.Text = "Add Illness Information";
            this.buttonAddNewIllness.UseVisualStyleBackColor = true;
            this.buttonAddNewIllness.Click += new System.EventHandler(this.buttonAddNewIllness_Click);
            // 
            // buttonEditIllnessInformation
            // 
            this.buttonEditIllnessInformation.Location = new System.Drawing.Point(12, 253);
            this.buttonEditIllnessInformation.Name = "buttonEditIllnessInformation";
            this.buttonEditIllnessInformation.Size = new System.Drawing.Size(181, 55);
            this.buttonEditIllnessInformation.TabIndex = 14;
            this.buttonEditIllnessInformation.Text = "Edit Illness Information";
            this.buttonEditIllnessInformation.UseVisualStyleBackColor = true;
            this.buttonEditIllnessInformation.Click += new System.EventHandler(this.buttonEditIllnessInformation_Click);
            // 
            // buttonDeleteIllnessInformation
            // 
            this.buttonDeleteIllnessInformation.Location = new System.Drawing.Point(12, 328);
            this.buttonDeleteIllnessInformation.Name = "buttonDeleteIllnessInformation";
            this.buttonDeleteIllnessInformation.Size = new System.Drawing.Size(181, 55);
            this.buttonDeleteIllnessInformation.TabIndex = 15;
            this.buttonDeleteIllnessInformation.Text = "Delete Illness Information";
            this.buttonDeleteIllnessInformation.UseVisualStyleBackColor = true;
            this.buttonDeleteIllnessInformation.Click += new System.EventHandler(this.buttonDeleteIllnessInformation_Click);
            // 
            // buttonSpecificIllnessInformation
            // 
            this.buttonSpecificIllnessInformation.Location = new System.Drawing.Point(12, 402);
            this.buttonSpecificIllnessInformation.Name = "buttonSpecificIllnessInformation";
            this.buttonSpecificIllnessInformation.Size = new System.Drawing.Size(181, 55);
            this.buttonSpecificIllnessInformation.TabIndex = 16;
            this.buttonSpecificIllnessInformation.Text = "View Specific Illness Information";
            this.buttonSpecificIllnessInformation.UseVisualStyleBackColor = true;
            this.buttonSpecificIllnessInformation.Click += new System.EventHandler(this.buttonSpecificIllnessInformation_Click);
            // 
            // ColumnNotes
            // 
            this.ColumnNotes.DataPropertyName = "Notes";
            this.ColumnNotes.HeaderText = "Notes";
            this.ColumnNotes.Name = "ColumnNotes";
            this.ColumnNotes.ReadOnly = true;
            this.ColumnNotes.Width = 240;
            // 
            // ColumnDateCheckedOut
            // 
            this.ColumnDateCheckedOut.DataPropertyName = "DateCheckedOut";
            this.ColumnDateCheckedOut.HeaderText = "Date Checked Out";
            this.ColumnDateCheckedOut.Name = "ColumnDateCheckedOut";
            this.ColumnDateCheckedOut.ReadOnly = true;
            this.ColumnDateCheckedOut.Width = 80;
            // 
            // ColumnDateCheckedIn
            // 
            this.ColumnDateCheckedIn.DataPropertyName = "DateCheckedIn";
            this.ColumnDateCheckedIn.HeaderText = "Date Checked In";
            this.ColumnDateCheckedIn.Name = "ColumnDateCheckedIn";
            this.ColumnDateCheckedIn.ReadOnly = true;
            this.ColumnDateCheckedIn.Width = 80;
            // 
            // ColumnTreatmentStage
            // 
            this.ColumnTreatmentStage.DataPropertyName = "TreatmentStage";
            this.ColumnTreatmentStage.HeaderText = "Treatment Stage";
            this.ColumnTreatmentStage.Name = "ColumnTreatmentStage";
            this.ColumnTreatmentStage.ReadOnly = true;
            // 
            // ColumnIllnessType
            // 
            this.ColumnIllnessType.DataPropertyName = "IllnessType";
            this.ColumnIllnessType.HeaderText = "Illness Type";
            this.ColumnIllnessType.Name = "ColumnIllnessType";
            this.ColumnIllnessType.ReadOnly = true;
            // 
            // ColumnIllness
            // 
            this.ColumnIllness.DataPropertyName = "Illness";
            this.ColumnIllness.HeaderText = "Illness";
            this.ColumnIllness.Name = "ColumnIllness";
            this.ColumnIllness.ReadOnly = true;
            // 
            // ColumnPatientID
            // 
            this.ColumnPatientID.DataPropertyName = "PatientID";
            this.ColumnPatientID.HeaderText = "PatientID";
            this.ColumnPatientID.Name = "ColumnPatientID";
            this.ColumnPatientID.ReadOnly = true;
            this.ColumnPatientID.Width = 60;
            // 
            // ColumnTreatmentID
            // 
            this.ColumnTreatmentID.DataPropertyName = "TreatmentID";
            this.ColumnTreatmentID.HeaderText = "TreatmentID";
            this.ColumnTreatmentID.Name = "ColumnTreatmentID";
            this.ColumnTreatmentID.ReadOnly = true;
            this.ColumnTreatmentID.Width = 75;
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
            this.dataGridViewDisplayIllnessInfo.Location = new System.Drawing.Point(199, 180);
            this.dataGridViewDisplayIllnessInfo.Name = "dataGridViewDisplayIllnessInfo";
            this.dataGridViewDisplayIllnessInfo.ReadOnly = true;
            this.dataGridViewDisplayIllnessInfo.Size = new System.Drawing.Size(877, 372);
            this.dataGridViewDisplayIllnessInfo.TabIndex = 12;
            // 
            // DoctorIllnessMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1083, 564);
            this.Controls.Add(this.buttonSpecificIllnessInformation);
            this.Controls.Add(this.buttonDeleteIllnessInformation);
            this.Controls.Add(this.buttonEditIllnessInformation);
            this.Controls.Add(this.buttonAddNewIllness);
            this.Controls.Add(this.dataGridViewDisplayIllnessInfo);
            this.Controls.Add(this.panelWhiteTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorIllnessMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorIllnessMenu";
            this.Load += new System.EventHandler(this.DoctorIllnessMenu_Load);
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayIllnessInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelIllnessInformationMenuText;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.Button buttonAddNewIllness;
        private System.Windows.Forms.Button buttonEditIllnessInformation;
        private System.Windows.Forms.Button buttonDeleteIllnessInformation;
        private System.Windows.Forms.Button buttonSpecificIllnessInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateCheckedOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateCheckedIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTreatmentStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIllnessType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIllness;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTreatmentID;
        private System.Windows.Forms.DataGridView dataGridViewDisplayIllnessInfo;
    }
}