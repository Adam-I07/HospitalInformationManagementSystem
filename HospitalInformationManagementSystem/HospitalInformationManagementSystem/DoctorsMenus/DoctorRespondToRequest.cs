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
    public partial class DoctorRespondToRequest : Form
    {
        Requests requests = new Requests();
        public List<string> idAvailable = new List<string>();
        public DoctorRespondToRequest()
        {
            InitializeComponent();
        }

        private void DoctorRespondToRequest_Load(object sender, EventArgs e)
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
                MessageBox.Show("Please enter a RequestID to search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    comboBoxRequestStatus.Text = requests.requestStatus;
                    textBoxRequest.Text = requests.request;
                    textBoxRequestResponse.Text = requests.requestResponse;

                }
            }
        }

        private void buttonRespond_Click(object sender, EventArgs e)
        {
            if (textBoxRequestID.Text == "" || labelUserIDInput.Text == "" || labelRequestDateInput.Text == "" || comboBoxRequestStatus.Text == "" || textBoxRequest.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                requests.requestID = textBoxRequestID.Text;
                requests.userID = labelUserIDInput.Text;
                requests.requestDate = labelRequestDate.Text;
                requests.requestStatus = comboBoxRequestStatus.Text;
                requests.request = textBoxRequest.Text;
                requests.requestResponse = textBoxRequestResponse.Text;
                requests.RespondToRequest();

                MessageBox.Show("Response successfully updated. ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
                DoctorRequestMenu doctorRequestMenu = new DoctorRequestMenu();
                doctorRequestMenu.Show();

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DoctorRequestMenu doctorRequestMenu = new DoctorRequestMenu();
                doctorRequestMenu.Show();
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
                DoctorRequestMenu doctorRequestMenu = new DoctorRequestMenu();
                doctorRequestMenu.Show();
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
                DoctorRequestMenu doctorRequestMenu = new DoctorRequestMenu();
                doctorRequestMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
