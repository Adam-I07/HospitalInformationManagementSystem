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
    public partial class DoctorDeleteIllness : Form
    {
        IllnessInformation illnessInformation = new IllnessInformation();
        public List<string> idAvailable = new List<string>();
        public string idToDelete;
        public DoctorDeleteIllness()
        {
            InitializeComponent();
        }

        private void DoctorDeleteIllness_Load(object sender, EventArgs e)
        {
            illnessInformation.LoadCurrentDetails();
            dataGridViewDisplayIllnessInfo.DataSource = illnessInformation.currentIllnessInformation.Tables[0];
            illnessInformation.GetAllCurrentTreatmentIDs();
            idAvailable = illnessInformation.currentExistingTreatmentIDs;
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            String userIDInputted = textBoxTreatmentID.Text.ToString();
            bool isValidUserID = false;
            idToDelete = textBoxTreatmentID.Text;
            for (int i = 0; i < idAvailable.Count(); i++)
            {
                if (idAvailable[i] == userIDInputted)
                {
                    isValidUserID = true;
                    break;
                }
            }

            if (textBoxTreatmentID.Text == "")
            {
                MessageBox.Show("Please enter a Treatment ID to delete!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isValidUserID == false)
            {
                MessageBox.Show("The ID entered does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you would like to delete Treatment = " + textBoxTreatmentID.Text + "?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    illnessInformation.treatmentID = textBoxTreatmentID.Text;
                    illnessInformation.DeleteIllnessInformation();
                    this.Close();
                    DoctorIllnessMenu doctorIllnessMenu = new DoctorIllnessMenu();
                    doctorIllnessMenu.Show();

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
    }
}
