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
    public partial class DoctorIllnessMenu : Form
    {
        //Calls and assigns the Requests class ready to use
        IllnessInformation illnessInformation = new IllnessInformation();

        //Local variables
        public List<string> idAvailable = new List<string>();

        public DoctorIllnessMenu()
        {
            InitializeComponent();
        }

        //Gets all the current Illness Information from the Class and displays them in DataGridView for the user to see.
        //Also the data in the cell 1 of the DataGridView which is the Patient ID is stored in the idAvailable list.
        private void DoctorIllnessMenu_Load(object sender, EventArgs e)
        {
            illnessInformation.LoadCurrentDetails();
            dataGridViewDisplayIllnessInfo.DataSource = illnessInformation.currentIllnessInformation.Tables[0];

            foreach (DataGridViewRow item in dataGridViewDisplayIllnessInfo.Rows)
            {
                idAvailable.Add(item.Cells[1].Value.ToString());
            }
        }

        //Displays the AddIllnessInformation Form and closes this Form
        private void buttonAddNewIllness_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorAddIllness doctorAddIllness = new DoctorAddIllness();
            doctorAddIllness.Show();
        }

        //Displays the EditIllnessInformation Form and closes this Form
        private void buttonEditIllnessInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorEditIllness doctorEditIllness = new DoctorEditIllness();
            doctorEditIllness.Show();
        }

        /*The following functions do the same thing. They show a message box to the user to confirm they would like to go back. If they press yes
        this window is closed and the previous menu is displayed*/
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

        //Displays the DeleteIllnessInformation Form and closes this Form
        private void buttonDeleteIllnessInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDeleteIllness doctorDeleteIllness = new DoctorDeleteIllness();
            doctorDeleteIllness.Show();
        }

        //Displays the ViewSpecficIllnessInformation Form and closes this Form
        private void buttonSpecificIllnessInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorViewSpecificIllness doctorViewSpecificIllness = new DoctorViewSpecificIllness();
            doctorViewSpecificIllness.Show();
        }


        //Checks the input in the textbox to make sure it is not empty and sends the input to the IllnessInformation class and gets the information back which is displayed in the DataGridView to see
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
                illnessInformation.userSelectedPatientID = patientIDInputted;
                illnessInformation.FilterIlnessInformation();
                dataGridViewDisplayIllnessInfo.DataSource = illnessInformation.currentIllnessInformation.Tables[0];
            }
        }

        //Resets the DataGridView to the original details that are loaded when the menu is first clicked.
        private void buttonReset_Click(object sender, EventArgs e)
        {
            illnessInformation.LoadCurrentDetails();
            dataGridViewDisplayIllnessInfo.DataSource = illnessInformation.currentIllnessInformation.Tables[0];

        }
    }
}
