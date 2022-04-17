using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.DoctorsMenus
{
    public partial class DoctorsMainMenu : Form
    {
        public DoctorsMainMenu()
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
            DoctorsPatientPersonalInfoMenu doctorsPatientPersonalInfoMenu = new DoctorsPatientPersonalInfoMenu();
            doctorsPatientPersonalInfoMenu.Show();
        }

        private void labelPatientDetailsTextPart1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorsPatientPersonalInfoMenu doctorsPatientPersonalInfoMenu = new DoctorsPatientPersonalInfoMenu();
            doctorsPatientPersonalInfoMenu.Show();
        }

        private void labelPatientDetailsTextPart2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorsPatientPersonalInfoMenu doctorsPatientPersonalInfoMenu = new DoctorsPatientPersonalInfoMenu();
            doctorsPatientPersonalInfoMenu.Show();
        }

        private void labelIIlnessTextPart1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorIllnessMenu doctorIllnessMenu = new DoctorIllnessMenu();
            doctorIllnessMenu.Show();
        }

        private void labelIllnessTextPart2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorIllnessMenu doctorIllnessMenu = new DoctorIllnessMenu();
            doctorIllnessMenu.Show();
        }

        private void pictureBoxIllnessInformationLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorIllnessMenu doctorIllnessMenu = new DoctorIllnessMenu();
            doctorIllnessMenu.Show();
        }

        private void pictureBoxInteractionLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorInteractionLogMenu doctorInteractionLogMenu = new DoctorInteractionLogMenu();
            doctorInteractionLogMenu.Show();
        }

        private void labelInteractionLogTextPart1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorInteractionLogMenu doctorInteractionLogMenu = new DoctorInteractionLogMenu();
            doctorInteractionLogMenu.Show();
        }

        private void labelInteractionLogTextPart2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorInteractionLogMenu doctorInteractionLogMenu = new DoctorInteractionLogMenu();
            doctorInteractionLogMenu.Show();
        }
    }
}
