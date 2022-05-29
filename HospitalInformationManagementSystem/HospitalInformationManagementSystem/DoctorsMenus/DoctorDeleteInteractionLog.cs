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
    public partial class DoctorDeleteInteractionLog : Form
    {
        //Calls and assigns the Interaction class ready to use
        InteractionLog interactionLog = new InteractionLog();

        //local variables used within this form
        public List<string> idAvailable = new List<string>();
        public string idToDelete;
        public DoctorDeleteInteractionLog()
        {
            InitializeComponent();
        }


        /*Gets all the current Requests from the Class and displays them in DataGridView for the user to see.
        * While also getting all the current IDs used and stores them in the idAvailable list*/
        private void DoctorDeleteInteractionLog_Load(object sender, EventArgs e)
        {
            interactionLog.LoadCurrentDetails();
            dataGridViewDisplayInteractionLoginfo.DataSource = interactionLog.currentInteractionLogDetails.Tables[0];
            interactionLog.GetAllCurrentlogIDs();
            idAvailable = interactionLog.currentExistingLogIDs;
        }


        /*When the User presses the Delete button the system validates the ID. If it passes the validation the ID
         * is sent to the class to delete. Once successfully deleted the system closes this window and displays the previous one*/
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            String userIDInputted = textBoxLogID.Text.ToString();
            bool isValidUserID = false;
            for (int i = 0; i < idAvailable.Count(); i++)
            {
                if (idAvailable[i] == userIDInputted)
                {
                    isValidUserID = true;
                    break;
                }
            }

            if (textBoxLogID.Text == "")
            {
                MessageBox.Show("Please enter a Log ID to delete!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isValidUserID == false)
            {
                MessageBox.Show("The ID entered does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you would like to delete Log = " + textBoxLogID.Text + "?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    interactionLog.logID = textBoxLogID.Text;
                    interactionLog.DeleteIlnteractionLog();
                    MessageBox.Show("Interaction Log Deleted Successfully", "Interaction Log Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    DoctorInteractionLogMenu doctorInteractionLogMenu = new DoctorInteractionLogMenu();
                    doctorInteractionLogMenu.Show();
                }
            }
        }


        /*The following functions do the same thing. They show a message box to the user to confirm they would like to go back. If they press yes
        this window is closed and the previous menu is displayed*/
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
