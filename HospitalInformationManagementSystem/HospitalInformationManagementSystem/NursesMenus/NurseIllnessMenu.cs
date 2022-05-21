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
    public partial class NurseIllnessMenu : Form
    {
        IllnessInformation illnessInformation = new IllnessInformation();
        public List<string> idAvailable = new List<string>();
        public NurseIllnessMenu()
        {
            InitializeComponent();
        }

        private void NurseIllnessMenu_Load(object sender, EventArgs e)
        {
            illnessInformation.LoadCurrentDetails();
            dataGridViewDisplayIllnessInfo.DataSource = illnessInformation.currentIllnessInformation.Tables[0];

            foreach (DataGridViewRow item in dataGridViewDisplayIllnessInfo.Rows)
            {
                idAvailable.Add(item.Cells[1].Value.ToString());
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
                illnessInformation.userSelectedPatientID = patientIDInputted;
                illnessInformation.FilterIlnessInformation();
                dataGridViewDisplayIllnessInfo.DataSource = illnessInformation.currentIllnessInformation.Tables[0];
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            illnessInformation.LoadCurrentDetails();
            dataGridViewDisplayIllnessInfo.DataSource = illnessInformation.currentIllnessInformation.Tables[0];

        }

        private void buttonViewSpecificIllnessInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseViewSpecificIllness nurseViewSpecificIllness = new NurseViewSpecificIllness();
            nurseViewSpecificIllness.Show();
        }

        private void pictureBoxGoBackArrow_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NurseMainMenu nurseMainMenu = new NurseMainMenu();
                nurseMainMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void labeBackText_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NurseMainMenu nurseMainMenu = new NurseMainMenu();
                nurseMainMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
