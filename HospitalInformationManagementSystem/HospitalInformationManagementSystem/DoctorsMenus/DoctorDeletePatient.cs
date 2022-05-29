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
    public partial class DoctorDeletePatientPersonalInfo : Form
    {
        //Calls and assigns the PatientPersonalDetails class ready to use
        PatientPersonalDetails patientPersonalDetails = new PatientPersonalDetails();

        //local variables used within this form
        public List<string> idAvailable = new List<string>();
        public DoctorDeletePatientPersonalInfo()
        {
            InitializeComponent();
        }


        /*Gets all the current Requests from the Class and displays them in DataGridView for the user to see.
        * While also getting all the current IDs used and stores them in the idAvailable list*/
        private void DoctorDeletePatientPersonalInfo_Load(object sender, EventArgs e)
        {
            patientPersonalDetails.LoadCurrentDetails();
            dataGridViewShowUserDetail.DataSource = patientPersonalDetails.currentPatientDetails.Tables[0];
            patientPersonalDetails.GetAllCurrentPatientIDs();
            idAvailable = patientPersonalDetails.currentExistingIDs;
        }


        /*When the User presses the Delete button the system validates the ID. If it passes the validation the ID
        * is sent to the class to delete. Once successfully deleted the system closes this window and displays the previous one*/
        private void buttonDeleteUser_Click(object sender, EventArgs e)
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
                MessageBox.Show("Please enter a Patient ID to delete!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (userExists == false)
            {
                MessageBox.Show("The ID entered does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you would like to delete PatientID = " + textBoxPatientID.Text + "?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    patientPersonalDetails.patientID = textBoxPatientID.Text;
                    patientPersonalDetails.DeleteExistingPatient();
                    this.Close();
                    DoctorsPatientPersonalInfoMenu doctorsPatientPersonalInfoMenu = new DoctorsPatientPersonalInfoMenu();
                    doctorsPatientPersonalInfoMenu.Show();
                    MessageBox.Show("Patient Deleted Successfully", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }


        /*The following functions do the same thing. They show a message box to the user to confirm they would like to go back. If they press yes
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
