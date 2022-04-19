
namespace HospitalInformationManagementSystem.NursesMenus
{
    partial class NurseViewExistingRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseViewExistingRequests));
            this.dataGridViewRequestsView = new System.Windows.Forms.DataGridView();
            this.ColumnRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRequestStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRequestResponse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelViewExistingRequestText = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestsView)).BeginInit();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRequestsView
            // 
            this.dataGridViewRequestsView.AllowUserToAddRows = false;
            this.dataGridViewRequestsView.AllowUserToDeleteRows = false;
            this.dataGridViewRequestsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequestsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRequestID,
            this.ColumnUserID,
            this.ColumnRequestDate,
            this.ColumnRequestStatus,
            this.ColumnRequest,
            this.ColumnRequestResponse});
            this.dataGridViewRequestsView.Location = new System.Drawing.Point(12, 187);
            this.dataGridViewRequestsView.Name = "dataGridViewRequestsView";
            this.dataGridViewRequestsView.ReadOnly = true;
            this.dataGridViewRequestsView.Size = new System.Drawing.Size(763, 301);
            this.dataGridViewRequestsView.TabIndex = 12;
            // 
            // ColumnRequestID
            // 
            this.ColumnRequestID.DataPropertyName = "RequestID";
            this.ColumnRequestID.HeaderText = "RequestID";
            this.ColumnRequestID.Name = "ColumnRequestID";
            this.ColumnRequestID.ReadOnly = true;
            this.ColumnRequestID.Width = 60;
            // 
            // ColumnUserID
            // 
            this.ColumnUserID.DataPropertyName = "UserID";
            this.ColumnUserID.HeaderText = "UserID";
            this.ColumnUserID.Name = "ColumnUserID";
            this.ColumnUserID.ReadOnly = true;
            this.ColumnUserID.Width = 50;
            // 
            // ColumnRequestDate
            // 
            this.ColumnRequestDate.DataPropertyName = "RequestDate";
            this.ColumnRequestDate.HeaderText = "Request Date";
            this.ColumnRequestDate.Name = "ColumnRequestDate";
            this.ColumnRequestDate.ReadOnly = true;
            this.ColumnRequestDate.Width = 70;
            // 
            // ColumnRequestStatus
            // 
            this.ColumnRequestStatus.DataPropertyName = "RequestStatus";
            this.ColumnRequestStatus.HeaderText = "Request Status";
            this.ColumnRequestStatus.Name = "ColumnRequestStatus";
            this.ColumnRequestStatus.ReadOnly = true;
            this.ColumnRequestStatus.Width = 70;
            // 
            // ColumnRequest
            // 
            this.ColumnRequest.DataPropertyName = "Request";
            this.ColumnRequest.HeaderText = "Request";
            this.ColumnRequest.Name = "ColumnRequest";
            this.ColumnRequest.ReadOnly = true;
            this.ColumnRequest.Width = 270;
            // 
            // ColumnRequestResponse
            // 
            this.ColumnRequestResponse.DataPropertyName = "RequestResponse";
            this.ColumnRequestResponse.HeaderText = "Request Response";
            this.ColumnRequestResponse.Name = "ColumnRequestResponse";
            this.ColumnRequestResponse.ReadOnly = true;
            this.ColumnRequestResponse.Width = 200;
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelViewExistingRequestText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-5, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(801, 112);
            this.panelWhiteTop.TabIndex = 13;
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(758, 19);
            this.labelGoBack.Name = "labelGoBack";
            this.labelGoBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGoBack.Size = new System.Drawing.Size(36, 15);
            this.labelGoBack.TabIndex = 7;
            this.labelGoBack.Text = "Back";
            // 
            // pictureBoxGoBack
            // 
            this.pictureBoxGoBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGoBack.Image")));
            this.pictureBoxGoBack.Location = new System.Drawing.Point(736, 4);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            // 
            // labelViewExistingRequestText
            // 
            this.labelViewExistingRequestText.AutoSize = true;
            this.labelViewExistingRequestText.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewExistingRequestText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelViewExistingRequestText.Location = new System.Drawing.Point(240, 34);
            this.labelViewExistingRequestText.Name = "labelViewExistingRequestText";
            this.labelViewExistingRequestText.Size = new System.Drawing.Size(384, 42);
            this.labelViewExistingRequestText.TabIndex = 5;
            this.labelViewExistingRequestText.Text = "View Existing Requests";
            // 
            // pictureBoxHospitalLogo
            // 
            this.pictureBoxHospitalLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHospitalLogo.Image")));
            this.pictureBoxHospitalLogo.Location = new System.Drawing.Point(0, -4);
            this.pictureBoxHospitalLogo.Name = "pictureBoxHospitalLogo";
            this.pictureBoxHospitalLogo.Size = new System.Drawing.Size(131, 116);
            this.pictureBoxHospitalLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHospitalLogo.TabIndex = 4;
            this.pictureBoxHospitalLogo.TabStop = false;
            // 
            // NurseViewExistingRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(789, 500);
            this.Controls.Add(this.panelWhiteTop);
            this.Controls.Add(this.dataGridViewRequestsView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NurseViewExistingRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NurseViewExistingRequests";
            this.Load += new System.EventHandler(this.NurseViewExistingRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestsView)).EndInit();
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRequestsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRequestStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRequestResponse;
        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelViewExistingRequestText;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
    }
}