using HospitalInformationManagementSystem.DoctorsMenus;
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
    }
}
