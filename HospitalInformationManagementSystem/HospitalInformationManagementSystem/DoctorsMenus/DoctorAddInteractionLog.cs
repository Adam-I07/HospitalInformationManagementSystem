using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalInformationManagementSystem.DoctorsMenus
{
    public partial class DoctorAddInteractionLog : Form
    {
        InteractionLog interactionLog = new InteractionLog();
        public Int64 idNumber;
        public List<string> idAvailable = new List<string>();
        public DoctorAddInteractionLog()
        {
            InitializeComponent();
        }

        private void DoctorAddInteractionLog_Load(object sender, EventArgs e)
        {
            interactionLog.GetAllCurrentlogIDs();
            idAvailable = interactionLog.currentExistingLogIDs;
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
            labelLogIDCurrent.Text = idNumber.ToString();

            interactionLog.GetAllCurrentPatientIDs();
            comboBoxPatientID.DataSource = interactionLog.currentExistingPatientIDs;
            comboBoxPatientID.DisplayMember = "PatientID";
            comboBoxPatientID.ValueMember = "PatientID";

            interactionLog.GetAllCurrentLoginIDs();
            comboBoxLoginID.DataSource = interactionLog.currentExistingLoginIDs;
            comboBoxLoginID.DisplayMember = "LogInID";
            comboBoxLoginID.ValueMember = "LogInID";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string date = textBoxDate.Text;
            if (comboBoxLoginID.Text == "" || textBoxStaffName.Text == "" || comboBoxPatientID.Text == "" || textBoxDate.Text == "" || comboBoxShift.Text == "" || textBoxInteractionNotes.Text == "" )
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if( date.Length != 10)
            {
                MessageBox.Show("Make sure the Date is filled in correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                interactionLog.logID = labelLogIDCurrent.Text;
                interactionLog.loginID = comboBoxLoginID.Text;
                interactionLog.staffName = textBoxStaffName.Text;
                interactionLog.patientID = comboBoxPatientID.Text;
                interactionLog.date = textBoxDate.Text;
                interactionLog.shift = comboBoxShift.Text;
                interactionLog.interactionNotes = textBoxInteractionNotes.Text;
                interactionLog.AddInteractionLog();

                MessageBox.Show("The Interaction has been added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.None);
                DoctorInteractionLogMenu doctorInteractionLogMenu = new DoctorInteractionLogMenu();
                doctorInteractionLogMenu.Show();
                this.Close();
            }
        }

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
