
namespace HospitalInformationManagementSystem
{
    partial class AdminMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainMenu));
            this.panelWhiteBottom = new System.Windows.Forms.Panel();
            this.labelHospitalName = new System.Windows.Forms.Label();
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelAdminMenu = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogOutLogo = new System.Windows.Forms.PictureBox();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.pictureBoxLoginDetails = new System.Windows.Forms.PictureBox();
            this.labelLoginDetails = new System.Windows.Forms.Label();
            this.panelWhiteBottom.SuspendLayout();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOutLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWhiteBottom
            // 
            this.panelWhiteBottom.BackColor = System.Drawing.Color.White;
            this.panelWhiteBottom.Controls.Add(this.labelHospitalName);
            this.panelWhiteBottom.Location = new System.Drawing.Point(-4, 248);
            this.panelWhiteBottom.Name = "panelWhiteBottom";
            this.panelWhiteBottom.Size = new System.Drawing.Size(468, 42);
            this.panelWhiteBottom.TabIndex = 2;
            // 
            // labelHospitalName
            // 
            this.labelHospitalName.AutoSize = true;
            this.labelHospitalName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHospitalName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelHospitalName.Location = new System.Drawing.Point(48, 7);
            this.labelHospitalName.Name = "labelHospitalName";
            this.labelHospitalName.Size = new System.Drawing.Size(392, 24);
            this.labelHospitalName.TabIndex = 2;
            this.labelHospitalName.Text = "Hospital Information Management System ";
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelAdminMenu);
            this.panelWhiteTop.Controls.Add(this.pictureBoxLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-4, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(468, 87);
            this.panelWhiteTop.TabIndex = 3;
            // 
            // labelAdminMenu
            // 
            this.labelAdminMenu.AutoSize = true;
            this.labelAdminMenu.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminMenu.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelAdminMenu.Location = new System.Drawing.Point(80, 24);
            this.labelAdminMenu.Name = "labelAdminMenu";
            this.labelAdminMenu.Size = new System.Drawing.Size(229, 42);
            this.labelAdminMenu.TabIndex = 5;
            this.labelAdminMenu.Text = "Admin Menu";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(288, -12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(131, 116);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxLogOutLogo
            // 
            this.pictureBoxLogOutLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogOutLogo.Image")));
            this.pictureBoxLogOutLogo.Location = new System.Drawing.Point(261, 93);
            this.pictureBoxLogOutLogo.Name = "pictureBoxLogOutLogo";
            this.pictureBoxLogOutLogo.Size = new System.Drawing.Size(130, 133);
            this.pictureBoxLogOutLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogOutLogo.TabIndex = 4;
            this.pictureBoxLogOutLogo.TabStop = false;
            this.pictureBoxLogOutLogo.Click += new System.EventHandler(this.pictureBoxLogOutLogo_Click);
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.ForeColor = System.Drawing.Color.White;
            this.labelLogOut.Location = new System.Drawing.Point(280, 221);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(85, 24);
            this.labelLogOut.TabIndex = 5;
            this.labelLogOut.Text = "Log Out";
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // pictureBoxLoginDetails
            // 
            this.pictureBoxLoginDetails.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoginDetails.Image")));
            this.pictureBoxLoginDetails.Location = new System.Drawing.Point(64, 93);
            this.pictureBoxLoginDetails.Name = "pictureBoxLoginDetails";
            this.pictureBoxLoginDetails.Size = new System.Drawing.Size(124, 133);
            this.pictureBoxLoginDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoginDetails.TabIndex = 6;
            this.pictureBoxLoginDetails.TabStop = false;
            this.pictureBoxLoginDetails.Click += new System.EventHandler(this.pictureBoxLoginDetails_Click);
            // 
            // labelLoginDetails
            // 
            this.labelLoginDetails.AutoSize = true;
            this.labelLoginDetails.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginDetails.ForeColor = System.Drawing.Color.White;
            this.labelLoginDetails.Location = new System.Drawing.Point(60, 221);
            this.labelLoginDetails.Name = "labelLoginDetails";
            this.labelLoginDetails.Size = new System.Drawing.Size(128, 24);
            this.labelLoginDetails.TabIndex = 7;
            this.labelLoginDetails.Text = "Login Details";
            this.labelLoginDetails.Click += new System.EventHandler(this.labelLoginDetails_Click);
            // 
            // AdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(460, 288);
            this.Controls.Add(this.labelLoginDetails);
            this.Controls.Add(this.pictureBoxLoginDetails);
            this.Controls.Add(this.labelLogOut);
            this.Controls.Add(this.pictureBoxLogOutLogo);
            this.Controls.Add(this.panelWhiteTop);
            this.Controls.Add(this.panelWhiteBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.panelWhiteBottom.ResumeLayout(false);
            this.panelWhiteBottom.PerformLayout();
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogOutLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelWhiteBottom;
        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelAdminMenu;
        private System.Windows.Forms.Label labelHospitalName;
        private System.Windows.Forms.PictureBox pictureBoxLogOutLogo;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.PictureBox pictureBoxLoginDetails;
        private System.Windows.Forms.Label labelLoginDetails;
    }
}