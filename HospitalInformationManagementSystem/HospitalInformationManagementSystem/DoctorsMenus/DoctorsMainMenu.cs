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

        //Displays a message box to confirm if they want to log out. If they select Yes the system logs them out and displays the login Form.
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

        //The following picture and text act as buttons. When clicked opens the PatientPersonalInformation Menu and closes the Main Menu.
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

        //The following picture and text act as buttons. When clicked opens the IllnessInformation Menu and closes the Main Menu.
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

        //The following picture and text act as buttons. When clicked opens the InteractionLog Menu and closes the Main Menu.
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

        //The following picture and text act as buttons. When clicked opens the Requests Menu and closes the Main Menu.
        private void pictureBoxRequests_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorRequestMenu doctorRequestMenu = new DoctorRequestMenu();
            doctorRequestMenu.Show();
        }

        private void labelRequests_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorRequestMenu doctorRequestMenu = new DoctorRequestMenu();
            doctorRequestMenu.Show();
        }
    }
}
