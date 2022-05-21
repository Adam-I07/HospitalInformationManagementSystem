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
    public partial class NurseInteractionLogMenu : Form
    {
        InteractionLog interactionLog = new InteractionLog();
        public List<string> idAvailable = new List<string>();
        public NurseInteractionLogMenu()
        {
            InitializeComponent();
        }

        private void NurseInteractionLogMenu_Load(object sender, EventArgs e)
        {
            interactionLog.LoadCurrentDetails();
            dataGridViewDisplayInteractionLoginfo.DataSource = interactionLog.currentInteractionLogDetails.Tables[0];

            foreach (DataGridViewRow item in dataGridViewDisplayInteractionLoginfo.Rows)
            {
                idAvailable.Add(item.Cells[3].Value.ToString());
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String patientIDInputted = textBoxSearchPatient.Text.ToString();
            bool isValidUserID = false;
            for (int i = 0; i < idAvailable.Count(); i++)
            {
                if (idAvailable[i] == patientIDInputted)
                {
                    isValidUserID = true;
                    break;
                }
            }

            if (textBoxSearchPatient.Text == "")
            {
                MessageBox.Show("Please enter a Patient ID to search!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isValidUserID == false)
            {
                MessageBox.Show("The ID entered does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                interactionLog.userSelectedPatientID = textBoxSearchPatient.Text;
                interactionLog.FilterIlnessInformation();
                dataGridViewDisplayInteractionLoginfo.DataSource = interactionLog.currentInteractionLogDetails.Tables[0];
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            interactionLog.LoadCurrentDetails();
            dataGridViewDisplayInteractionLoginfo.DataSource = interactionLog.currentInteractionLogDetails.Tables[0];
        }

        private void buttonViewSpecificInteractionLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseViewSpecificInteractionLog nurseViewSpecificInteractionLog = new NurseViewSpecificInteractionLog();
            nurseViewSpecificInteractionLog.Show();
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                NurseMainMenu nurseMainMenu = new NurseMainMenu();
                nurseMainMenu.Show();
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
                this.Close();
                NurseMainMenu nurseMainMenu = new NurseMainMenu();
                nurseMainMenu.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void buttonAddInteraction_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseAddInteractionLog nurseAddInteractionLog = new NurseAddInteractionLog();
            nurseAddInteractionLog.Show();
        }
    }
}
