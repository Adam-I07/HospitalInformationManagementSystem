using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem
{
    public partial class DoctosMainMenu : Form
    {
        public DoctosMainMenu()
        {
            InitializeComponent();
        }

        private void pictureBoxLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void pictureBoxPatientPersonalDetailsLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorsPatientPersonalInfoMenu doctorsPatientPersonalInfo = new DoctorsPatientPersonalInfoMenu();
            doctorsPatientPersonalInfo.Show();
        }

        private void labelPatientDetailsTextPart1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorsPatientPersonalInfoMenu doctorsPatientPersonalInfo = new DoctorsPatientPersonalInfoMenu();
            doctorsPatientPersonalInfo.Show();

        }

        private void labelPatientDetailsTextPart2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorsPatientPersonalInfoMenu doctorsPatientPersonalInfo = new DoctorsPatientPersonalInfoMenu();
            doctorsPatientPersonalInfo.Show();
        }

    }
}
