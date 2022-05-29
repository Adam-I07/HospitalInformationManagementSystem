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
        //Calls and assigns the InteractionLog class ready to use
        Requests requests = new Requests();

        //local variables used within this form
        public List<string> idAvailable = new List<string>();
        public NurseViewSpecificRequest()
        {
            InitializeComponent();
        }


        //Gets all the current ID from the class and stores them in idAvailable list to use
        private void NurseViewSpecificRequest_Load(object sender, EventArgs e)
        {
            requests.GetAllCurrentRequestID();
            idAvailable = requests.currentExistingRequestIDs;
        }


        /*Once the user presses Find the ID inputted is validates and sent to the class if successful. The class
        *gets all the data assosciated with that ID and sends it back which is then displayed for the user to see*/
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

        //Clears all the fields ready to show new information
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

        /*This functions shows a message box to the user to confirm they would like to go back. If they press yes
          this window is closed and the previous menu is displayed*/
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
