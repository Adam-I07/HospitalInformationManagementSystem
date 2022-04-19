
namespace HospitalInformationManagementSystem.NursesMenus
{
    partial class NurseRequestMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseRequestMenu));
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelRequestMenuText = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonSubmitRequest = new System.Windows.Forms.Button();
            this.buttonViewRequests = new System.Windows.Forms.Button();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelRequestMenuText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(0, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(417, 87);
            this.panelWhiteTop.TabIndex = 6;
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(378, 9);
            this.labelGoBack.Name = "labelGoBack";
            this.labelGoBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGoBack.Size = new System.Drawing.Size(36, 15);
            this.labelGoBack.TabIndex = 9;
            this.labelGoBack.Text = "Back";
            this.labelGoBack.Click += new System.EventHandler(this.labelGoBack_Click);
            // 
            // pictureBoxGoBack
            // 
            this.pictureBoxGoBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGoBack.Image")));
            this.pictureBoxGoBack.Location = new System.Drawing.Point(356, -6);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 8;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelRequestMenuText
            // 
            this.labelRequestMenuText.AutoSize = true;
            this.labelRequestMenuText.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestMenuText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelRequestMenuText.Location = new System.Drawing.Point(101, 25);
            this.labelRequestMenuText.Name = "labelRequestMenuText";
            this.labelRequestMenuText.Size = new System.Drawing.Size(248, 42);
            this.labelRequestMenuText.TabIndex = 5;
            this.labelRequestMenuText.Text = "Request Menu";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(-10, -12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(131, 116);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonSubmitRequest
            // 
            this.buttonSubmitRequest.Location = new System.Drawing.Point(86, 110);
            this.buttonSubmitRequest.Name = "buttonSubmitRequest";
            this.buttonSubmitRequest.Size = new System.Drawing.Size(241, 50);
            this.buttonSubmitRequest.TabIndex = 8;
            this.buttonSubmitRequest.Text = "Submit A Request";
            this.buttonSubmitRequest.UseVisualStyleBackColor = true;
            this.buttonSubmitRequest.Click += new System.EventHandler(this.buttonSubmitRequest_Click);
            // 
            // buttonViewRequests
            // 
            this.buttonViewRequests.Location = new System.Drawing.Point(86, 177);
            this.buttonViewRequests.Name = "buttonViewRequests";
            this.buttonViewRequests.Size = new System.Drawing.Size(241, 50);
            this.buttonViewRequests.TabIndex = 9;
            this.buttonViewRequests.Text = "View Existing Request";
            this.buttonViewRequests.UseVisualStyleBackColor = true;
            this.buttonViewRequests.Click += new System.EventHandler(this.buttonViewRequests_Click);
            // 
            // NurseRequestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(414, 252);
            this.Controls.Add(this.buttonViewRequests);
            this.Controls.Add(this.buttonSubmitRequest);
            this.Controls.Add(this.panelWhiteTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NurseRequestMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NurseRequestMenu";
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.Label labelRequestMenuText;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Button buttonSubmitRequest;
        private System.Windows.Forms.Button buttonViewRequests;
    }
}