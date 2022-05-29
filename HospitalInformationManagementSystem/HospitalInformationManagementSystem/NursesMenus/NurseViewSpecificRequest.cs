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
    public partial class NurseViewSpecificRequest : Form
    {
        Requests requests = new Requests();
        public List<string> idAvailable = new List<string>();
        public NurseViewSpecificRequest()
        {
            InitializeComponent();
        }

        private void NurseViewSpecificRequest_Load(object sender, EventArgs e)
        {
            requests.GetAllCurrentRequestID();
            idAvailable = requests.currentExistingRequestIDs;
        }

        private void buttonFindID_Click(object sender, EventArgs e)
        {
            bool userExists = false;
            String userIDInputted = Convert.ToString(textBoxRequestID.Text);

            for (int i = 0; i < idAvailable.Count; i++)
            {
                if (userIDInputted == idAvailable[i])
                {
                    userExists = true;
                }
            }

            if (textBoxRequestID.Text == "")
            {
                MessageBox.Show("Please enter a Request ID to search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (userExists == false)
                {
                    MessageBox.Show("The RequestID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    requests.requestID = textBoxRequestID.Text;
                    requests.GetRequest();
                    labelUserIDInput.Text = requests.userID;
                    labelRequestDateInput.Text = requests.requestDate;
                    labelRequestStatusInput.Text = requests.requestStatus;
                    textBoxRequestInput.Text = requests.request;
                    textBoxRequestResponseInput.Text = requests.requestResponse;
                }
            }
        }

        private void buttonNewSearch_Click(object sender, EventArgs e)
        {
            textBoxRequestID.Text = "";
            labelUserIDInput.Text = "";
            labelRequestDateInput.Text = "";
            labelRequestStatusInput.Text = "";
            textBoxRequestInput.Text = "";
            textBoxRequestResponseInput.Text = "";
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NurseViewExistingRequests nurseViewExistingRequests = new NurseViewExistingRequests();
                nurseViewExistingRequests.Show();
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
                NurseViewExistingRequests nurseViewExistingRequests = new NurseViewExistingRequests();
                nurseViewExistingRequests.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
