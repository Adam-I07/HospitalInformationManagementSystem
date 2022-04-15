
namespace HospitalInformationManagementSystem
{
    partial class DoctorDeletePatientPersonalInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDeletePatientPersonalInfo));
            this.textBoxPatientID = new System.Windows.Forms.MaskedTextBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.labelPatientID = new System.Windows.Forms.Label();
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelErrorDisclaimerTextPart3 = new System.Windows.Forms.Label();
            this.labelErrorDisclaimerTextPart2 = new System.Windows.Forms.Label();
            this.labelErrorDisclaimerTextPart1 = new System.Windows.Forms.Label();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelDeleteUserText = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewShowUserDetail = new System.Windows.Forms.DataGridView();
            this.ColumnPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNHSNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCountryOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHomeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPostcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBloodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowUserDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPatientID.Location = new System.Drawing.Point(643, 160);
            this.textBoxPatientID.Mask = "00000";
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.Size = new System.Drawing.Size(132, 26);
            this.textBoxPatientID.TabIndex = 41;
            this.textBoxPatientID.ValidatingType = typeof(int);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(705, 192);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(70, 26);
            this.buttonDeleteUser.TabIndex = 39;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // labelPatientID
            // 
            this.labelPatientID.AutoSize = true;
            this.labelPatientID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientID.ForeColor = System.Drawing.Color.White;
            this.labelPatientID.Location = new System.Drawing.Point(639, 133);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(109, 24);
            this.labelPatientID.TabIndex = 38;
            this.labelPatientID.Text = "Patient ID:";
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelErrorDisclaimerTextPart3);
            this.panelWhiteTop.Controls.Add(this.labelErrorDisclaimerTextPart2);
            this.panelWhiteTop.Controls.Add(this.labelErrorDisclaimerTextPart1);
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelDeleteUserText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(1, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(1344, 118);
            this.panelWhiteTop.TabIndex = 37;
            // 
            // labelErrorDisclaimerTextPart3
            // 
            this.labelErrorDisclaimerTextPart3.AutoSize = true;
            this.labelErrorDisclaimerTextPart3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorDisclaimerTextPart3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelErrorDisclaimerTextPart3.Location = new System.Drawing.Point(562, 90);
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
            this.labelErrorDisclaimerTextPart2.Location = new System.Drawing.Point(562, 75);
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
            this.labelErrorDisclaimerTextPart1.Location = new System.Drawing.Point(562, 60);
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
            this.labelGoBack.Location = new System.Drawing.Point(1299, 18);
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
            this.pictureBoxGoBack.Location = new System.Drawing.Point(1279, 3);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelDeleteUserText
            // 
            this.labelDeleteUserText.AutoSize = true;
            this.labelDeleteUserText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelDeleteUserText.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteUserText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelDeleteUserText.Location = new System.Drawing.Point(590, 18);
            this.labelDeleteUserText.Name = "labelDeleteUserText";
            this.labelDeleteUserText.Size = new System.Drawing.Size(237, 42);
            this.labelDeleteUserText.TabIndex = 5;
            this.labelDeleteUserText.Text = "Delete Patient";
            // 
            // pictureBoxHospitalLogo
            // 
            this.pictureBoxHospitalLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHospitalLogo.Image")));
            this.pictureBoxHospitalLogo.Location = new System.Drawing.Point(-4, 2);
            this.pictureBoxHospitalLogo.Name = "pictureBoxHospitalLogo";
            this.pictureBoxHospitalLogo.Size = new System.Drawing.Size(131, 116);
            this.pictureBoxHospitalLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHospitalLogo.TabIndex = 4;
            this.pictureBoxHospitalLogo.TabStop = false;
            // 
            // dataGridViewShowUserDetail
            // 
            this.dataGridViewShowUserDetail.AllowUserToAddRows = false;
            this.dataGridViewShowUserDetail.AllowUserToDeleteRows = false;
            this.dataGridViewShowUserDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowUserDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPatientID,
            this.ColumnNHSNumber,
            this.ColumnFirstName,
            this.ColumnMiddleName,
            this.ColumnLastName,
            this.ColumnAge,
            this.ColumnGender,
            this.ColumnDateOfBirth,
            this.ColumnCountryOfBirth,
            this.ColumnEmail,
            this.ColumnPhoneNumber,
            this.ColumnHomeNumber,
            this.ColumnAddress,
            this.ColumnCity,
            this.ColumnPostcode,
            this.ColumnBloodType});
            this.dataGridViewShowUserDetail.Location = new System.Drawing.Point(12, 224);
            this.dataGridViewShowUserDetail.Name = "dataGridViewShowUserDetail";
            this.dataGridViewShowUserDetail.ReadOnly = true;
            this.dataGridViewShowUserDetail.Size = new System.Drawing.Size(1313, 309);
            this.dataGridViewShowUserDetail.TabIndex = 42;
            // 
            // ColumnPatientID
            // 
            this.ColumnPatientID.DataPropertyName = "PatientID";
            this.ColumnPatientID.HeaderText = "PatientID";
            this.ColumnPatientID.Name = "ColumnPatientID";
            this.ColumnPatientID.ReadOnly = true;
            this.ColumnPatientID.Width = 60;
            // 
            // ColumnNHSNumber
            // 
            this.ColumnNHSNumber.DataPropertyName = "NHSNumber";
            this.ColumnNHSNumber.HeaderText = "NHSNumber";
            this.ColumnNHSNumber.Name = "ColumnNHSNumber";
            this.ColumnNHSNumber.ReadOnly = true;
            this.ColumnNHSNumber.Width = 80;
            // 
            // ColumnFirstName
            // 
            this.ColumnFirstName.DataPropertyName = "FirstName";
            this.ColumnFirstName.HeaderText = "First Name";
            this.ColumnFirstName.Name = "ColumnFirstName";
            this.ColumnFirstName.ReadOnly = true;
            this.ColumnFirstName.Width = 70;
            // 
            // ColumnMiddleName
            // 
            this.ColumnMiddleName.DataPropertyName = "MiddleName";
            this.ColumnMiddleName.HeaderText = "Middle Name";
            this.ColumnMiddleName.Name = "ColumnMiddleName";
            this.ColumnMiddleName.ReadOnly = true;
            this.ColumnMiddleName.Width = 70;
            // 
            // ColumnLastName
            // 
            this.ColumnLastName.DataPropertyName = "LastName";
            this.ColumnLastName.HeaderText = "Last Name";
            this.ColumnLastName.Name = "ColumnLastName";
            this.ColumnLastName.ReadOnly = true;
            this.ColumnLastName.Width = 70;
            // 
            // ColumnAge
            // 
            this.ColumnAge.DataPropertyName = "Age";
            this.ColumnAge.HeaderText = "Age";
            this.ColumnAge.Name = "ColumnAge";
            this.ColumnAge.ReadOnly = true;
            this.ColumnAge.Width = 30;
            // 
            // ColumnGender
            // 
            this.ColumnGender.DataPropertyName = "Gender";
            this.ColumnGender.HeaderText = "Gender";
            this.ColumnGender.Name = "ColumnGender";
            this.ColumnGender.ReadOnly = true;
            this.ColumnGender.Width = 50;
            // 
            // ColumnDateOfBirth
            // 
            this.ColumnDateOfBirth.DataPropertyName = "DateOfBirth";
            this.ColumnDateOfBirth.HeaderText = "Date Of Birth";
            this.ColumnDateOfBirth.Name = "ColumnDateOfBirth";
            this.ColumnDateOfBirth.ReadOnly = true;
            this.ColumnDateOfBirth.Width = 65;
            // 
            // ColumnCountryOfBirth
            // 
            this.ColumnCountryOfBirth.DataPropertyName = "CountryOfBirth";
            this.ColumnCountryOfBirth.HeaderText = "Country Of Birth";
            this.ColumnCountryOfBirth.Name = "ColumnCountryOfBirth";
            this.ColumnCountryOfBirth.ReadOnly = true;
            this.ColumnCountryOfBirth.Width = 120;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.DataPropertyName = "Email";
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            this.ColumnEmail.Width = 150;
            // 
            // ColumnPhoneNumber
            // 
            this.ColumnPhoneNumber.DataPropertyName = "PhoneNumber";
            this.ColumnPhoneNumber.HeaderText = "Phone Number";
            this.ColumnPhoneNumber.Name = "ColumnPhoneNumber";
            this.ColumnPhoneNumber.ReadOnly = true;
            this.ColumnPhoneNumber.Width = 80;
            // 
            // ColumnHomeNumber
            // 
            this.ColumnHomeNumber.DataPropertyName = "HomeNumber";
            this.ColumnHomeNumber.HeaderText = "Home Number";
            this.ColumnHomeNumber.Name = "ColumnHomeNumber";
            this.ColumnHomeNumber.ReadOnly = true;
            this.ColumnHomeNumber.Width = 85;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.DataPropertyName = "Address";
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            this.ColumnAddress.Width = 120;
            // 
            // ColumnCity
            // 
            this.ColumnCity.DataPropertyName = "City";
            this.ColumnCity.HeaderText = "City";
            this.ColumnCity.Name = "ColumnCity";
            this.ColumnCity.ReadOnly = true;
            // 
            // ColumnPostcode
            // 
            this.ColumnPostcode.DataPropertyName = "Postcode";
            this.ColumnPostcode.HeaderText = "Postcode";
            this.ColumnPostcode.Name = "ColumnPostcode";
            this.ColumnPostcode.ReadOnly = true;
            this.ColumnPostcode.Width = 70;
            // 
            // ColumnBloodType
            // 
            this.ColumnBloodType.DataPropertyName = "BloodType";
            this.ColumnBloodType.HeaderText = "Blood Type";
            this.ColumnBloodType.Name = "ColumnBloodType";
            this.ColumnBloodType.ReadOnly = true;
            this.ColumnBloodType.Width = 50;
            // 
            // DoctorDeletePatientPersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1339, 546);
            this.Controls.Add(this.dataGridViewShowUserDetail);
            this.Controls.Add(this.textBoxPatientID);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.labelPatientID);
            this.Controls.Add(this.panelWhiteTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorDeletePatientPersonalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorDeletePatientPersonalInfo";
            this.Load += new System.EventHandler(this.DoctorDeletePatientPersonalInfo_Load);
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowUserDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textBoxPatientID;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Label labelPatientID;
        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.Label labelErrorDisclaimerTextPart3;
        private System.Windows.Forms.Label labelErrorDisclaimerTextPart2;
        private System.Windows.Forms.Label labelErrorDisclaimerTextPart1;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelDeleteUserText;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.DataGridView dataGridViewShowUserDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNHSNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCountryOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHomeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPostcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBloodType;
    }
}