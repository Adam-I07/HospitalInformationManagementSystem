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

    public partial class DoctorInteractionLogMenu : Form
    {
        InteractionLog interactionLog = new InteractionLog();
        public List<string> idAvailable = new List<string>(); 
        
        public DoctorInteractionLogMenu()
        {
            InitializeComponent();
        }

        private void DoctorInteractionLogMenu_Load(object sender, EventArgs e)
        {
            interactionLog.LoadCurrentDetails();
            dataGridViewDisplayInteractionLoginfo.DataSource = interactionLog.currentInteractionLogDetails.Tables[0];

            foreach (DataGridViewRow item in dataGridViewDisplayInteractionLoginfo.Rows)
            {
                idAvailable.Add(item.Cells[3].Value.ToString());
            }
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                DoctorsMainMenu doctorsMainMenu = new DoctorsMainMenu();
                doctorsMainMenu.Show();
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
                DoctorsMainMenu doctorsMainMenu = new DoctorsMainMenu();
                doctorsMainMenu.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void buttonAddInteractionLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorAddInteractionLog doctorAddInteractionLog = new DoctorAddInteractionLog();
            doctorAddInteractionLog.Show();
        }

        private void buttonEditInteractionLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorEditInteractionLog doctorEditInteractionLog = new DoctorEditInteractionLog();
            doctorEditInteractionLog.Show();
        }

        private void buttonDeleteInteractionLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDeleteInteractionLog doctorDeleteInteractionLog = new DoctorDeleteInteractionLog();
            doctorDeleteInteractionLog.Show();
        }

        private void buttonViewSpecificInteractionLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorViewSpecificInteractionLog doctorViewSpecificInteractionLog = new DoctorViewSpecificInteractionLog();
            doctorViewSpecificInteractionLog.Show();
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
    }
}
