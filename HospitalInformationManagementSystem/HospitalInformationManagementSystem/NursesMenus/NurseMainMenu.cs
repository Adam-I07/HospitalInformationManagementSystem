using HospitalInformationManagementSystem.DoctorsMenus;
using HospitalInformationManagementSystem.NursesMenus;
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
    public partial class NurseMainMenu : Form
    {
        public NurseMainMenu()
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
            NursePatientPersonalInfoMenu nursePatientPersonalInfoMenu = new NursePatientPersonalInfoMenu();
            nursePatientPersonalInfoMenu.Show();
        }

        private void labelPatientDetailsTextPart1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NursePatientPersonalInfoMenu nursePatientPersonalInfoMenu = new NursePatientPersonalInfoMenu();
            nursePatientPersonalInfoMenu.Show();
        }

        private void labelPatientDetailsTextPart2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NursePatientPersonalInfoMenu nursePatientPersonalInfoMenu = new NursePatientPersonalInfoMenu();
            nursePatientPersonalInfoMenu.Show();
        }

        //The following picture and text act as buttons. When clicked opens the IllnessInformation Menu and closes the Main Menu.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseIllnessMenu nurseIllnessMenu = new NurseIllnessMenu();
            nurseIllnessMenu.Show();
        }
        private void labelIIlnessTextPart1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseIllnessMenu nurseIllnessMenu = new NurseIllnessMenu();
            nurseIllnessMenu.Show();
        }
        private void labelIllnessTextPart2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseIllnessMenu nurseIllnessMenu = new NurseIllnessMenu();
            nurseIllnessMenu.Show();
        }

        //The following picture and text act as buttons. When clicked opens the InteractionLog Menu and closes the Main Menu.
        private void pictureBoxInteractionLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseInteractionLogMenu nurseInteractionLogMenu = new NurseInteractionLogMenu();
            nurseInteractionLogMenu.Show();
        }

        private void labelInteractionLogTextPart1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseInteractionLogMenu nurseInteractionLogMenu = new NurseInteractionLogMenu();
            nurseInteractionLogMenu.Show();
        }

        private void labelInteractionLogTextPart2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseInteractionLogMenu nurseInteractionLogMenu = new NurseInteractionLogMenu();
            nurseInteractionLogMenu.Show();
        }

        //The following picture and text act as buttons. When clicked opens the Requests Menu and closes the Main Menu.
        private void pictureBoxRequests_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseRequestMenu nurseRequestMenu = new NurseRequestMenu();
            nurseRequestMenu.Show();
        }

        private void labelRequests_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseRequestMenu nurseRequestMenu = new NurseRequestMenu();
            nurseRequestMenu.Show();
        }
    }
}
