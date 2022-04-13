
namespace HospitalInformationManagementSystem
{
    partial class DoctorsPatientPersonalInfoMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsPatientPersonalInfoMenu));
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelPatientPersonalInfoMenuText = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.dataGridViewLoginDetails = new System.Windows.Forms.DataGridView();
            this.buttonAddNewPatient = new System.Windows.Forms.Button();
            this.buttonEditPatient = new System.Windows.Forms.Button();
            this.buttonViewPatient = new System.Windows.Forms.Button();
            this.buttonDeletePatient = new System.Windows.Forms.Button();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelPatientPersonalInfoMenuText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-2, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(1750, 107);
            this.panelWhiteTop.TabIndex = 10;
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(1713, 18);
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
            this.pictureBoxGoBack.Location = new System.Drawing.Point(1691, 3);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelPatientPersonalInfoMenuText
            // 
            this.labelPatientPersonalInfoMenuText.AutoSize = true;
            this.labelPatientPersonalInfoMenuText.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientPersonalInfoMenuText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelPatientPersonalInfoMenuText.Location = new System.Drawing.Point(111, 39);
            this.labelPatientPersonalInfoMenuText.Name = "labelPatientPersonalInfoMenuText";
            this.labelPatientPersonalInfoMenuText.Size = new System.Drawing.Size(579, 42);
            this.labelPatientPersonalInfoMenuText.TabIndex = 5;
            this.labelPatientPersonalInfoMenuText.Text = "Patient Personal Information Menu";
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
            // dataGridViewLoginDetails
            // 
            this.dataGridViewLoginDetails.AllowUserToAddRows = false;
            this.dataGridViewLoginDetails.AllowUserToDeleteRows = false;
            this.dataGridViewLoginDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoginDetails.Location = new System.Drawing.Point(199, 162);
            this.dataGridViewLoginDetails.Name = "dataGridViewLoginDetails";
            this.dataGridViewLoginDetails.ReadOnly = true;
            this.dataGridViewLoginDetails.Size = new System.Drawing.Size(1537, 428);
            this.dataGridViewLoginDetails.TabIndex = 11;
            // 
            // buttonAddNewPatient
            // 
            this.buttonAddNewPatient.Location = new System.Drawing.Point(12, 162);
            this.buttonAddNewPatient.Name = "buttonAddNewPatient";
            this.buttonAddNewPatient.Size = new System.Drawing.Size(181, 55);
            this.buttonAddNewPatient.TabIndex = 12;
            this.buttonAddNewPatient.Text = "Add New Patient";
            this.buttonAddNewPatient.UseVisualStyleBackColor = true;
            this.buttonAddNewPatient.Click += new System.EventHandler(this.buttonAddNewPatient_Click);
            // 
            // buttonEditPatient
            // 
            this.buttonEditPatient.Location = new System.Drawing.Point(12, 234);
            this.buttonEditPatient.Name = "buttonEditPatient";
            this.buttonEditPatient.Size = new System.Drawing.Size(181, 55);
            this.buttonEditPatient.TabIndex = 13;
            this.buttonEditPatient.Text = "Edit Patient";
            this.buttonEditPatient.UseVisualStyleBackColor = true;
            this.buttonEditPatient.Click += new System.EventHandler(this.buttonEditPatient_Click);
            // 
            // buttonViewPatient
            // 
            this.buttonViewPatient.Location = new System.Drawing.Point(12, 377);
            this.buttonViewPatient.Name = "buttonViewPatient";
            this.buttonViewPatient.Size = new System.Drawing.Size(181, 55);
            this.buttonViewPatient.TabIndex = 14;
            this.buttonViewPatient.Text = "View Specific Patient";
            this.buttonViewPatient.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePatient
            // 
            this.buttonDeletePatient.Location = new System.Drawing.Point(12, 306);
            this.buttonDeletePatient.Name = "buttonDeletePatient";
            this.buttonDeletePatient.Size = new System.Drawing.Size(181, 55);
            this.buttonDeletePatient.TabIndex = 15;
            this.buttonDeletePatient.Text = "Delete Patient";
            this.buttonDeletePatient.UseVisualStyleBackColor = true;
            // 
            // DoctorsPatientPersonalInfoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1748, 602);
            this.Controls.Add(this.buttonDeletePatient);
            this.Controls.Add(this.buttonViewPatient);
            this.Controls.Add(this.buttonEditPatient);
            this.Controls.Add(this.buttonAddNewPatient);
            this.Controls.Add(this.dataGridViewLoginDetails);
            this.Controls.Add(this.panelWhiteTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorsPatientPersonalInfoMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorsPatientPersonalInfoMenu";
            this.Load += new System.EventHandler(this.DoctorsPatientPersonalInfoMenu_Load);
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoginDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelPatientPersonalInfoMenuText;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.DataGridView dataGridViewLoginDetails;
        private System.Windows.Forms.Button buttonAddNewPatient;
        private System.Windows.Forms.Button buttonEditPatient;
        private System.Windows.Forms.Button buttonViewPatient;
        private System.Windows.Forms.Button buttonDeletePatient;
    }
}