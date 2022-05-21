using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HospitalInformationManagementSystem.DoctorsMenus;

namespace HospitalInformationManagementSystem
{
    public partial class DoctorsPatientPersonalInfoMenu : Form
    {
        PatientPersonalDetails patientPersonalDetails = new PatientPersonalDetails();
        public List<string> currentPatientFirstName = new List<string>();
        public DoctorsPatientPersonalInfoMenu()
        {
            InitializeComponent();
        }

        private void DoctorsPatientPersonalInfoMenu_Load(object sender, EventArgs e)
        {
            patientPersonalDetails.LoadCurrentDetails();
            dataGridViewLoginDetails.DataSource = patientPersonalDetails.currentPatientDetails.Tables[0];

            foreach (DataGridViewRow item in dataGridViewLoginDetails.Rows)
            {
                currentPatientFirstName.Add(item.Cells[2].Value.ToString().ToLower());
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

        private void buttonAddNewPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorAddPatient doctorAddPatient = new DoctorAddPatient();
            doctorAddPatient.Show();
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorEditPatientDetails doctorEditPatientDetails = new DoctorEditPatientDetails();
            doctorEditPatientDetails.Show();
        }

        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDeletePatientPersonalInfo doctorDeletePatientPersonalInfo = new DoctorDeletePatientPersonalInfo();
            doctorDeletePatientPersonalInfo.Show();
        }

        private void buttonViewPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorViewSpecificPatient doctorViewSpecificPatient = new DoctorViewSpecificPatient();
            doctorViewSpecificPatient.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String firstNameInputted = textBoxSearchFirstName.Text.ToString().ToLower();
            bool isValidUserID = false;
            for (int i = 0; i < currentPatientFirstName.Count(); i++)
            {
                if (currentPatientFirstName[i] == firstNameInputted)
                {
                    isValidUserID = true;
                    break;
                }
            }

            if (textBoxSearchFirstName.Text == "")
            {
                MessageBox.Show("Please enter a First Name to search!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isValidUserID == false)
            {
                MessageBox.Show("The First Name entered does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                patientPersonalDetails.userFirstNameSearch = firstNameInputted;
                patientPersonalDetails.FilterPatientDetails();
                dataGridViewLoginDetails.DataSource = patientPersonalDetails.currentPatientDetails.Tables[0];
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            currentPatientFirstName.Clear();
            patientPersonalDetails.LoadCurrentDetails();
            dataGridViewLoginDetails.DataSource = patientPersonalDetails.currentPatientDetails.Tables[0];

            foreach (DataGridViewRow item in dataGridViewLoginDetails.Rows)
            {
                currentPatientFirstName.Add(item.Cells[2].Value.ToString().ToLower());
            }
        }
    }
}
