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
    public partial class DoctorEditPatientDetails : Form
    {
        PatientPersonalDetails patientPersonalDetails = new PatientPersonalDetails();
        public double maximumIDNumber;
        public List<string> idAvailable = new List<string>();
        public DoctorEditPatientDetails()
        {
            InitializeComponent();
        }

        private void DoctorEditPatientDetails_Load(object sender, EventArgs e)
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
                    textBoxNHSNumber.Text = patientPersonalDetails.nhsNumber;
                    textBoxFirstName.Text = patientPersonalDetails.firstName;
                    textBoxMiddleName.Text = patientPersonalDetails.middleName;
                    textBoxLastName.Text = patientPersonalDetails.lastName;
                    textBoxAge.Text = patientPersonalDetails.age;
                    comboBoxGender.Text = patientPersonalDetails.gender;
                    textBoxDateOfBirth.Text = patientPersonalDetails.dateOfBirth;
                    comboBoxCountry.Text = patientPersonalDetails.countryOfBirth;
                    textBoxEmail.Text = patientPersonalDetails.email;
                    textBoxPhoneNumber.Text = patientPersonalDetails.phoneNumber;
                    textBoxHomeNumber.Text = patientPersonalDetails.homeNumber;
                    textBoxAddress.Text = patientPersonalDetails.address;
                    comboBoxCity.Text = patientPersonalDetails.city;
                    textBoxPostcode.Text = patientPersonalDetails.postcode;
                    comboBoxBloodType.Text = patientPersonalDetails.bloodType;
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string nhsNumber = textBoxNHSNumber.Text;
            string dateOfBirth = textBoxDateOfBirth.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string postcode = textBoxPostcode.Text;
            String userIDInputted = Convert.ToString(textBoxPatientID.Text);
            bool userExists = false;

            for (int i = 0; i < idAvailable.Count; i++)
            {
                if (userIDInputted == idAvailable[i])
                {
                    userExists = true;
                }
            }

            if (textBoxNHSNumber.Text == "" || textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxAge.Text == "" || comboBoxGender.Text == "" || textBoxAge.Text == "" || textBoxDateOfBirth.Text == "" || comboBoxCountry.Text == "" || textBoxEmail.Text == "" || textBoxPhoneNumber.Text == "" || textBoxAddress.Text == "" || comboBoxCity.Text == "" || textBoxPostcode.Text == "" || comboBoxBloodType.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nhsNumber.Length != 12 || dateOfBirth.Length != 10 || phoneNumber.Length != 11 || postcode.Length != 8)
            {
                MessageBox.Show("Make sure the NHS Number, Date of Birth, Phone Number and Postcode are filled in correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (userExists == false)
                {
                    MessageBox.Show("The Patient ID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you would like to Edit PatientID = " + textBoxPatientID.Text + "?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        patientPersonalDetails.patientID = textBoxPatientID.Text;
                        patientPersonalDetails.nhsNumber = textBoxNHSNumber.Text;
                        patientPersonalDetails.firstName = textBoxFirstName.Text;
                        patientPersonalDetails.middleName = textBoxMiddleName.Text;
                        patientPersonalDetails.lastName = textBoxLastName.Text;
                        patientPersonalDetails.age = textBoxAge.Text;
                        patientPersonalDetails.gender = comboBoxGender.Text;
                        patientPersonalDetails.dateOfBirth = textBoxDateOfBirth.Text;
                        patientPersonalDetails.countryOfBirth = comboBoxCountry.Text;
                        patientPersonalDetails.email = textBoxEmail.Text;
                        patientPersonalDetails.phoneNumber = textBoxPhoneNumber.Text;
                        patientPersonalDetails.homeNumber = textBoxHomeNumber.Text;
                        patientPersonalDetails.address = textBoxAddress.Text;
                        patientPersonalDetails.city = comboBoxCity.Text;
                        patientPersonalDetails.postcode = textBoxPostcode.Text;
                        patientPersonalDetails.bloodType = comboBoxBloodType.Text;
                        patientPersonalDetails.EditPatient();

                        MessageBox.Show("Patient details successfully updated. ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.None);
                        textBoxPatientID.Text = "";
                        textBoxNHSNumber.Text = "";
                        textBoxFirstName.Text = "";
                        textBoxMiddleName.Text = "";
                        textBoxLastName.Text = "";
                        textBoxAge.Text = "";
                        comboBoxGender.ResetText();
                        textBoxDateOfBirth.Text = "";
                        comboBoxCountry.ResetText();
                        textBoxEmail.Text = "";
                        textBoxPhoneNumber.Text = "";
                        textBoxHomeNumber.Text = "";
                        textBoxAddress.Text = "";
                        comboBoxCity.ResetText();
                        textBoxPostcode.Text = "";
                        comboBoxBloodType.ResetText();
                    }
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
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
