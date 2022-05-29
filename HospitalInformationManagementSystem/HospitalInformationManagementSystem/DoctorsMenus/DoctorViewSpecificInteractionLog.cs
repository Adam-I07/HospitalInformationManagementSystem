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
    
    public partial class DoctorViewSpecificInteractionLog : Form
    {
        //Calls and assigns the InteractionLog class ready to use
        InteractionLog interactionLog = new InteractionLog();

        //local variables used within this form
        public List<string> idAvailable = new List<string>();
        public DoctorViewSpecificInteractionLog()
        {
            InitializeComponent();
        }

        //Gets all the current ID from the class and stores them in idAvailable list to use
        private void DoctorViewSpecificInformationLog_Load(object sender, EventArgs e)
        {
            interactionLog.GetAllCurrentlogIDs();
            idAvailable = interactionLog.currentExistingLogIDs;
        }

        /*Once the user presses Find the ID inputted is validates and sent to the class if successful. The class
        *gets all the data assosciated with that ID and sends it back which is then displayed for the user to see*/
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
                MessageBox.Show("Please enter a Log ID to search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    labelLogInIDInsert.Text = interactionLog.loginID;
                    labelStaffNameInsert.Text = interactionLog.staffName;
                    labelPatientIDInsert.Text = interactionLog.patientID;
                    labelDateInsert.Text = interactionLog.date;
                    labelShiftInsert.Text = interactionLog.shift;
                    textBoxInteractionNotes.Text = interactionLog.interactionNotes;

                }
            }
        }

        //Clears all the fields ready to show new information
        private void buttonNewSearch_Click(object sender, EventArgs e)
        {
            textBoxLogID.Text = "";
            labelLogInIDInsert.Text = "";
            labelStaffNameInsert.Text = "";
            labelPatientIDInsert.Text = "";
            labelDateInsert.Text = "";
            labelShiftInsert.Text = "";
            textBoxInteractionNotes.Text = "";
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

        /*This functions shows a message box to the user to confirm they would like to go back. If they press yes
        this window is closed and the previous menu is displayed*/
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
