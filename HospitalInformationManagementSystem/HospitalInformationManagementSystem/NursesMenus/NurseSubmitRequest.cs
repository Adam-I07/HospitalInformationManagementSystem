using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.NursesMenus
{
    public partial class NurseSubmitRequest : Form
    {
        Requests requests = new Requests();
        public List<string> idAvailable = new List<string>();
        public Int64 idNumber;
        public NurseSubmitRequest()
        {
            InitializeComponent();
        }

        private void NurseSubmitRequest_Load(object sender, EventArgs e)
        {
            requests.GetAllCurrentRequestID();
            idAvailable = requests.currentExistingRequestIDs;
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
            labelRequestIDInput.Text = idNumber.ToString();

            requests.GetAllCurrentLoginIDs();
            comboBoxUserID.DataSource = requests.currentExistingLoginIDs;
            comboBoxUserID.DisplayMember = "LogInID";
            comboBoxUserID.ValueMember = "LogInID";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (comboBoxUserID.Text == "" || textBoxRequest.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                requests.requestID = labelRequestIDInput.Text;
                requests.userID = comboBoxUserID.Text;
                requests.request = textBoxRequest.Text;
                requests.SubmitRequest();
                MessageBox.Show("The Request has been successfully Submitted", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.None);
                NurseRequestMenu nurseRequestMenu = new NurseRequestMenu();
                nurseRequestMenu.Show();
                this.Close();


            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NurseRequestMenu nurseRequestMenu = new NurseRequestMenu();
                nurseRequestMenu.Show();
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
                NurseRequestMenu nurseRequestMenu = new NurseRequestMenu();
                nurseRequestMenu.Show();
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
                NurseRequestMenu nurseRequestMenu = new NurseRequestMenu();
                nurseRequestMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
