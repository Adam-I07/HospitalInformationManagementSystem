﻿
namespace HospitalInformationManagementSystem.DoctorsMenus
{
    partial class DoctorRespondToRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorRespondToRequest));
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelRespondToRequestText = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.labelRequestID = new System.Windows.Forms.Label();
            this.textBoxRequestID = new System.Windows.Forms.MaskedTextBox();
            this.buttonFindID = new System.Windows.Forms.Button();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelRequestDate = new System.Windows.Forms.Label();
            this.labelRequestStatus = new System.Windows.Forms.Label();
            this.labelRequest = new System.Windows.Forms.Label();
            this.labelRequestResponse = new System.Windows.Forms.Label();
            this.labelDateFromatPart2 = new System.Windows.Forms.Label();
            this.labelDateFromatPart1 = new System.Windows.Forms.Label();
            this.textBoxRequestDate = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxRequestStatus = new System.Windows.Forms.ComboBox();
            this.textBoxRequestResponse = new System.Windows.Forms.RichTextBox();
            this.textBoxRequest = new System.Windows.Forms.RichTextBox();
            this.comboBoxUserID = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRespond = new System.Windows.Forms.Button();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelRespondToRequestText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(0, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(682, 107);
            this.panelWhiteTop.TabIndex = 11;
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(643, 18);
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
            this.pictureBoxGoBack.Location = new System.Drawing.Point(621, 3);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelRespondToRequestText
            // 
            this.labelRespondToRequestText.AutoSize = true;
            this.labelRespondToRequestText.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRespondToRequestText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelRespondToRequestText.Location = new System.Drawing.Point(194, 37);
            this.labelRespondToRequestText.Name = "labelRespondToRequestText";
            this.labelRespondToRequestText.Size = new System.Drawing.Size(340, 42);
            this.labelRespondToRequestText.TabIndex = 5;
            this.labelRespondToRequestText.Text = "Respond To Request";
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
            // labelRequestID
            // 
            this.labelRequestID.AutoSize = true;
            this.labelRequestID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestID.ForeColor = System.Drawing.Color.White;
            this.labelRequestID.Location = new System.Drawing.Point(12, 131);
            this.labelRequestID.Name = "labelRequestID";
            this.labelRequestID.Size = new System.Drawing.Size(116, 24);
            this.labelRequestID.TabIndex = 12;
            this.labelRequestID.Text = "Request ID:";
            this.labelRequestID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxRequestID
            // 
            this.textBoxRequestID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRequestID.Location = new System.Drawing.Point(279, 131);
            this.textBoxRequestID.Mask = "00000";
            this.textBoxRequestID.Name = "textBoxRequestID";
            this.textBoxRequestID.Size = new System.Drawing.Size(41, 26);
            this.textBoxRequestID.TabIndex = 91;
            this.textBoxRequestID.ValidatingType = typeof(int);
            // 
            // buttonFindID
            // 
            this.buttonFindID.Location = new System.Drawing.Point(326, 131);
            this.buttonFindID.Name = "buttonFindID";
            this.buttonFindID.Size = new System.Drawing.Size(40, 26);
            this.buttonFindID.TabIndex = 90;
            this.buttonFindID.Text = "Find";
            this.buttonFindID.UseVisualStyleBackColor = true;
            this.buttonFindID.Click += new System.EventHandler(this.buttonFindID_Click);
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.ForeColor = System.Drawing.Color.White;
            this.labelUserID.Location = new System.Drawing.Point(12, 171);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(85, 24);
            this.labelUserID.TabIndex = 92;
            this.labelUserID.Text = "User ID:";
            this.labelUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRequestDate
            // 
            this.labelRequestDate.AutoSize = true;
            this.labelRequestDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestDate.ForeColor = System.Drawing.Color.White;
            this.labelRequestDate.Location = new System.Drawing.Point(12, 205);
            this.labelRequestDate.Name = "labelRequestDate";
            this.labelRequestDate.Size = new System.Drawing.Size(137, 24);
            this.labelRequestDate.TabIndex = 93;
            this.labelRequestDate.Text = "Request Date:";
            this.labelRequestDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRequestStatus
            // 
            this.labelRequestStatus.AutoSize = true;
            this.labelRequestStatus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestStatus.ForeColor = System.Drawing.Color.White;
            this.labelRequestStatus.Location = new System.Drawing.Point(12, 250);
            this.labelRequestStatus.Name = "labelRequestStatus";
            this.labelRequestStatus.Size = new System.Drawing.Size(150, 24);
            this.labelRequestStatus.TabIndex = 94;
            this.labelRequestStatus.Text = "Request Status:";
            this.labelRequestStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRequest
            // 
            this.labelRequest.AutoSize = true;
            this.labelRequest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequest.ForeColor = System.Drawing.Color.White;
            this.labelRequest.Location = new System.Drawing.Point(12, 285);
            this.labelRequest.Name = "labelRequest";
            this.labelRequest.Size = new System.Drawing.Size(89, 24);
            this.labelRequest.TabIndex = 95;
            this.labelRequest.Text = "Request:";
            this.labelRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRequestResponse
            // 
            this.labelRequestResponse.AutoSize = true;
            this.labelRequestResponse.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestResponse.ForeColor = System.Drawing.Color.White;
            this.labelRequestResponse.Location = new System.Drawing.Point(429, 131);
            this.labelRequestResponse.Name = "labelRequestResponse";
            this.labelRequestResponse.Size = new System.Drawing.Size(178, 24);
            this.labelRequestResponse.TabIndex = 96;
            this.labelRequestResponse.Text = "Request Response:";
            this.labelRequestResponse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDateFromatPart2
            // 
            this.labelDateFromatPart2.AutoSize = true;
            this.labelDateFromatPart2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFromatPart2.ForeColor = System.Drawing.Color.White;
            this.labelDateFromatPart2.Location = new System.Drawing.Point(146, 222);
            this.labelDateFromatPart2.Name = "labelDateFromatPart2";
            this.labelDateFromatPart2.Size = new System.Drawing.Size(121, 17);
            this.labelDateFromatPart2.TabIndex = 99;
            this.labelDateFromatPart2.Text = "Day-Month-Year)";
            // 
            // labelDateFromatPart1
            // 
            this.labelDateFromatPart1.AutoSize = true;
            this.labelDateFromatPart1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFromatPart1.ForeColor = System.Drawing.Color.White;
            this.labelDateFromatPart1.Location = new System.Drawing.Point(146, 205);
            this.labelDateFromatPart1.Name = "labelDateFromatPart1";
            this.labelDateFromatPart1.Size = new System.Drawing.Size(65, 17);
            this.labelDateFromatPart1.TabIndex = 98;
            this.labelDateFromatPart1.Text = "(Format:";
            // 
            // textBoxRequestDate
            // 
            this.textBoxRequestDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRequestDate.Location = new System.Drawing.Point(279, 205);
            this.textBoxRequestDate.Mask = "00-00-0000";
            this.textBoxRequestDate.Name = "textBoxRequestDate";
            this.textBoxRequestDate.Size = new System.Drawing.Size(70, 26);
            this.textBoxRequestDate.TabIndex = 101;
            // 
            // comboBoxRequestStatus
            // 
            this.comboBoxRequestStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRequestStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRequestStatus.FormattingEnabled = true;
            this.comboBoxRequestStatus.Items.AddRange(new object[] {
            "",
            "Pending",
            "Accepted",
            "Rejected"});
            this.comboBoxRequestStatus.Location = new System.Drawing.Point(279, 246);
            this.comboBoxRequestStatus.Name = "comboBoxRequestStatus";
            this.comboBoxRequestStatus.Size = new System.Drawing.Size(96, 28);
            this.comboBoxRequestStatus.TabIndex = 102;
            // 
            // textBoxRequestResponse
            // 
            this.textBoxRequestResponse.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRequestResponse.Location = new System.Drawing.Point(433, 158);
            this.textBoxRequestResponse.Name = "textBoxRequestResponse";
            this.textBoxRequestResponse.Size = new System.Drawing.Size(231, 207);
            this.textBoxRequestResponse.TabIndex = 103;
            this.textBoxRequestResponse.Text = "";
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRequest.Location = new System.Drawing.Point(107, 285);
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.Size = new System.Drawing.Size(298, 80);
            this.textBoxRequest.TabIndex = 104;
            this.textBoxRequest.Text = "";
            // 
            // comboBoxUserID
            // 
            this.comboBoxUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserID.FormattingEnabled = true;
            this.comboBoxUserID.Location = new System.Drawing.Point(279, 167);
            this.comboBoxUserID.Name = "comboBoxUserID";
            this.comboBoxUserID.Size = new System.Drawing.Size(41, 28);
            this.comboBoxUserID.TabIndex = 105;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(381, 376);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(118, 43);
            this.buttonCancel.TabIndex = 107;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRespond
            // 
            this.buttonRespond.Location = new System.Drawing.Point(257, 376);
            this.buttonRespond.Name = "buttonRespond";
            this.buttonRespond.Size = new System.Drawing.Size(118, 43);
            this.buttonRespond.TabIndex = 106;
            this.buttonRespond.Text = "Respond";
            this.buttonRespond.UseVisualStyleBackColor = true;
            this.buttonRespond.Click += new System.EventHandler(this.buttonRespond_Click);
            // 
            // DoctorRespondToRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(678, 431);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRespond);
            this.Controls.Add(this.comboBoxUserID);
            this.Controls.Add(this.textBoxRequest);
            this.Controls.Add(this.textBoxRequestResponse);
            this.Controls.Add(this.comboBoxRequestStatus);
            this.Controls.Add(this.textBoxRequestDate);
            this.Controls.Add(this.labelDateFromatPart2);
            this.Controls.Add(this.labelDateFromatPart1);
            this.Controls.Add(this.labelRequestResponse);
            this.Controls.Add(this.labelRequest);
            this.Controls.Add(this.labelRequestStatus);
            this.Controls.Add(this.labelRequestDate);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.textBoxRequestID);
            this.Controls.Add(this.buttonFindID);
            this.Controls.Add(this.labelRequestID);
            this.Controls.Add(this.panelWhiteTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorRespondToRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorRespondToRequest";
            this.Load += new System.EventHandler(this.DoctorRespondToRequest_Load);
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelRespondToRequestText;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.Label labelRequestID;
        private System.Windows.Forms.MaskedTextBox textBoxRequestID;
        private System.Windows.Forms.Button buttonFindID;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelRequestDate;
        private System.Windows.Forms.Label labelRequestStatus;
        private System.Windows.Forms.Label labelRequest;
        private System.Windows.Forms.Label labelRequestResponse;
        private System.Windows.Forms.Label labelDateFromatPart2;
        private System.Windows.Forms.Label labelDateFromatPart1;
        private System.Windows.Forms.MaskedTextBox textBoxRequestDate;
        private System.Windows.Forms.ComboBox comboBoxRequestStatus;
        private System.Windows.Forms.RichTextBox textBoxRequestResponse;
        private System.Windows.Forms.RichTextBox textBoxRequest;
        private System.Windows.Forms.ComboBox comboBoxUserID;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRespond;
    }
}