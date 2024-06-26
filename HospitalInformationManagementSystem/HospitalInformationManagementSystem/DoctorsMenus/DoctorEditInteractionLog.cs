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
    public partial class DoctorEditInteractionLog : Form
    {
        //Calls and assigns the Interaction class ready to use
        InteractionLog interactionLog = new InteractionLog();

        //local variables used within this form
        public Int64 idNumber;
        public List<string> idAvailable = new List<string>();
        public DoctorEditInteractionLog()
        {
            InitializeComponent();
        }

        /*Gets all the current ID from the class and stores them in idAvailable list to use.
         * Also gets the information to display in the combo boxes from the class.*/
        private void DoctorEditInteractionLog_Load(object sender, EventArgs e)
        {

            interactionLog.GetAllCurrentlogIDs();
            idAvailable = interactionLog.currentExistingLogIDs;

            interactionLog.GetAllCurrentPatientIDs();
            comboBoxPatientID.DataSource = interactionLog.currentExistingPatientIDs;
            comboBoxPatientID.DisplayMember = "PatientID";
            comboBoxPatientID.ValueMember = "PatientID";

            interactionLog.GetAllCurrentLoginIDs();
            comboBoxLogInID.DataSource = interactionLog.currentExistingLoginIDs;
            comboBoxLogInID.DisplayMember = "LogInID";
            comboBoxLogInID.ValueMember = "LogInID";
        }

        /*Once the user presses Find the ID inputted is validates and sent to the class if successful. The class
        * gets all the data assosciated with that ID and sends it back which is then displayed for the user to see
         * and edit*/
        private void buttonFindID_Click(object sender, EventArgs e)
        {
            bool userExists = false;
            String userIDInputted = Convert.ToString(textBoxLogID.Text);

            for (int i = 0; i < idAvailable.Count; i++)
            {
                if (userIDInputted == idAvailable[i])
                {
                    userExists = true;
                }
            }

            if (textBoxLogID.Text == "")
            {
                MessageBox.Show("Please enter a Patient ID to search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Double logIDInputted = Convert.ToDouble(textBoxLogID.Text);
                if (userExists == false)
                {
                    MessageBox.Show("The Log ID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    interactionLog.logID = textBoxLogID.Text;
                    interactionLog.GetInteractionLog();
                    comboBoxLogInID.Text = interactionLog.loginID;
                    textBoxStaffName.Text = interactionLog.staffName;
                    comboBoxPatientID.Text = interactionLog.patientID;
                    textBoxDate.Text = interactionLog.date;
                    comboBoxShift.Text = interactionLog.shift;
                    textBoxInteractionNotes.Text = interactionLog.interactionNotes;
                }
            }
        }

        /*Once the user has edited the information they wish and clicked the update button. The system validates the inputted fields
         * and if successful sends them to the class to update. After doing that this window displays a messagebox letting the user know 
         the information was updated successfully and clears all the fields ready for to edit again.*/
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string date = textBoxDate.Text;
            if (comboBoxLogInID.Text == "" || textBoxStaffName.Text == "" || comboBoxPatientID.Text == "" || textBoxDate.Text == "" || comboBoxShift.Text == "" || textBoxInteractionNotes.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (date.Length != 10)
            {
                MessageBox.Show("Make sure the Date is filled in correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you would like to Edit Log = " + textBoxLogID.Text + "'s Information?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    interactionLog.logID = textBoxLogID.Text;
                    interactionLog.loginID = comboBoxLogInID.Text;
                    interactionLog.staffName = textBoxStaffName.Text;
                    interactionLog.patientID = comboBoxPatientID.Text;
                    interactionLog.date = textBoxDate.Text;
                    interactionLog.shift = comboBoxShift.Text;
                    interactionLog.interactionNotes = textBoxInteractionNotes.Text;
                    interactionLog.EditIllnessInformation();

                    MessageBox.Show("Interaction Log Information successfully updated. ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.None);
                    textBoxLogID.Text = "";
                    comboBoxLogInID.Text = "";
                    textBoxStaffName.Text = "";
                    comboBoxPatientID.Text = "";
                    textBoxDate.ResetText();
                    comboBoxShift.Text = "";
                    textBoxInteractionNotes.Text = "";
                }
            }
        }

        /*This functions shows a message box to the user to confirm they would like to go back. If they press yes
        this window is closed and the previous menu is displayed*/
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DoctorInteractionLogMenu doctorInteractionLogMenu = new DoctorInteractionLogMenu();
                doctorInteractionLogMenu.Show();
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
                DoctorInteractionLogMenu doctorInteractionLogMenu = new DoctorInteractionLogMenu();
                doctorInteractionLogMenu.Show();
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
                DoctorInteractionLogMenu doctorInteractionLogMenu = new DoctorInteractionLogMenu();
                doctorInteractionLogMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
