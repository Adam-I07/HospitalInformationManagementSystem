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
    public partial class NurseViewSpecificIllness : Form
    {
        IllnessInformation illnessInformation = new IllnessInformation();
        public List<string> idAvailable = new List<string>();
        public NurseViewSpecificIllness()
        {
            InitializeComponent();
        }

        private void NurseViewSpecificIllness_Load(object sender, EventArgs e)
        {
            illnessInformation.GetAllCurrentTreatmentIDs();
            idAvailable = illnessInformation.currentExistingTreatmentIDs;
        }

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

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NurseIllnessMenu nurseIllnessMenu = new NurseIllnessMenu();
                nurseIllnessMenu.Show();
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
                NurseIllnessMenu nurseIllnessMenu = new NurseIllnessMenu();
                nurseIllnessMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
