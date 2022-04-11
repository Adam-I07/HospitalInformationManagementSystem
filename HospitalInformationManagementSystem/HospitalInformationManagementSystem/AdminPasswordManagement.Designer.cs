
namespace HospitalInformationManagementSystem
{
    partial class AdminPasswordManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPasswordManagement));
            this.dataGridViewLoginDetails = new System.Windows.Forms.DataGridView();
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelLoginManagement = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginDetails)).BeginInit();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLoginDetails
            // 
            this.dataGridViewLoginDetails.AllowUserToAddRows = false;
            this.dataGridViewLoginDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoginDetails.Location = new System.Drawing.Point(349, 131);
            this.dataGridViewLoginDetails.Name = "dataGridViewLoginDetails";
            this.dataGridViewLoginDetails.ReadOnly = true;
            this.dataGridViewLoginDetails.Size = new System.Drawing.Size(439, 354);
            this.dataGridViewLoginDetails.TabIndex = 0;
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelLoginManagement);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-2, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(804, 125);
            this.panelWhiteTop.TabIndex = 8;
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(754, 18);
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
            this.pictureBoxGoBack.Location = new System.Drawing.Point(732, 3);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelLoginManagement
            // 
            this.labelLoginManagement.AutoSize = true;
            this.labelLoginManagement.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginManagement.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelLoginManagement.Location = new System.Drawing.Point(113, 45);
            this.labelLoginManagement.Name = "labelLoginManagement";
            this.labelLoginManagement.Size = new System.Drawing.Size(512, 42);
            this.labelLoginManagement.TabIndex = 5;
            this.labelLoginManagement.Text = "User Login Detail Management";
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
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.Location = new System.Drawing.Point(12, 152);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(331, 55);
            this.buttonAddNewUser.TabIndex = 9;
            this.buttonAddNewUser.Text = "Add New User";
            this.buttonAddNewUser.UseVisualStyleBackColor = true;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(12, 222);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(331, 55);
            this.buttonEditUser.TabIndex = 10;
            this.buttonEditUser.Text = "Edit A User";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "Delete User";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminPasswordManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonAddNewUser);
            this.Controls.Add(this.panelWhiteTop);
            this.Controls.Add(this.dataGridViewLoginDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPasswordManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPasswordManagement";
            this.Load += new System.EventHandler(this.AdminPasswordManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginDetails)).EndInit();
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLoginDetails;
        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.Label labelLoginManagement;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button button1;
    }
}