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
    public partial class DoctorViewSpecificPatient : Form
    {
        PatientPersonalDetails patientPersonalDetails = new PatientPersonalDetails();
        public List<string> idAvailable = new List<string>();
        public double maximumIDNumber;
        public DoctorViewSpecificPatient()
        {
            InitializeComponent();
        }

        private void DoctorViewSpecificPatient_Load(object sender, EventArgs e)
        {
            patientPersonalDetails.GetAllCurrentPatientIDs();
            idAvailable = patientPersonalDetails.currentExistingIDs;
        }

        private void buttonFindID_Click(object sender, EventArgs e)
        {

            bool userExists = false;
            String userIDInputted = Convert.ToString(textBoxPatientID.Text);

            for (int i = 0; i < idAvailable.Count; i++)
            {
                if (userIDInputted == idAvailable[i])
                {
                    userExists = true;
                }
            }

            if (textBoxPatientID.Text == "")
            {
                MessageBox.Show("Please enter a Patient ID to search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (userExists == false)
                {
                    MessageBox.Show("The Patient ID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    patientPersonalDetails.patientID = textBoxPatientID.Text;
                    patientPersonalDetails.GetPatientDetails();
                    labelNHSNumberInput.Text = patientPersonalDetails.nhsNumber;
                    labelFirstNameInput.Text = patientPersonalDetails.firstName;
                    labelMiddleNameInput.Text = patientPersonalDetails.middleName;
                    labelLastNameInput.Text = patientPersonalDetails.lastName;
                    labelAgeInput.Text = patientPersonalDetails.age;
                    labelGenderInput.Text = patientPersonalDetails.gender;
                    labelDateOfBirthInput.Text = patientPersonalDetails.dateOfBirth;
                    labelCountryOfBirthInput.Text = patientPersonalDetails.countryOfBirth;
                    labelEmailInput.Text = patientPersonalDetails.email;
                    labelPhoneNumberInput.Text = patientPersonalDetails.phoneNumber;
                    labelHomeNumberInput.Text = patientPersonalDetails.homeNumber;
                    labelAddressInput.Text = patientPersonalDetails.address;
                    labelCityInput.Text = patientPersonalDetails.city;
                    labelPostcodeInput.Text = patientPersonalDetails.postcode;
                    labelBloodTypeInput.Text = patientPersonalDetails.bloodType;
                }

            }
        }

        private void buttonNewSearch_Click(object sender, EventArgs e)
        {
            textBoxPatientID.Text = "";
            labelNHSNumberInput.Text = "";
            labelFirstNameInput.Text = "";
            labelMiddleNameInput.Text = "";
            labelLastNameInput.Text = "";
            labelAgeInput.Text = "";
            labelGenderInput.Text = "";
            labelDateOfBirthInput.Text = "";
            labelCountryOfBirthInput.Text = "";
            labelEmailInput.Text = "";
            labelPhoneNumberInput.Text = "";
            labelHomeNumberInput.Text = "";
            labelAddressInput.Text = "";
            labelCityInput.Text = "";
            labelPostcodeInput.Text = "";
            labelBloodTypeInput.Text = "";

        }

        private void labelGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DoctorsPatientPersonalInfoMenu doctorsPatientPersonalInfoMenu = new DoctorsPatientPersonalInfoMenu();
                doctorsPatientPersonalInfoMenu.Show();
                this.Close();
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
                DoctorsPatientPersonalInfoMenu doctorsPatientPersonalInfoMenu = new DoctorsPatientPersonalInfoMenu();
                doctorsPatientPersonalInfoMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
