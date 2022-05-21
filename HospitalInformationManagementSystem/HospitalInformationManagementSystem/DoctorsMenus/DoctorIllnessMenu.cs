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
    public partial class DoctorIllnessMenu : Form
    {
        IllnessInformation illnessInformation = new IllnessInformation();
        public List<string> idAvailable = new List<string>();

        public DoctorIllnessMenu()
        {
            InitializeComponent();
        }

        private void DoctorIllnessMenu_Load(object sender, EventArgs e)
        {
            illnessInformation.LoadCurrentDetails();
            dataGridViewDisplayIllnessInfo.DataSource = illnessInformation.currentIllnessInformation.Tables[0];

            foreach (DataGridViewRow item in dataGridViewDisplayIllnessInfo.Rows)
            {
                idAvailable.Add(item.Cells[1].Value.ToString());
            }
        }

        private void buttonAddNewIllness_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorAddIllness doctorAddIllness = new DoctorAddIllness();
            doctorAddIllness.Show();
        }

        private void buttonEditIllnessInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorEditIllness doctorEditIllness = new DoctorEditIllness();
            doctorEditIllness.Show();
        }

        private void labelGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                DoctorsMainMenu doctorsMainMenu = new DoctorsMainMenu();
                doctorsMainMenu.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                DoctorsMainMenu doctorsMainMenu = new DoctorsMainMenu();
                doctorsMainMenu.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void buttonDeleteIllnessInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDeleteIllness doctorDeleteIllness = new DoctorDeleteIllness();
            doctorDeleteIllness.Show();
        }

        private void buttonSpecificIllnessInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorViewSpecificIllness doctorViewSpecificIllness = new DoctorViewSpecificIllness();
            doctorViewSpecificIllness.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String patientIDInputted = textBoxSearchPatient.Text.ToString();
            bool isValidUserID = false;
            for (int i = 0; i < idAvailable.Count(); i++)
            {
                if (idAvailable[i] == patientIDInputted)
                {
                    isValidUserID = true;
                    break;
                }
            }

            if (textBoxSearchPatient.Text == "")
            {
                MessageBox.Show("Please enter a Patient ID to search!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isValidUserID == false)
            {
                MessageBox.Show("The ID entered does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                illnessInformation.userSelectedPatientID = patientIDInputted;
                illnessInformation.FilterIlnessInformation();
                dataGridViewDisplayIllnessInfo.DataSource = illnessInformation.currentIllnessInformation.Tables[0];
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            illnessInformation.LoadCurrentDetails();
            dataGridViewDisplayIllnessInfo.DataSource = illnessInformation.currentIllnessInformation.Tables[0];

        }
    }
}
