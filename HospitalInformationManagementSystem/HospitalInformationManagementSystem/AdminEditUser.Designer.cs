﻿
namespace HospitalInformationManagementSystem
{
    partial class AdminEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEditUser));
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelEditUser = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonFindID = new System.Windows.Forms.Button();
            this.textBoxUserID = new System.Windows.Forms.MaskedTextBox();
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
            this.panelWhiteTop.Controls.Add(this.labelEditUser);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-1, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(494, 125);
            this.panelWhiteTop.TabIndex = 9;
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(456, 15);
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
            this.pictureBoxGoBack.Location = new System.Drawing.Point(436, 0);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelEditUser
            // 
            this.labelEditUser.AutoSize = true;
            this.labelEditUser.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditUser.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelEditUser.Location = new System.Drawing.Point(123, 32);
            this.labelEditUser.Name = "labelEditUser";
            this.labelEditUser.Size = new System.Drawing.Size(284, 42);
            this.labelEditUser.TabIndex = 5;
            this.labelEditUser.Text = "Edit User Details";
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
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.ForeColor = System.Drawing.Color.White;
            this.labelUserID.Location = new System.Drawing.Point(71, 147);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(85, 24);
            this.labelUserID.TabIndex = 20;
            this.labelUserID.Text = "User ID:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(71, 217);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(107, 24);
            this.labelUsername.TabIndex = 21;
            this.labelUsername.Text = "Username:";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(71, 183);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(58, 24);
            this.labelRole.TabIndex = 22;
            this.labelRole.Text = "Role:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(71, 250);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(103, 24);
            this.labelPassword.TabIndex = 23;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(184, 216);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(184, 25);
            this.textBoxUsername.TabIndex = 24;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(184, 247);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(184, 25);
            this.textBoxPassword.TabIndex = 25;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Doctor",
            "Nurse"});
            this.comboBoxRole.Location = new System.Drawing.Point(184, 179);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(118, 28);
            this.comboBoxRole.TabIndex = 26;
            this.comboBoxRole.Text = "Select Role";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(184, 278);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(91, 43);
            this.buttonUpdate.TabIndex = 27;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(277, 278);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 43);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonFindID
            // 
            this.buttonFindID.Location = new System.Drawing.Point(231, 144);
            this.buttonFindID.Name = "buttonFindID";
            this.buttonFindID.Size = new System.Drawing.Size(40, 25);
            this.buttonFindID.TabIndex = 30;
            this.buttonFindID.Text = "Find";
            this.buttonFindID.UseVisualStyleBackColor = true;
            this.buttonFindID.Click += new System.EventHandler(this.buttonFindID_Click);
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserID.Location = new System.Drawing.Point(184, 144);
            this.textBoxUserID.Mask = "00000";
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(41, 26);
            this.textBoxUserID.TabIndex = 31;
            this.textBoxUserID.ValidatingType = typeof(int);
            // 
            // AdminEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(491, 352);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.buttonFindID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.panelWhiteTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEditUser";
            this.Load += new System.EventHandler(this.AdminEditUser_Load);
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
        private System.Windows.Forms.Label labelEditUser;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonFindID;
        private System.Windows.Forms.MaskedTextBox textBoxUserID;
    }
}