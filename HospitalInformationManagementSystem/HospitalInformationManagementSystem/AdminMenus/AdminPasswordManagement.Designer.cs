
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
            this.ColumnLogInID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelLoginManagementText = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.labelSelectFilterText = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxRoleFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginDetails)).BeginInit();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLoginDetails
            // 
            this.dataGridViewLoginDetails.AllowUserToAddRows = false;
            this.dataGridViewLoginDetails.AllowUserToDeleteRows = false;
            this.dataGridViewLoginDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoginDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLogInID,
            this.ColumnRole,
            this.ColumnUsername,
            this.ColumnPassword});
            this.dataGridViewLoginDetails.Location = new System.Drawing.Point(135, 174);
            this.dataGridViewLoginDetails.Name = "dataGridViewLoginDetails";
            this.dataGridViewLoginDetails.ReadOnly = true;
            this.dataGridViewLoginDetails.Size = new System.Drawing.Size(535, 283);
            this.dataGridViewLoginDetails.TabIndex = 0;
            // 
            // ColumnLogInID
            // 
            this.ColumnLogInID.DataPropertyName = "LogInID";
            this.ColumnLogInID.HeaderText = "LoginID";
            this.ColumnLogInID.Name = "ColumnLogInID";
            this.ColumnLogInID.ReadOnly = true;
            this.ColumnLogInID.Width = 70;
            // 
            // ColumnRole
            // 
            this.ColumnRole.DataPropertyName = "Role";
            this.ColumnRole.HeaderText = "Role";
            this.ColumnRole.Name = "ColumnRole";
            this.ColumnRole.ReadOnly = true;
            this.ColumnRole.Width = 102;
            // 
            // ColumnUsername
            // 
            this.ColumnUsername.DataPropertyName = "Username";
            this.ColumnUsername.HeaderText = "Username";
            this.ColumnUsername.Name = "ColumnUsername";
            this.ColumnUsername.ReadOnly = true;
            this.ColumnUsername.Width = 160;
            // 
            // ColumnPassword
            // 
            this.ColumnPassword.DataPropertyName = "Password";
            this.ColumnPassword.HeaderText = "Password";
            this.ColumnPassword.Name = "ColumnPassword";
            this.ColumnPassword.ReadOnly = true;
            this.ColumnPassword.Width = 160;
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelLoginManagementText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-2, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(685, 125);
            this.panelWhiteTop.TabIndex = 8;
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(649, 9);
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
            this.pictureBoxGoBack.Location = new System.Drawing.Point(627, -6);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelLoginManagementText
            // 
            this.labelLoginManagementText.AutoSize = true;
            this.labelLoginManagementText.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginManagementText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelLoginManagementText.Location = new System.Drawing.Point(99, 45);
            this.labelLoginManagementText.Name = "labelLoginManagementText";
            this.labelLoginManagementText.Size = new System.Drawing.Size(533, 36);
            this.labelLoginManagementText.TabIndex = 5;
            this.labelLoginManagementText.Text = "User Login Detail Management Menu";
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
            this.buttonAddNewUser.Location = new System.Drawing.Point(12, 174);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(117, 52);
            this.buttonAddNewUser.TabIndex = 9;
            this.buttonAddNewUser.Text = "Add New User";
            this.buttonAddNewUser.UseVisualStyleBackColor = true;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(12, 242);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(117, 52);
            this.buttonEditUser.TabIndex = 10;
            this.buttonEditUser.Text = "Edit User";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(12, 310);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(117, 52);
            this.buttonDeleteUser.TabIndex = 11;
            this.buttonDeleteUser.Text = "Delete User";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // labelSelectFilterText
            // 
            this.labelSelectFilterText.AutoSize = true;
            this.labelSelectFilterText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectFilterText.ForeColor = System.Drawing.Color.White;
            this.labelSelectFilterText.Location = new System.Drawing.Point(151, 140);
            this.labelSelectFilterText.Name = "labelSelectFilterText";
            this.labelSelectFilterText.Size = new System.Drawing.Size(229, 24);
            this.labelSelectFilterText.TabIndex = 137;
            this.labelSelectFilterText.Text = "Select a Role to filter by:";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(574, 140);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(73, 28);
            this.buttonReset.TabIndex = 136;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(495, 140);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(73, 28);
            this.buttonSearch.TabIndex = 135;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxRoleFilter
            // 
            this.comboBoxRoleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoleFilter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoleFilter.FormattingEnabled = true;
            this.comboBoxRoleFilter.Items.AddRange(new object[] {
            "",
            "Nurse",
            "Doctor"});
            this.comboBoxRoleFilter.Location = new System.Drawing.Point(386, 140);
            this.comboBoxRoleFilter.Name = "comboBoxRoleFilter";
            this.comboBoxRoleFilter.Size = new System.Drawing.Size(103, 28);
            this.comboBoxRoleFilter.TabIndex = 134;
            // 
            // AdminPasswordManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(682, 469);
            this.Controls.Add(this.labelSelectFilterText);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxRoleFilter);
            this.Controls.Add(this.buttonDeleteUser);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLoginDetails;
        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.Label labelLoginManagementText;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogInID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassword;
        private System.Windows.Forms.Label labelSelectFilterText;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxRoleFilter;
    }
}