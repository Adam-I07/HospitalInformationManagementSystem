﻿using System;
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
    public partial class DoctorAddIllness : Form
    {
        //Calls and assigns the IllnessInformation class ready to use
        IllnessInformation illnessInformation = new IllnessInformation();

        //local variables used within this form
        public Int64 idNumber;
        public List<string> idAvailable = new List<string>();
        public DoctorAddIllness()
        {
            InitializeComponent();
        }

        /*When the window is first loaded the system gets all the current ID's in the database and assigns them to the id available list, which then assigns the next available ID the user can use
        Also gets all the Patient ID used and enters them into the combo box for Patient ID*/
        private void DoctorAddIllness_Load(object sender, EventArgs e)
        {

            illnessInformation.GetAllCurrentTreatmentIDs();
            idAvailable = illnessInformation.currentExistingTreatmentIDs;
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
            labelTreatmentIDCurrent.Text = idNumber.ToString();

            illnessInformation.GetAllCurrentPatientIDs();
            comboBoxPatientID.DataSource = illnessInformation.currentExistingPatientIDs;
            comboBoxPatientID.DisplayMember = "PatientID";
            comboBoxPatientID.ValueMember = "PatientID";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string checkedInDate = textBoxDateCheckedIn.Text;
            string checkedOutDate = textBoxDateCheckedOut.Text;
            string notes = textBoxNotes.Text;
            
            if(notes == "")
            {
                notes = "Pending";
            }

            if(checkedOutDate == "  -  -")
            {
                checkedOutDate = "00-00-0000";
            }

            if(comboBoxPatientID.Text == "" || textBoxIllness.Text == "" || textBoxIllnessType.Text == ""|| comboBoxTreatmentStage.Text == "" || textBoxDateCheckedIn.Text == "" || checkedOutDate == ""|| notes == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(checkedInDate.Length != 10 || checkedOutDate.Length != 10)
            {
                MessageBox.Show("Make sure Checked In Date and Checked Out Date are filled in correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                illnessInformation.treatmentID = labelTreatmentIDCurrent.Text;
                illnessInformation.patientID = comboBoxPatientID.Text;
                illnessInformation.illness = textBoxIllness.Text;
                illnessInformation.illnessType = textBoxIllnessType.Text;
                illnessInformation.treatmentStage = comboBoxTreatmentStage.Text;
                illnessInformation.dateCheckedIn = textBoxDateCheckedIn.Text;
                illnessInformation.dateCheckedOut = textBoxDateCheckedOut.Text;
                illnessInformation.notes = textBoxNotes.Text;
                illnessInformation.AddIllnessInformation();
                MessageBox.Show("The Patient Illness Information has been added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.None);
                DoctorIllnessMenu doctorIllnessMenu = new DoctorIllnessMenu();
                doctorIllnessMenu.Show();
                this.Close();
            }
        }

        /*The following functions do the same thing. They show a message box to the user to confirm they would like to go back. If they press yes
           this window is closed and the previous menu is displayed*/
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
