
namespace HospitalInformationManagementSystem.DoctorsMenus
{
    partial class DoctorRequestMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorRequestMenu));
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelRequestMenuText = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewRequestsView = new System.Windows.Forms.DataGridView();
            this.ColumnRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRequestStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRequestResponse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRespondToRequest = new System.Windows.Forms.Button();
            this.buttonViewRequest = new System.Windows.Forms.Button();
            this.buttonDeleteRequest = new System.Windows.Forms.Button();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestsView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelRequestMenuText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-2, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(868, 125);
            this.panelWhiteTop.TabIndex = 10;
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(818, 19);
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
            this.pictureBoxGoBack.Location = new System.Drawing.Point(796, 4);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelRequestMenuText
            // 
            this.labelRequestMenuText.AutoSize = true;
            this.labelRequestMenuText.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestMenuText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelRequestMenuText.Location = new System.Drawing.Point(330, 43);
            this.labelRequestMenuText.Name = "labelRequestMenuText";
            this.labelRequestMenuText.Size = new System.Drawing.Size(248, 42);
            this.labelRequestMenuText.TabIndex = 5;
            this.labelRequestMenuText.Text = "Request Menu";
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
            this.dataGridViewRequestsView.Location = new System.Drawing.Point(150, 157);
            this.dataGridViewRequestsView.Name = "dataGridViewRequestsView";
            this.dataGridViewRequestsView.ReadOnly = true;
            this.dataGridViewRequestsView.Size = new System.Drawing.Size(692, 281);
            this.dataGridViewRequestsView.TabIndex = 11;
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
            this.ColumnRequest.Width = 240;
            // 
            // ColumnRequestResponse
            // 
            this.ColumnRequestResponse.DataPropertyName = "RequestResponse";
            this.ColumnRequestResponse.HeaderText = "Request Response";
            this.ColumnRequestResponse.Name = "ColumnRequestResponse";
            this.ColumnRequestResponse.ReadOnly = true;
            this.ColumnRequestResponse.Width = 160;
            // 
            // buttonRespondToRequest
            // 
            this.buttonRespondToRequest.Location = new System.Drawing.Point(12, 157);
            this.buttonRespondToRequest.Name = "buttonRespondToRequest";
            this.buttonRespondToRequest.Size = new System.Drawing.Size(132, 45);
            this.buttonRespondToRequest.TabIndex = 12;
            this.buttonRespondToRequest.Text = "Respond To Request";
            this.buttonRespondToRequest.UseVisualStyleBackColor = true;
            this.buttonRespondToRequest.Click += new System.EventHandler(this.buttonRespondToRequest_Click);
            // 
            // buttonViewRequest
            // 
            this.buttonViewRequest.Location = new System.Drawing.Point(12, 219);
            this.buttonViewRequest.Name = "buttonViewRequest";
            this.buttonViewRequest.Size = new System.Drawing.Size(132, 45);
            this.buttonViewRequest.TabIndex = 13;
            this.buttonViewRequest.Text = "View Request";
            this.buttonViewRequest.UseVisualStyleBackColor = true;
            this.buttonViewRequest.Click += new System.EventHandler(this.buttonViewRequest_Click);
            // 
            // buttonDeleteRequest
            // 
            this.buttonDeleteRequest.Location = new System.Drawing.Point(12, 282);
            this.buttonDeleteRequest.Name = "buttonDeleteRequest";
            this.buttonDeleteRequest.Size = new System.Drawing.Size(132, 45);
            this.buttonDeleteRequest.TabIndex = 14;
            this.buttonDeleteRequest.Text = "Delete Request";
            this.buttonDeleteRequest.UseVisualStyleBackColor = true;
            this.buttonDeleteRequest.Click += new System.EventHandler(this.buttonDeleteRequest_Click);
            // 
            // DoctorRequestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.buttonDeleteRequest);
            this.Controls.Add(this.buttonViewRequest);
            this.Controls.Add(this.buttonRespondToRequest);
            this.Controls.Add(this.dataGridViewRequestsView);
            this.Controls.Add(this.panelWhiteTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorRequestMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorRequestMenu";
            this.Load += new System.EventHandler(this.DoctorRequestMenu_Load);
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequestsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelRequestMenuText;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.DataGridView dataGridViewRequestsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRequestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRequestStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRequestResponse;
        private System.Windows.Forms.Button buttonRespondToRequest;
        private System.Windows.Forms.Button buttonViewRequest;
        private System.Windows.Forms.Button buttonDeleteRequest;
    }
}