
namespace HospitalInformationManagementSystem
{
    partial class DoctorEditInteractionLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorEditInteractionLog));
            this.textBoxStaffName = new System.Windows.Forms.TextBox();
            this.comboBoxShift = new System.Windows.Forms.ComboBox();
            this.textBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.labelDateFormatPart2 = new System.Windows.Forms.Label();
            this.labelDateFormatPart1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxInteractionNotes = new System.Windows.Forms.RichTextBox();
            this.labelInteractionNotes = new System.Windows.Forms.Label();
            this.labelShift = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPatientID = new System.Windows.Forms.Label();
            this.labelStaffName = new System.Windows.Forms.Label();
            this.labelLogInID = new System.Windows.Forms.Label();
            this.labelLogID = new System.Windows.Forms.Label();
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelEditInteractionLogText = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.comboBoxPatientID = new System.Windows.Forms.ComboBox();
            this.comboBoxLoginID = new System.Windows.Forms.ComboBox();
            this.textBoxLogID = new System.Windows.Forms.MaskedTextBox();
            this.buttonFindID = new System.Windows.Forms.Button();
            this.panelWhiteTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStaffName
            // 
            this.textBoxStaffName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStaffName.Location = new System.Drawing.Point(205, 204);
            this.textBoxStaffName.Name = "textBoxStaffName";
            this.textBoxStaffName.Size = new System.Drawing.Size(126, 25);
            this.textBoxStaffName.TabIndex = 98;
            // 
            // comboBoxShift
            // 
            this.comboBoxShift.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "Morning",
            "Night"});
            this.comboBoxShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShift.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxShift.FormattingEnabled = true;
            this.comboBoxShift.Items.AddRange(new object[] {
            "",
            "Morning",
            "Night"});
            this.comboBoxShift.Location = new System.Drawing.Point(205, 308);
            this.comboBoxShift.Name = "comboBoxShift";
            this.comboBoxShift.Size = new System.Drawing.Size(126, 28);
            this.comboBoxShift.TabIndex = 95;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDate.Location = new System.Drawing.Point(205, 272);
            this.textBoxDate.Mask = "00-00-0000";
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(70, 26);
            this.textBoxDate.TabIndex = 94;
            // 
            // labelDateFormatPart2
            // 
            this.labelDateFormatPart2.AutoSize = true;
            this.labelDateFormatPart2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFormatPart2.ForeColor = System.Drawing.Color.White;
            this.labelDateFormatPart2.Location = new System.Drawing.Point(78, 289);
            this.labelDateFormatPart2.Name = "labelDateFormatPart2";
            this.labelDateFormatPart2.Size = new System.Drawing.Size(121, 17);
            this.labelDateFormatPart2.TabIndex = 93;
            this.labelDateFormatPart2.Text = "Day-Month-Year)";
            // 
            // labelDateFormatPart1
            // 
            this.labelDateFormatPart1.AutoSize = true;
            this.labelDateFormatPart1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFormatPart1.ForeColor = System.Drawing.Color.White;
            this.labelDateFormatPart1.Location = new System.Drawing.Point(78, 272);
            this.labelDateFormatPart1.Name = "labelDateFormatPart1";
            this.labelDateFormatPart1.Size = new System.Drawing.Size(65, 17);
            this.labelDateFormatPart1.TabIndex = 92;
            this.labelDateFormatPart1.Text = "(Format:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(351, 348);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 43);
            this.buttonCancel.TabIndex = 91;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(228, 348);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(117, 43);
            this.buttonUpdate.TabIndex = 90;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxInteractionNotes
            // 
            this.textBoxInteractionNotes.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInteractionNotes.Location = new System.Drawing.Point(351, 165);
            this.textBoxInteractionNotes.Name = "textBoxInteractionNotes";
            this.textBoxInteractionNotes.Size = new System.Drawing.Size(342, 177);
            this.textBoxInteractionNotes.TabIndex = 89;
            this.textBoxInteractionNotes.Text = "";
            // 
            // labelInteractionNotes
            // 
            this.labelInteractionNotes.AutoSize = true;
            this.labelInteractionNotes.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInteractionNotes.ForeColor = System.Drawing.Color.White;
            this.labelInteractionNotes.Location = new System.Drawing.Point(347, 138);
            this.labelInteractionNotes.Name = "labelInteractionNotes";
            this.labelInteractionNotes.Size = new System.Drawing.Size(171, 24);
            this.labelInteractionNotes.TabIndex = 88;
            this.labelInteractionNotes.Text = "Interaction Notes:";
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShift.ForeColor = System.Drawing.Color.White;
            this.labelShift.Location = new System.Drawing.Point(13, 308);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(59, 24);
            this.labelShift.TabIndex = 87;
            this.labelShift.Text = "Shift:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(12, 272);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(60, 24);
            this.labelDate.TabIndex = 86;
            this.labelDate.Text = "Date:";
            // 
            // labelPatientID
            // 
            this.labelPatientID.AutoSize = true;
            this.labelPatientID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientID.ForeColor = System.Drawing.Color.White;
            this.labelPatientID.Location = new System.Drawing.Point(12, 239);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(109, 24);
            this.labelPatientID.TabIndex = 85;
            this.labelPatientID.Text = "Patient ID:";
            // 
            // labelStaffName
            // 
            this.labelStaffName.AutoSize = true;
            this.labelStaffName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffName.ForeColor = System.Drawing.Color.White;
            this.labelStaffName.Location = new System.Drawing.Point(12, 205);
            this.labelStaffName.Name = "labelStaffName";
            this.labelStaffName.Size = new System.Drawing.Size(119, 24);
            this.labelStaffName.TabIndex = 84;
            this.labelStaffName.Text = "Staff Name:";
            // 
            // labelLogInID
            // 
            this.labelLogInID.AutoSize = true;
            this.labelLogInID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogInID.ForeColor = System.Drawing.Color.White;
            this.labelLogInID.Location = new System.Drawing.Point(12, 172);
            this.labelLogInID.Name = "labelLogInID";
            this.labelLogInID.Size = new System.Drawing.Size(96, 24);
            this.labelLogInID.TabIndex = 83;
            this.labelLogInID.Text = "Login ID:";
            // 
            // labelLogID
            // 
            this.labelLogID.AutoSize = true;
            this.labelLogID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogID.ForeColor = System.Drawing.Color.White;
            this.labelLogID.Location = new System.Drawing.Point(12, 138);
            this.labelLogID.Name = "labelLogID";
            this.labelLogID.Size = new System.Drawing.Size(80, 24);
            this.labelLogID.TabIndex = 82;
            this.labelLogID.Text = "Log ID:";
            // 
            // panelWhiteTop
            // 
            this.panelWhiteTop.BackColor = System.Drawing.Color.White;
            this.panelWhiteTop.Controls.Add(this.labelGoBack);
            this.panelWhiteTop.Controls.Add(this.pictureBoxGoBack);
            this.panelWhiteTop.Controls.Add(this.labelEditInteractionLogText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-2, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(715, 107);
            this.panelWhiteTop.TabIndex = 81;
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(676, 19);
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
            this.pictureBoxGoBack.Location = new System.Drawing.Point(654, 4);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelEditInteractionLogText
            // 
            this.labelEditInteractionLogText.AutoSize = true;
            this.labelEditInteractionLogText.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditInteractionLogText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelEditInteractionLogText.Location = new System.Drawing.Point(209, 32);
            this.labelEditInteractionLogText.Name = "labelEditInteractionLogText";
            this.labelEditInteractionLogText.Size = new System.Drawing.Size(340, 42);
            this.labelEditInteractionLogText.TabIndex = 5;
            this.labelEditInteractionLogText.Text = "Edit Interaction Log";
            // 
            // pictureBoxHospitalLogo
            // 
            this.pictureBoxHospitalLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHospitalLogo.Image")));
            this.pictureBoxHospitalLogo.Location = new System.Drawing.Point(0, -9);
            this.pictureBoxHospitalLogo.Name = "pictureBoxHospitalLogo";
            this.pictureBoxHospitalLogo.Size = new System.Drawing.Size(131, 116);
            this.pictureBoxHospitalLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHospitalLogo.TabIndex = 4;
            this.pictureBoxHospitalLogo.TabStop = false;
            // 
            // comboBoxPatientID
            // 
            this.comboBoxPatientID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatientID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPatientID.FormattingEnabled = true;
            this.comboBoxPatientID.Location = new System.Drawing.Point(205, 235);
            this.comboBoxPatientID.Name = "comboBoxPatientID";
            this.comboBoxPatientID.Size = new System.Drawing.Size(53, 28);
            this.comboBoxPatientID.TabIndex = 96;
            // 
            // comboBoxLoginID
            // 
            this.comboBoxLoginID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoginID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoginID.FormattingEnabled = true;
            this.comboBoxLoginID.Location = new System.Drawing.Point(205, 170);
            this.comboBoxLoginID.Name = "comboBoxLoginID";
            this.comboBoxLoginID.Size = new System.Drawing.Size(53, 28);
            this.comboBoxLoginID.TabIndex = 97;
            // 
            // textBoxLogID
            // 
            this.textBoxLogID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogID.Location = new System.Drawing.Point(205, 136);
            this.textBoxLogID.Mask = "00000";
            this.textBoxLogID.Name = "textBoxLogID";
            this.textBoxLogID.Size = new System.Drawing.Size(41, 26);
            this.textBoxLogID.TabIndex = 101;
            this.textBoxLogID.ValidatingType = typeof(int);
            // 
            // buttonFindID
            // 
            this.buttonFindID.Location = new System.Drawing.Point(252, 136);
            this.buttonFindID.Name = "buttonFindID";
            this.buttonFindID.Size = new System.Drawing.Size(40, 25);
            this.buttonFindID.TabIndex = 100;
            this.buttonFindID.Text = "Find";
            this.buttonFindID.UseVisualStyleBackColor = true;
            this.buttonFindID.Click += new System.EventHandler(this.buttonFindID_Click);
            // 
            // DoctorEditInteractionLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(711, 397);
            this.Controls.Add(this.textBoxLogID);
            this.Controls.Add(this.buttonFindID);
            this.Controls.Add(this.textBoxStaffName);
            this.Controls.Add(this.comboBoxLoginID);
            this.Controls.Add(this.comboBoxPatientID);
            this.Controls.Add(this.comboBoxShift);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labelDateFormatPart2);
            this.Controls.Add(this.labelDateFormatPart1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxInteractionNotes);
            this.Controls.Add(this.labelInteractionNotes);
            this.Controls.Add(this.labelShift);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelPatientID);
            this.Controls.Add(this.labelStaffName);
            this.Controls.Add(this.labelLogInID);
            this.Controls.Add(this.labelLogID);
            this.Controls.Add(this.panelWhiteTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorEditInteractionLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorEditInteractionLog";
            this.Load += new System.EventHandler(this.DoctorEditInteractionLog_Load);
            this.panelWhiteTop.ResumeLayout(false);
            this.panelWhiteTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxStaffName;
        private System.Windows.Forms.ComboBox comboBoxShift;
        private System.Windows.Forms.MaskedTextBox textBoxDate;
        private System.Windows.Forms.Label labelDateFormatPart2;
        private System.Windows.Forms.Label labelDateFormatPart1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.RichTextBox textBoxInteractionNotes;
        private System.Windows.Forms.Label labelInteractionNotes;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPatientID;
        private System.Windows.Forms.Label labelStaffName;
        private System.Windows.Forms.Label labelLogInID;
        private System.Windows.Forms.Label labelLogID;
        private System.Windows.Forms.Panel panelWhiteTop;
        private System.Windows.Forms.Label labelGoBack;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label labelEditInteractionLogText;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.ComboBox comboBoxPatientID;
        private System.Windows.Forms.ComboBox comboBoxLoginID;
        private System.Windows.Forms.MaskedTextBox textBoxLogID;
        private System.Windows.Forms.Button buttonFindID;
    }
}