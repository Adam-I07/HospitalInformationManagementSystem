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
    public partial class DoctorEditIllness : Form
    {

        IllnessInformation illnessInformation = new IllnessInformation();
        public List<string> idAvailable = new List<string>();
        public DoctorEditIllness()
        {
            InitializeComponent();
        }

        private void DoctorEditIllness_Load(object sender, EventArgs e)
        {
            illnessInformation.GetAllCurrentTreatmentIDs();
            idAvailable = illnessInformation.currentExistingTreatmentIDs;
            illnessInformation.GetAllCurrentPatientIDs();
            comboBoxPatientID.DataSource = illnessInformation.currentExistingPatientIDs;
            comboBoxPatientID.DisplayMember = "PatientID";
            comboBoxPatientID.ValueMember = "PatientID";
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
                    comboBoxPatientID.Text = illnessInformation.patientID;
                    textBoxIllness.Text = illnessInformation.illness;
                    textBoxIllnessType.Text = illnessInformation.illnessType;
                    comboBoxTreatmentStage.Text = illnessInformation.treatmentStage;
                    textBoxDateCheckedIn.Text = illnessInformation.dateCheckedIn;
                    textBoxDateCheckedOut.Text = illnessInformation.dateCheckedOut;
                    textBoxNotes.Text = illnessInformation.notes;
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string checkedInDate = textBoxDateCheckedIn.Text;
            string checkedOutDate = textBoxDateCheckedOut.Text;
            string notes = textBoxNotes.Text;

            if (notes == "")
            {
                notes = "Pending";
            }

            if (checkedOutDate == "  -  -")
            {
                checkedOutDate = "00-00-0000";
            }

            if (comboBoxPatientID.Text == "" || textBoxIllness.Text == "" || textBoxIllnessType.Text == "" || comboBoxTreatmentStage.Text == "" || textBoxDateCheckedIn.Text == "" || checkedOutDate == "" || notes == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkedInDate.Length != 10 || checkedOutDate.Length != 10)
            {
                MessageBox.Show("Make sure Checked In Date and Checked Out Date are filled in correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you would like to Edit Treatment " + textBoxTreatmentID.Text + "'s Information?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    illnessInformation.treatmentID = textBoxTreatmentID.Text;
                    illnessInformation.patientID = comboBoxPatientID.Text;
                    illnessInformation.illness = textBoxIllness.Text;
                    illnessInformation.illnessType = textBoxIllnessType.Text;
                    illnessInformation.treatmentStage = comboBoxTreatmentStage.Text;
                    illnessInformation.dateCheckedIn = textBoxDateCheckedIn.Text;
                    illnessInformation.dateCheckedOut = textBoxDateCheckedOut.Text;
                    illnessInformation.notes = textBoxNotes.Text;
                    illnessInformation.EditIllnessInformation();

                    MessageBox.Show("Patient Illness Information details successfully updated. ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.None);
                    textBoxTreatmentID.Text = "";
                    comboBoxPatientID.Text = "";
                    textBoxIllness.Text = "";
                    textBoxIllnessType.Text = "";
                    comboBoxTreatmentStage.ResetText();
                    textBoxDateCheckedIn.Text = "";
                    textBoxDateCheckedOut.Text = "";
                    textBoxNotes.Text = "";
                }
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

        private void buttonCancel_Click(object sender, EventArgs e)
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
