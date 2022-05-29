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
        //Calls and assigns the PatientPersonalInformation class ready to use
        PatientPersonalDetails patientPersonalDetails = new PatientPersonalDetails();


        //local variables used within this form
        public List<string> idAvailable = new List<string>();
        public double maximumIDNumber;
        public DoctorViewSpecificPatient()
        {
            InitializeComponent();
        }

        //Gets all the current ID from the class and stores them in idAvailable list to use
        private void DoctorViewSpecificPatient_Load(object sender, EventArgs e)
        {
            patientPersonalDetails.GetAllCurrentPatientIDs();
            idAvailable = patientPersonalDetails.currentExistingIDs;
        }

        /*Once the user presses Find the ID inputted is validates and sent to the class if successful. The class
        *gets all the data assosciated with that ID and sends it back which is then displayed for the user to see*/
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


        //Clears all the fields ready to show new information
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


        /*This functions shows a message box to the user to confirm they would like to go back. If they press yes
        this window is closed and the previous menu is displayed*/
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
