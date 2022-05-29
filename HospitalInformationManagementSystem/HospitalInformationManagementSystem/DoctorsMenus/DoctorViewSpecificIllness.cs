using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalInformationManagementSystem.DoctorsMenus;

namespace HospitalInformationManagementSystem
{
    public partial class DoctorViewSpecificIllness : Form
    {
        //Calls and assigns the IllnessInformation class ready to use
        IllnessInformation illnessInformation = new IllnessInformation();

        //local variables used within this form
        public List<string> idAvailable = new List<string>();
        public DoctorViewSpecificIllness()
        {
            InitializeComponent();
        }

        //Gets all the current ID from the class and stores them in idAvailable list to use
        private void DoctorViewSpecificIllness_Load(object sender, EventArgs e)
        {
            illnessInformation.GetAllCurrentTreatmentIDs();
            idAvailable = illnessInformation.currentExistingTreatmentIDs;

        }

        /*Once the user presses Find the ID inputted is validates and sent to the class if successful. The class
        * gets all the data assosciated with that ID and sends it back which is then displayed for the user to see*/
        private void buttonFindID_Click(object sender, EventArgs e)
        {
            bool userExists = false;
            String userIDInputted = Convert.ToString(textBoxTreatmentID.Text);

            for (int i = 0; i < idAvailable.Count; i++)
            {
                if (userIDInputted == idAvailable[i])
                {
                    userExists = true;
                }
            }
            if (textBoxTreatmentID.Text == "")
            {
                MessageBox.Show("Please enter a Treatment ID to search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (userExists == false)
                {
                    MessageBox.Show("The Treatment ID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    illnessInformation.treatmentID = textBoxTreatmentID.Text;
                    illnessInformation.GetIllnessInformation();
                    labelPatientIDInsert.Text = illnessInformation.patientID;
                    labelIllnessInsert.Text = illnessInformation.illness;
                    labelIllnessTypeInsert.Text = illnessInformation.illnessType;
                    labelTreatmentStageInsert.Text = illnessInformation.treatmentStage;
                    labelDateCheckedInInsert.Text = illnessInformation.dateCheckedIn;
                    labelDateCheckedOutInsert.Text = illnessInformation.dateCheckedOut;
                    textBoxNotesInsert.Text = illnessInformation.notes;
                }
            }
        }

        //Clears all the fields ready to show new information
        private void buttonNewSearch_Click(object sender, EventArgs e)
        {
            textBoxTreatmentID.Text = "";
            labelPatientIDInsert.Text = "";
            labelIllnessInsert.Text = "";
            labelIllnessTypeInsert.Text = "";
            labelTreatmentStageInsert.Text = "";
            labelDateCheckedInInsert.Text = "";
            labelDateCheckedOutInsert.Text = "";
            textBoxNotesInsert.Text = "";
        }



        /*This functions shows a message box to the user to confirm they would like to go back. If they press yes
        this window is closed and the previous menu is displayed*/
        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DoctorIllnessMenu doctorIllnessMenu = new DoctorIllnessMenu();
                doctorIllnessMenu.Show();
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
                DoctorIllnessMenu doctorIllnessMenu = new DoctorIllnessMenu();
                doctorIllnessMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
