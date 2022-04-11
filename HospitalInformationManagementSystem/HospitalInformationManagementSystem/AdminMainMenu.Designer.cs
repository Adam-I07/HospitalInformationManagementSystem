
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
            this.button1 = new System.Windows.Forms.Button();
            this.panelWhiteBottom = new System.Windows.Forms.Panel();
            this.labelHospitalName = new System.Windows.Forms.Label();
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelAdminMenu = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelWhiteBottom.SuspendLayout();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.labelAdminMenu.Location = new System.Drawing.Point(45, 27);
            this.labelAdminMenu.Name = "labelAdminMenu";
            this.labelAdminMenu.Size = new System.Drawing.Size(229, 42);
            this.labelAdminMenu.TabIndex = 5;
            this.labelAdminMenu.Text = "Admin Menu";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(253, -12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(131, 116);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // AdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(460, 288);
            this.Controls.Add(this.panelWhiteTop);
            this.Controls.Add(this.panelWhiteBottom);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.panelWhiteBottom.ResumeLayout(false);
            this.panelWhiteBottom.PerformLayout();
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelWhiteBottom;
        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelAdminMenu;
        private System.Windows.Forms.Label labelHospitalName;
    }
}