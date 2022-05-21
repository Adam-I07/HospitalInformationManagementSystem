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
    public partial class DoctorAddPatient : Form
    {
        PatientPersonalDetails patientPersonalDetails = new PatientPersonalDetails();
        public List<string> idAvailable = new List<string>();
        public Int64 idNumber;
        public DoctorAddPatient()
        {
            InitializeComponent();
        }

        private void DoctorAddPatient_Load(object sender, EventArgs e)
        {

            patientPersonalDetails.GetAllCurrentPatientIDs();
            idAvailable = patientPersonalDetails.currentExistingIDs;
            int nextAvailableID = 0;
            for (int i = 0; i < idAvailable.Count; i++)
            {
                int currentID = Convert.ToInt32(idAvailable[i]);
                if (nextAvailableID < currentID)
                {
                    idNumber = currentID;
                }
            }

            idNumber = idNumber + 1;
            labelPatientIDCurrent.Text = idNumber.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string nhsNumber = textBoxNHSNumber.Text;
            string dateOfBirth = textBoxDateOfBirth.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string postcode = textBoxPostcode.Text;


            if (textBoxNHSNumber.Text == "" || textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxAge.Text == "" || comboBoxGender.Text == "" || textBoxDateOfBirth.Text == "" || comboBoxCountry.Text == "" || textBoxEmail.Text == "" || textBoxPhoneNumber.Text == "" || textBoxAddress.Text == "" || comboBoxCity.Text == "" || textBoxPostcode.Text == "     " || comboBoxBloodType.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nhsNumber.Length != 12 || dateOfBirth.Length != 10 || phoneNumber.Length != 11 || postcode.Length != 8)
            {
                MessageBox.Show("Make sure the NHS Number, Date of Birth, Phone Number and Postcode are filled in correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                patientPersonalDetails.patientID = labelPatientIDCurrent.Text;
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
                patientPersonalDetails.AddPatient();
                MessageBox.Show("The Patient has been added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.None);
                DoctorsPatientPersonalInfoMenu doctorsPatientPersonalMenu = new DoctorsPatientPersonalInfoMenu();
                doctorsPatientPersonalMenu.Show();
                this.Close();

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DoctorsPatientPersonalInfoMenu doctorsPatientPersonalMenu = new DoctorsPatientPersonalInfoMenu();
                doctorsPatientPersonalMenu.Show();
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
                DoctorsPatientPersonalInfoMenu doctorsPatientPersonalMenu = new DoctorsPatientPersonalInfoMenu();
                doctorsPatientPersonalMenu.Show();
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
                DoctorsPatientPersonalInfoMenu doctorsPatientPersonalMenu = new DoctorsPatientPersonalInfoMenu();
                doctorsPatientPersonalMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
