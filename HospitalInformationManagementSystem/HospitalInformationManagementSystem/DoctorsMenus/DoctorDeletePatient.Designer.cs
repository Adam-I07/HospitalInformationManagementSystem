
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
            this.dataGridViewShowUserDetail = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowUserDetail)).BeginInit();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
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
            // dataGridViewShowUserDetail
            // 
            this.dataGridViewShowUserDetail.AllowUserToAddRows = false;
            this.dataGridViewShowUserDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowUserDetail.Location = new System.Drawing.Point(12, 225);
            this.dataGridViewShowUserDetail.Name = "dataGridViewShowUserDetail";
            this.dataGridViewShowUserDetail.ReadOnly = true;
            this.dataGridViewShowUserDetail.Size = new System.Drawing.Size(1342, 334);
            this.dataGridViewShowUserDetail.TabIndex = 40;
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
            this.panelWhiteTop.Size = new System.Drawing.Size(1370, 118);
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
            this.labelGoBack.Location = new System.Drawing.Point(1326, 18);
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
            this.pictureBoxGoBack.Location = new System.Drawing.Point(1306, 3);
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
            // DoctorDeletePatientPersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1366, 571);
            this.Controls.Add(this.textBoxPatientID);
            this.Controls.Add(this.dataGridViewShowUserDetail);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.labelPatientID);
            this.Controls.Add(this.panelWhiteTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorDeletePatientPersonalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorDeletePatientPersonalInfo";
            this.Load += new System.EventHandler(this.DoctorDeletePatientPersonalInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowUserDetail)).EndInit();
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textBoxPatientID;
        private System.Windows.Forms.DataGridView dataGridViewShowUserDetail;
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
    }
}