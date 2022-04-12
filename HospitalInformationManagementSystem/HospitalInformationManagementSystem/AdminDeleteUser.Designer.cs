
namespace HospitalInformationManagementSystem
{
    partial class AdminDeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDeleteUser));
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelDeleteUser = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.labelUserID = new System.Windows.Forms.Label();
            this.dataGridViewShowUserDetail = new System.Windows.Forms.DataGridView();
            this.textBoxUserID = new System.Windows.Forms.MaskedTextBox();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowUserDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelDeleteUser);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-2, -1);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(455, 117);
            this.panelWhiteTop.TabIndex = 10;
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(412, 18);
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
            this.pictureBoxGoBack.Location = new System.Drawing.Point(392, 3);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelDeleteUser
            // 
            this.labelDeleteUser.AutoSize = true;
            this.labelDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelDeleteUser.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteUser.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelDeleteUser.Location = new System.Drawing.Point(149, 29);
            this.labelDeleteUser.Name = "labelDeleteUser";
            this.labelDeleteUser.Size = new System.Drawing.Size(197, 42);
            this.labelDeleteUser.TabIndex = 5;
            this.labelDeleteUser.Text = "Delete User";
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
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(244, 191);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(70, 26);
            this.buttonDeleteUser.TabIndex = 33;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.ForeColor = System.Drawing.Color.White;
            this.labelUserID.Location = new System.Drawing.Point(178, 132);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(85, 24);
            this.labelUserID.TabIndex = 32;
            this.labelUserID.Text = "User ID:";
            // 
            // dataGridViewShowUserDetail
            // 
            this.dataGridViewShowUserDetail.AllowUserToAddRows = false;
            this.dataGridViewShowUserDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowUserDetail.Location = new System.Drawing.Point(4, 237);
            this.dataGridViewShowUserDetail.Name = "dataGridViewShowUserDetail";
            this.dataGridViewShowUserDetail.ReadOnly = true;
            this.dataGridViewShowUserDetail.Size = new System.Drawing.Size(441, 201);
            this.dataGridViewShowUserDetail.TabIndex = 35;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserID.Location = new System.Drawing.Point(182, 159);
            this.textBoxUserID.Mask = "00000";
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(132, 26);
            this.textBoxUserID.TabIndex = 36;
            this.textBoxUserID.ValidatingType = typeof(int);
            // 
            // AdminDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.dataGridViewShowUserDetail);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.panelWhiteTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDeleteUser";
            this.Load += new System.EventHandler(this.AdminDeleteUser_Load);
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowUserDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelDeleteUser;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.DataGridView dataGridViewShowUserDetail;
        private System.Windows.Forms.MaskedTextBox textBoxUserID;
    }
}