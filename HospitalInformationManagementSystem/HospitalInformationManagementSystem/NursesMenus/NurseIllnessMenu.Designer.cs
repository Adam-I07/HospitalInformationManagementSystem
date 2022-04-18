
namespace HospitalInformationManagementSystem
{
    partial class NurseIllnessMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseIllnessMenu));
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labeBackText = new System.Windows.Forms.Label();
            this.pictureBoxGoBackArrow = new System.Windows.Forms.PictureBox();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelIllnessInformationMenuText = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.buttonViewSpecificIllnessInformation = new System.Windows.Forms.Button();
            this.labelEnterPatientID = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchPatient = new System.Windows.Forms.TextBox();
            this.dataGridViewDisplayIllnessInfo = new System.Windows.Forms.DataGridView();
            this.ColumnTreatmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIllness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIllnessType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTreatmentStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateCheckedIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateCheckedOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBackArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayIllnessInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labeBackText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBackArrow);
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelIllnessInformationMenuText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-4, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(919, 107);
            this.panelWhiteTop.TabIndex = 14;
            // 
            // labeBackText
            // 
            this.labeBackText.AutoSize = true;
            this.labeBackText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeBackText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labeBackText.Location = new System.Drawing.Point(866, 18);
            this.labeBackText.Name = "labeBackText";
            this.labeBackText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labeBackText.Size = new System.Drawing.Size(36, 15);
            this.labeBackText.TabIndex = 9;
            this.labeBackText.Text = "Back";
            this.labeBackText.Click += new System.EventHandler(this.labeBackText_Click);
            // 
            // pictureBoxGoBackArrow
            // 
            this.pictureBoxGoBackArrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGoBackArrow.Image")));
            this.pictureBoxGoBackArrow.Location = new System.Drawing.Point(847, 3);
            this.pictureBoxGoBackArrow.Name = "pictureBoxGoBackArrow";
            this.pictureBoxGoBackArrow.Size = new System.Drawing.Size(44, 48);
            this.pictureBoxGoBackArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBackArrow.TabIndex = 8;
            this.pictureBoxGoBackArrow.TabStop = false;
            this.pictureBoxGoBackArrow.Click += new System.EventHandler(this.pictureBoxGoBackArrow_Click);
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(1492, 18);
            this.labelGoBack.Name = "labelGoBack";
            this.labelGoBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGoBack.Size = new System.Drawing.Size(36, 15);
            this.labelGoBack.TabIndex = 7;
            this.labelGoBack.Text = "Back";
            // 
            // pictureBoxGoBack
            // 
            this.pictureBoxGoBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGoBack.Image")));
            this.pictureBoxGoBack.Location = new System.Drawing.Point(1470, 3);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            // 
            // labelIllnessInformationMenuText
            // 
            this.labelIllnessInformationMenuText.AutoSize = true;
            this.labelIllnessInformationMenuText.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIllnessInformationMenuText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelIllnessInformationMenuText.Location = new System.Drawing.Point(234, 39);
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
            // buttonViewSpecificIllnessInformation
            // 
            this.buttonViewSpecificIllnessInformation.Location = new System.Drawing.Point(642, 119);
            this.buttonViewSpecificIllnessInformation.Name = "buttonViewSpecificIllnessInformation";
            this.buttonViewSpecificIllnessInformation.Size = new System.Drawing.Size(170, 25);
            this.buttonViewSpecificIllnessInformation.TabIndex = 71;
            this.buttonViewSpecificIllnessInformation.Text = "View Specific Illness Information";
            this.buttonViewSpecificIllnessInformation.UseVisualStyleBackColor = true;
            this.buttonViewSpecificIllnessInformation.Click += new System.EventHandler(this.buttonViewSpecificIllnessInformation_Click);
            // 
            // labelEnterPatientID
            // 
            this.labelEnterPatientID.AutoSize = true;
            this.labelEnterPatientID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterPatientID.ForeColor = System.Drawing.Color.White;
            this.labelEnterPatientID.Location = new System.Drawing.Point(84, 119);
            this.labelEnterPatientID.Name = "labelEnterPatientID";
            this.labelEnterPatientID.Size = new System.Drawing.Size(266, 24);
            this.labelEnterPatientID.TabIndex = 70;
            this.labelEnterPatientID.Text = "Enter a Patient ID to search:";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(565, 119);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(71, 25);
            this.buttonReset.TabIndex = 69;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(488, 119);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(71, 25);
            this.buttonSearch.TabIndex = 68;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearchPatient
            // 
            this.textBoxSearchPatient.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchPatient.Location = new System.Drawing.Point(356, 119);
            this.textBoxSearchPatient.Name = "textBoxSearchPatient";
            this.textBoxSearchPatient.Size = new System.Drawing.Size(126, 25);
            this.textBoxSearchPatient.TabIndex = 67;
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
            this.dataGridViewDisplayIllnessInfo.Location = new System.Drawing.Point(14, 155);
            this.dataGridViewDisplayIllnessInfo.Name = "dataGridViewDisplayIllnessInfo";
            this.dataGridViewDisplayIllnessInfo.ReadOnly = true;
            this.dataGridViewDisplayIllnessInfo.Size = new System.Drawing.Size(877, 381);
            this.dataGridViewDisplayIllnessInfo.TabIndex = 72;
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
            // NurseIllnessMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(903, 548);
            this.Controls.Add(this.dataGridViewDisplayIllnessInfo);
            this.Controls.Add(this.buttonViewSpecificIllnessInformation);
            this.Controls.Add(this.labelEnterPatientID);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchPatient);
            this.Controls.Add(this.panelWhiteTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NurseIllnessMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NurseIllnessMenu";
            this.Load += new System.EventHandler(this.NurseIllnessMenu_Load);
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBackArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayIllnessInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.Label labeBackText;
        private System.Windows.Forms.PictureBox pictureBoxGoBackArrow;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelIllnessInformationMenuText;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.Button buttonViewSpecificIllnessInformation;
        private System.Windows.Forms.Label labelEnterPatientID;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchPatient;
        private System.Windows.Forms.DataGridView dataGridViewDisplayIllnessInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTreatmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIllness;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIllnessType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTreatmentStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateCheckedIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateCheckedOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNotes;
    }
}