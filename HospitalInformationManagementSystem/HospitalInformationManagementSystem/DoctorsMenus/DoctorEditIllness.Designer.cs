
namespace HospitalInformationManagementSystem
{
    partial class DoctorEditIllness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorEditIllness));
            this.panelWhiteTop = new System.Windows.Forms.Panel();
            this.labelGoBack = new System.Windows.Forms.Label();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.labelEditIllnessText = new System.Windows.Forms.Label();
            this.pictureBoxHospitalLogo = new System.Windows.Forms.PictureBox();
            this.comboBoxTreatmentStage = new System.Windows.Forms.ComboBox();
            this.labelTreatmentStage = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxIllness = new System.Windows.Forms.TextBox();
            this.textBoxIllnessType = new System.Windows.Forms.TextBox();
            this.labelDCOFormatPart2 = new System.Windows.Forms.Label();
            this.labelDCOFormatPart1 = new System.Windows.Forms.Label();
            this.labelDCIFormatPart2 = new System.Windows.Forms.Label();
            this.labelDCIFormatPart1 = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.RichTextBox();
            this.textBoxDateCheckedOut = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDateCheckedIn = new System.Windows.Forms.MaskedTextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelDateCheckedOut = new System.Windows.Forms.Label();
            this.labelDateCheckedIn = new System.Windows.Forms.Label();
            this.labelIllnessType = new System.Windows.Forms.Label();
            this.labelIllness = new System.Windows.Forms.Label();
            this.labelTreatmentID = new System.Windows.Forms.Label();
            this.labelPatientID = new System.Windows.Forms.Label();
            this.textBoxTreatmentID = new System.Windows.Forms.MaskedTextBox();
            this.buttonFindID = new System.Windows.Forms.Button();
            this.labelPatientIDInsert = new System.Windows.Forms.Label();
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
            this.panelWhiteTop.Controls.Add(this.labelEditIllnessText);
            this.panelWhiteTop.Controls.Add(this.pictureBoxHospitalLogo);
            this.panelWhiteTop.Location = new System.Drawing.Point(-1, 0);
            this.panelWhiteTop.Name = "panelWhiteTop";
            this.panelWhiteTop.Size = new System.Drawing.Size(780, 107);
            this.panelWhiteTop.TabIndex = 12;
            // 
            // labelGoBack
            // 
            this.labelGoBack.AutoSize = true;
            this.labelGoBack.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoBack.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelGoBack.Location = new System.Drawing.Point(742, 18);
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
            this.pictureBoxGoBack.Location = new System.Drawing.Point(720, 3);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(47, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxGoBack.TabIndex = 6;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.pictureBoxGoBack_Click);
            // 
            // labelEditIllnessText
            // 
            this.labelEditIllnessText.AutoSize = true;
            this.labelEditIllnessText.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditIllnessText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelEditIllnessText.Location = new System.Drawing.Point(163, 40);
            this.labelEditIllnessText.Name = "labelEditIllnessText";
            this.labelEditIllnessText.Size = new System.Drawing.Size(514, 42);
            this.labelEditIllnessText.TabIndex = 5;
            this.labelEditIllnessText.Text = "Edit Patient Illness Information";
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
            // comboBoxTreatmentStage
            // 
            this.comboBoxTreatmentStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTreatmentStage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTreatmentStage.FormattingEnabled = true;
            this.comboBoxTreatmentStage.Items.AddRange(new object[] {
            "",
            "Yet To Start",
            "On Going",
            "Finished"});
            this.comboBoxTreatmentStage.Location = new System.Drawing.Point(317, 276);
            this.comboBoxTreatmentStage.Name = "comboBoxTreatmentStage";
            this.comboBoxTreatmentStage.Size = new System.Drawing.Size(126, 28);
            this.comboBoxTreatmentStage.TabIndex = 97;
            // 
            // labelTreatmentStage
            // 
            this.labelTreatmentStage.AutoSize = true;
            this.labelTreatmentStage.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTreatmentStage.ForeColor = System.Drawing.Color.White;
            this.labelTreatmentStage.Location = new System.Drawing.Point(12, 275);
            this.labelTreatmentStage.Name = "labelTreatmentStage";
            this.labelTreatmentStage.Size = new System.Drawing.Size(165, 24);
            this.labelTreatmentStage.TabIndex = 96;
            this.labelTreatmentStage.Text = "Treatment Stage:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(428, 397);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 43);
            this.buttonCancel.TabIndex = 95;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(305, 397);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(117, 43);
            this.buttonUpdate.TabIndex = 94;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxIllness
            // 
            this.textBoxIllness.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIllness.Location = new System.Drawing.Point(317, 204);
            this.textBoxIllness.Name = "textBoxIllness";
            this.textBoxIllness.Size = new System.Drawing.Size(126, 25);
            this.textBoxIllness.TabIndex = 91;
            // 
            // textBoxIllnessType
            // 
            this.textBoxIllnessType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIllnessType.Location = new System.Drawing.Point(317, 241);
            this.textBoxIllnessType.Name = "textBoxIllnessType";
            this.textBoxIllnessType.Size = new System.Drawing.Size(126, 25);
            this.textBoxIllnessType.TabIndex = 90;
            // 
            // labelDCOFormatPart2
            // 
            this.labelDCOFormatPart2.AutoSize = true;
            this.labelDCOFormatPart2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDCOFormatPart2.ForeColor = System.Drawing.Color.White;
            this.labelDCOFormatPart2.Location = new System.Drawing.Point(190, 360);
            this.labelDCOFormatPart2.Name = "labelDCOFormatPart2";
            this.labelDCOFormatPart2.Size = new System.Drawing.Size(121, 17);
            this.labelDCOFormatPart2.TabIndex = 89;
            this.labelDCOFormatPart2.Text = "Day-Month-Year)";
            // 
            // labelDCOFormatPart1
            // 
            this.labelDCOFormatPart1.AutoSize = true;
            this.labelDCOFormatPart1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDCOFormatPart1.ForeColor = System.Drawing.Color.White;
            this.labelDCOFormatPart1.Location = new System.Drawing.Point(190, 343);
            this.labelDCOFormatPart1.Name = "labelDCOFormatPart1";
            this.labelDCOFormatPart1.Size = new System.Drawing.Size(65, 17);
            this.labelDCOFormatPart1.TabIndex = 88;
            this.labelDCOFormatPart1.Text = "(Format:";
            // 
            // labelDCIFormatPart2
            // 
            this.labelDCIFormatPart2.AutoSize = true;
            this.labelDCIFormatPart2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDCIFormatPart2.ForeColor = System.Drawing.Color.White;
            this.labelDCIFormatPart2.Location = new System.Drawing.Point(175, 322);
            this.labelDCIFormatPart2.Name = "labelDCIFormatPart2";
            this.labelDCIFormatPart2.Size = new System.Drawing.Size(121, 17);
            this.labelDCIFormatPart2.TabIndex = 87;
            this.labelDCIFormatPart2.Text = "Day-Month-Year)";
            // 
            // labelDCIFormatPart1
            // 
            this.labelDCIFormatPart1.AutoSize = true;
            this.labelDCIFormatPart1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDCIFormatPart1.ForeColor = System.Drawing.Color.White;
            this.labelDCIFormatPart1.Location = new System.Drawing.Point(175, 305);
            this.labelDCIFormatPart1.Name = "labelDCIFormatPart1";
            this.labelDCIFormatPart1.Size = new System.Drawing.Size(65, 17);
            this.labelDCIFormatPart1.TabIndex = 86;
            this.labelDCIFormatPart1.Text = "(Format:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotes.Location = new System.Drawing.Point(478, 163);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(287, 214);
            this.textBoxNotes.TabIndex = 85;
            this.textBoxNotes.Text = "";
            // 
            // textBoxDateCheckedOut
            // 
            this.textBoxDateCheckedOut.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateCheckedOut.Location = new System.Drawing.Point(317, 351);
            this.textBoxDateCheckedOut.Mask = "00-00-0000";
            this.textBoxDateCheckedOut.Name = "textBoxDateCheckedOut";
            this.textBoxDateCheckedOut.Size = new System.Drawing.Size(70, 26);
            this.textBoxDateCheckedOut.TabIndex = 84;
            // 
            // textBoxDateCheckedIn
            // 
            this.textBoxDateCheckedIn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateCheckedIn.Location = new System.Drawing.Point(317, 313);
            this.textBoxDateCheckedIn.Mask = "00-00-0000";
            this.textBoxDateCheckedIn.Name = "textBoxDateCheckedIn";
            this.textBoxDateCheckedIn.Size = new System.Drawing.Size(70, 26);
            this.textBoxDateCheckedIn.TabIndex = 83;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotes.ForeColor = System.Drawing.Color.White;
            this.labelNotes.Location = new System.Drawing.Point(474, 136);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(68, 24);
            this.labelNotes.TabIndex = 82;
            this.labelNotes.Text = "Notes:";
            // 
            // labelDateCheckedOut
            // 
            this.labelDateCheckedOut.AutoSize = true;
            this.labelDateCheckedOut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateCheckedOut.ForeColor = System.Drawing.Color.White;
            this.labelDateCheckedOut.Location = new System.Drawing.Point(12, 345);
            this.labelDateCheckedOut.Name = "labelDateCheckedOut";
            this.labelDateCheckedOut.Size = new System.Drawing.Size(182, 24);
            this.labelDateCheckedOut.TabIndex = 81;
            this.labelDateCheckedOut.Text = "Date Checked Out:";
            // 
            // labelDateCheckedIn
            // 
            this.labelDateCheckedIn.AutoSize = true;
            this.labelDateCheckedIn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateCheckedIn.ForeColor = System.Drawing.Color.White;
            this.labelDateCheckedIn.Location = new System.Drawing.Point(12, 310);
            this.labelDateCheckedIn.Name = "labelDateCheckedIn";
            this.labelDateCheckedIn.Size = new System.Drawing.Size(166, 24);
            this.labelDateCheckedIn.TabIndex = 80;
            this.labelDateCheckedIn.Text = "Date Checked In:";
            // 
            // labelIllnessType
            // 
            this.labelIllnessType.AutoSize = true;
            this.labelIllnessType.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIllnessType.ForeColor = System.Drawing.Color.White;
            this.labelIllnessType.Location = new System.Drawing.Point(12, 242);
            this.labelIllnessType.Name = "labelIllnessType";
            this.labelIllnessType.Size = new System.Drawing.Size(118, 24);
            this.labelIllnessType.TabIndex = 79;
            this.labelIllnessType.Text = "Illness Type:";
            // 
            // labelIllness
            // 
            this.labelIllness.AutoSize = true;
            this.labelIllness.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIllness.ForeColor = System.Drawing.Color.White;
            this.labelIllness.Location = new System.Drawing.Point(12, 205);
            this.labelIllness.Name = "labelIllness";
            this.labelIllness.Size = new System.Drawing.Size(71, 24);
            this.labelIllness.TabIndex = 78;
            this.labelIllness.Text = "Illness:";
            // 
            // labelTreatmentID
            // 
            this.labelTreatmentID.AutoSize = true;
            this.labelTreatmentID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTreatmentID.ForeColor = System.Drawing.Color.White;
            this.labelTreatmentID.Location = new System.Drawing.Point(12, 136);
            this.labelTreatmentID.Name = "labelTreatmentID";
            this.labelTreatmentID.Size = new System.Drawing.Size(136, 24);
            this.labelTreatmentID.TabIndex = 77;
            this.labelTreatmentID.Text = "Treatment ID:";
            // 
            // labelPatientID
            // 
            this.labelPatientID.AutoSize = true;
            this.labelPatientID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientID.ForeColor = System.Drawing.Color.White;
            this.labelPatientID.Location = new System.Drawing.Point(12, 170);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(109, 24);
            this.labelPatientID.TabIndex = 76;
            this.labelPatientID.Text = "Patient ID:";
            // 
            // textBoxTreatmentID
            // 
            this.textBoxTreatmentID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTreatmentID.Location = new System.Drawing.Point(317, 134);
            this.textBoxTreatmentID.Mask = "00000";
            this.textBoxTreatmentID.Name = "textBoxTreatmentID";
            this.textBoxTreatmentID.Size = new System.Drawing.Size(41, 26);
            this.textBoxTreatmentID.TabIndex = 99;
            this.textBoxTreatmentID.ValidatingType = typeof(int);
            // 
            // buttonFindID
            // 
            this.buttonFindID.Location = new System.Drawing.Point(364, 134);
            this.buttonFindID.Name = "buttonFindID";
            this.buttonFindID.Size = new System.Drawing.Size(40, 25);
            this.buttonFindID.TabIndex = 98;
            this.buttonFindID.Text = "Find";
            this.buttonFindID.UseVisualStyleBackColor = true;
            this.buttonFindID.Click += new System.EventHandler(this.buttonFindID_Click);
            // 
            // labelPatientIDInsert
            // 
            this.labelPatientIDInsert.AutoSize = true;
            this.labelPatientIDInsert.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientIDInsert.ForeColor = System.Drawing.Color.White;
            this.labelPatientIDInsert.Location = new System.Drawing.Point(313, 170);
            this.labelPatientIDInsert.Name = "labelPatientIDInsert";
            this.labelPatientIDInsert.Size = new System.Drawing.Size(0, 24);
            this.labelPatientIDInsert.TabIndex = 100;
            // 
            // DoctorEditIllness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(777, 452);
            this.Controls.Add(this.labelPatientIDInsert);
            this.Controls.Add(this.textBoxTreatmentID);
            this.Controls.Add(this.buttonFindID);
            this.Controls.Add(this.comboBoxTreatmentStage);
            this.Controls.Add(this.labelTreatmentStage);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxIllness);
            this.Controls.Add(this.textBoxIllnessType);
            this.Controls.Add(this.labelDCOFormatPart2);
            this.Controls.Add(this.labelDCOFormatPart1);
            this.Controls.Add(this.labelDCIFormatPart2);
            this.Controls.Add(this.labelDCIFormatPart1);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.textBoxDateCheckedOut);
            this.Controls.Add(this.textBoxDateCheckedIn);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelDateCheckedOut);
            this.Controls.Add(this.labelDateCheckedIn);
            this.Controls.Add(this.labelIllnessType);
            this.Controls.Add(this.labelIllness);
            this.Controls.Add(this.labelTreatmentID);
            this.Controls.Add(this.labelPatientID);
            this.Controls.Add(this.panelWhiteTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorEditIllness";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DoctorEditIllness_Load);
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
        private System.Windows.Forms.Label labelEditIllnessText;
        private System.Windows.Forms.PictureBox pictureBoxHospitalLogo;
        private System.Windows.Forms.ComboBox comboBoxTreatmentStage;
        private System.Windows.Forms.Label labelTreatmentStage;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxIllness;
        private System.Windows.Forms.TextBox textBoxIllnessType;
        private System.Windows.Forms.Label labelDCOFormatPart2;
        private System.Windows.Forms.Label labelDCOFormatPart1;
        private System.Windows.Forms.Label labelDCIFormatPart2;
        private System.Windows.Forms.Label labelDCIFormatPart1;
        private System.Windows.Forms.RichTextBox textBoxNotes;
        private System.Windows.Forms.MaskedTextBox textBoxDateCheckedOut;
        private System.Windows.Forms.MaskedTextBox textBoxDateCheckedIn;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelDateCheckedOut;
        private System.Windows.Forms.Label labelDateCheckedIn;
        private System.Windows.Forms.Label labelIllnessType;
        private System.Windows.Forms.Label labelIllness;
        private System.Windows.Forms.Label labelTreatmentID;
        private System.Windows.Forms.Label labelPatientID;
        private System.Windows.Forms.MaskedTextBox textBoxTreatmentID;
        private System.Windows.Forms.Button buttonFindID;
        private System.Windows.Forms.Label labelPatientIDInsert;
    }
}