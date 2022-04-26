
namespace HospitalInformationManagementSystem
{
    partial class StartLoadingWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartLoadingWindow));
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelHospitalNameSecondPart = new System.Windows.Forms.Label();
            this.labelHospitalNameFirstPart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingBar
            // 
            this.loadingBar.Location = new System.Drawing.Point(12, 214);
            this.loadingBar.Maximum = 50;
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(482, 39);
            this.loadingBar.TabIndex = 1;
            this.loadingBar.Value = 1;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(344, 27);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(162, 171);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelHospitalNameSecondPart
            // 
            this.labelHospitalNameSecondPart.AutoSize = true;
            this.labelHospitalNameSecondPart.BackColor = System.Drawing.Color.Transparent;
            this.labelHospitalNameSecondPart.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHospitalNameSecondPart.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelHospitalNameSecondPart.Location = new System.Drawing.Point(22, 119);
            this.labelHospitalNameSecondPart.Name = "labelHospitalNameSecondPart";
            this.labelHospitalNameSecondPart.Size = new System.Drawing.Size(345, 42);
            this.labelHospitalNameSecondPart.TabIndex = 3;
            this.labelHospitalNameSecondPart.Text = "Management System";
            // 
            // labelHospitalNameFirstPart
            // 
            this.labelHospitalNameFirstPart.AutoSize = true;
            this.labelHospitalNameFirstPart.BackColor = System.Drawing.Color.Transparent;
            this.labelHospitalNameFirstPart.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHospitalNameFirstPart.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelHospitalNameFirstPart.Location = new System.Drawing.Point(22, 77);
            this.labelHospitalNameFirstPart.Name = "labelHospitalNameFirstPart";
            this.labelHospitalNameFirstPart.Size = new System.Drawing.Size(350, 42);
            this.labelHospitalNameFirstPart.TabIndex = 4;
            this.labelHospitalNameFirstPart.Text = "Hospital Information";
            // 
            // StartLoadingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 265);
            this.Controls.Add(this.labelHospitalNameFirstPart);
            this.Controls.Add(this.labelHospitalNameSecondPart);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.loadingBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartLoadingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartLoadingWindow";
            this.Load += new System.EventHandler(this.StartLoadingWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar loadingBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelHospitalNameSecondPart;
        private System.Windows.Forms.Label labelHospitalNameFirstPart;
    }
}