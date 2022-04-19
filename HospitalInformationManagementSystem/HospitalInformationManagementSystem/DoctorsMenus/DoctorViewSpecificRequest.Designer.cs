
namespace HospitalInformationManagementSystem.DoctorsMenus
{
    partial class DoctorViewSpecificRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorViewSpecificRequest));
            this.textBoxRequestID = new System.Windows.Forms.MaskedTextBox();
            this.buttonFindID = new System.Windows.Forms.Button();
            this.labelRequestID = new System.Windows.Forms.Label();
            this.textBoxRequestInput = new System.Windows.Forms.RichTextBox();
            this.labelDateFromatPart2 = new System.Windows.Forms.Label();
            this.labelDateFromatPart1 = new System.Windows.Forms.Label();
            this.labelRequest = new System.Windows.Forms.Label();
            this.labelRequestStatus = new System.Windows.Forms.Label();
            this.labelRequestDate = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelRequestDateInput = new System.Windows.Forms.Label();
            this.labelUserIDInput = new System.Windows.Forms.Label();
            this.labelRequestStatusInput = new System.Windows.Forms.Label();
            this.textBoxRequestResponseInput = new System.Windows.Forms.RichTextBox();
            this.labelRequestResponse = new System.Windows.Forms.Label();
            this.buttonNewSearch = new System.Windows.Forms.Button();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.labelViewRequestText = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            this.panelWhiteTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRequestID
            // 
            this.textBoxRequestID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRequestID.Location = new System.Drawing.Point(215, 118);
            this.textBoxRequestID.Mask = "00000";
            this.textBoxRequestID.Name = "textBoxRequestID";
            this.textBoxRequestID.Size = new System.Drawing.Size(41, 26);
            this.textBoxRequestID.TabIndex = 94;
            this.textBoxRequestID.ValidatingType = typeof(int);
            // 
            // buttonFindID
            // 
            this.buttonFindID.Location = new System.Drawing.Point(262, 118);
            this.buttonFindID.Name = "buttonFindID";
            this.buttonFindID.Size = new System.Drawing.Size(40, 26);
            this.buttonFindID.TabIndex = 93;
            this.buttonFindID.Text = "Find";
            this.buttonFindID.UseVisualStyleBackColor = true;
            this.buttonFindID.Click += new System.EventHandler(this.buttonFindID_Click);
            // 
            // labelRequestID
            // 
            this.labelRequestID.AutoSize = true;
            this.labelRequestID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestID.ForeColor = System.Drawing.Color.White;
            this.labelRequestID.Location = new System.Drawing.Point(12, 119);
            this.labelRequestID.Name = "labelRequestID";
            this.labelRequestID.Size = new System.Drawing.Size(116, 24);
            this.labelRequestID.TabIndex = 92;
            this.labelRequestID.Text = "Request ID:";
            this.labelRequestID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxRequestInput
            // 
            this.textBoxRequestInput.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRequestInput.Location = new System.Drawing.Point(107, 253);
            this.textBoxRequestInput.Name = "textBoxRequestInput";
            this.textBoxRequestInput.Size = new System.Drawing.Size(298, 100);
            this.textBoxRequestInput.TabIndex = 111;
            this.textBoxRequestInput.Text = "";
            // 
            // labelDateFromatPart2
            // 
            this.labelDateFromatPart2.AutoSize = true;
            this.labelDateFromatPart2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFromatPart2.ForeColor = System.Drawing.Color.White;
            this.labelDateFromatPart2.Location = new System.Drawing.Point(146, 203);
            this.labelDateFromatPart2.Name = "labelDateFromatPart2";
            this.labelDateFromatPart2.Size = new System.Drawing.Size(121, 17);
            this.labelDateFromatPart2.TabIndex = 110;
            this.labelDateFromatPart2.Text = "Day-Month-Year)";
            // 
            // labelDateFromatPart1
            // 
            this.labelDateFromatPart1.AutoSize = true;
            this.labelDateFromatPart1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFromatPart1.ForeColor = System.Drawing.Color.White;
            this.labelDateFromatPart1.Location = new System.Drawing.Point(146, 186);
            this.labelDateFromatPart1.Name = "labelDateFromatPart1";
            this.labelDateFromatPart1.Size = new System.Drawing.Size(65, 17);
            this.labelDateFromatPart1.TabIndex = 109;
            this.labelDateFromatPart1.Text = "(Format:";
            // 
            // labelRequest
            // 
            this.labelRequest.AutoSize = true;
            this.labelRequest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequest.ForeColor = System.Drawing.Color.White;
            this.labelRequest.Location = new System.Drawing.Point(12, 253);
            this.labelRequest.Name = "labelRequest";
            this.labelRequest.Size = new System.Drawing.Size(89, 24);
            this.labelRequest.TabIndex = 108;
            this.labelRequest.Text = "Request:";
            this.labelRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRequestStatus
            // 
            this.labelRequestStatus.AutoSize = true;
            this.labelRequestStatus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestStatus.ForeColor = System.Drawing.Color.White;
            this.labelRequestStatus.Location = new System.Drawing.Point(12, 220);
            this.labelRequestStatus.Name = "labelRequestStatus";
            this.labelRequestStatus.Size = new System.Drawing.Size(150, 24);
            this.labelRequestStatus.TabIndex = 107;
            this.labelRequestStatus.Text = "Request Status:";
            this.labelRequestStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRequestDate
            // 
            this.labelRequestDate.AutoSize = true;
            this.labelRequestDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestDate.ForeColor = System.Drawing.Color.White;
            this.labelRequestDate.Location = new System.Drawing.Point(12, 186);
            this.labelRequestDate.Name = "labelRequestDate";
            this.labelRequestDate.Size = new System.Drawing.Size(137, 24);
            this.labelRequestDate.TabIndex = 106;
            this.labelRequestDate.Text = "Request Date:";
            this.labelRequestDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.ForeColor = System.Drawing.Color.White;
            this.labelUserID.Location = new System.Drawing.Point(12, 152);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(85, 24);
            this.labelUserID.TabIndex = 105;
            this.labelUserID.Text = "User ID:";
            this.labelUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRequestDateInput
            // 
            this.labelRequestDateInput.AutoSize = true;
            this.labelRequestDateInput.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestDateInput.ForeColor = System.Drawing.Color.White;
            this.labelRequestDateInput.Location = new System.Drawing.Point(275, 186);
            this.labelRequestDateInput.Name = "labelRequestDateInput";
            this.labelRequestDateInput.Size = new System.Drawing.Size(0, 24);
            this.labelRequestDateInput.TabIndex = 112;
            this.labelRequestDateInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUserIDInput
            // 
            this.labelUserIDInput.AutoSize = true;
            this.labelUserIDInput.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserIDInput.ForeColor = System.Drawing.Color.White;
            this.labelUserIDInput.Location = new System.Drawing.Point(275, 152);
            this.labelUserIDInput.Name = "labelUserIDInput";
            this.labelUserIDInput.Size = new System.Drawing.Size(0, 24);
            this.labelUserIDInput.TabIndex = 113;
            this.labelUserIDInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRequestStatusInput
            // 
            this.labelRequestStatusInput.AutoSize = true;
            this.labelRequestStatusInput.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestStatusInput.ForeColor = System.Drawing.Color.White;
            this.labelRequestStatusInput.Location = new System.Drawing.Point(275, 220);
            this.labelRequestStatusInput.Name = "labelRequestStatusInput";
            this.labelRequestStatusInput.Size = new System.Drawing.Size(0, 24);
            this.labelRequestStatusInput.TabIndex = 114;
            this.labelRequestStatusInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxRequestResponseInput
            // 
            this.textBoxRequestResponseInput.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRequestResponseInput.Location = new System.Drawing.Point(422, 146);
            this.textBoxRequestResponseInput.Name = "textBoxRequestResponseInput";
            this.textBoxRequestResponseInput.Size = new System.Drawing.Size(231, 207);
            this.textBoxRequestResponseInput.TabIndex = 116;
            this.textBoxRequestResponseInput.Text = "";
            // 
            // labelRequestResponse
            // 
            this.labelRequestResponse.AutoSize = true;
            this.labelRequestResponse.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestResponse.ForeColor = System.Drawing.Color.White;
            this.labelRequestResponse.Location = new System.Drawing.Point(418, 119);
            this.labelRequestResponse.Name = "labelRequestResponse";
            this.labelRequestResponse.Size = new System.Drawing.Size(178, 24);
            this.labelRequestResponse.TabIndex = 115;
            this.labelRequestResponse.Text = "Request Response:";
            this.labelRequestResponse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonNewSearch
            // 
            this.buttonNewSearch.Location = new System.Drawing.Point(308, 118);
            this.buttonNewSearch.Name = "buttonNewSearch";
            this.buttonNewSearch.Size = new System.Drawing.Size(75, 26);
            this.buttonNewSearch.TabIndex = 135;
            this.buttonNewSearch.Text = "New Search";
            this.buttonNewSearch.UseVisualStyleBackColor = true;
            this.buttonNewSearch.Click += new System.EventHandler(this.buttonNewSearch_Click);
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
            // labelViewRequestText
            // 
            this.labelViewRequestText.AutoSize = true;
            this.labelViewRequestText.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewRequestText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelViewRequestText.Location = new System.Drawing.Point(194, 37);
            this.labelViewRequestText.Name = "labelViewRequestText";
            this.labelViewRequestText.Size = new System.Drawing.Size(364, 42);
            this.labelViewRequestText.TabIndex = 5;
            this.labelViewRequestText.Text = "View Specific Request";
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
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelViewRequestText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-2, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(685, 107);
            this.panelWhiteTop.TabIndex = 12;
            // 
            // DoctorViewSpecificRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(678, 373);
            this.Controls.Add(this.buttonNewSearch);
            this.Controls.Add(this.textBoxRequestResponseInput);
            this.Controls.Add(this.labelRequestResponse);
            this.Controls.Add(this.labelRequestStatusInput);
            this.Controls.Add(this.labelUserIDInput);
            this.Controls.Add(this.labelRequestDateInput);
            this.Controls.Add(this.textBoxRequestInput);
            this.Controls.Add(this.labelDateFromatPart2);
            this.Controls.Add(this.labelDateFromatPart1);
            this.Controls.Add(this.labelRequest);
            this.Controls.Add(this.labelRequestStatus);
            this.Controls.Add(this.labelRequestDate);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.textBoxRequestID);
            this.Controls.Add(this.buttonFindID);
            this.Controls.Add(this.labelRequestID);
            this.Controls.Add(this.panelWhiteTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorViewSpecificRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorViewSpecificRequest";
            this.Load += new System.EventHandler(this.DoctorViewSpecificRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox textBoxRequestID;
        private System.Windows.Forms.Button buttonFindID;
        private System.Windows.Forms.Label labelRequestID;
        private System.Windows.Forms.Label labelDateFromatPart2;
        private System.Windows.Forms.Label labelDateFromatPart1;
        private System.Windows.Forms.Label labelRequest;
        private System.Windows.Forms.Label labelRequestStatus;
        private System.Windows.Forms.Label labelRequestDate;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelRequestDateInput;
        private System.Windows.Forms.Label labelUserIDInput;
        private System.Windows.Forms.Label labelRequestStatusInput;
        private System.Windows.Forms.RichTextBox textBoxRequestResponseInput;
        private System.Windows.Forms.Label labelRequestResponse;
        private System.Windows.Forms.RichTextBox textBoxRequestInput;
        private System.Windows.Forms.Button buttonNewSearch;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.Label labelViewRequestText;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.Panel panelWhiteTop;
    }
}