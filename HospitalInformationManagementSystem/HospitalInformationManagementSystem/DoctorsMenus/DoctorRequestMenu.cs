using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HospitalInformationManagementSystem.DoctorsMenus
{
    public partial class DoctorRequestMenu : Form
    {
        //Calls and assigns the Requests class ready to use
        Requests requests = new Requests();
        public DoctorRequestMenu()
        {
            InitializeComponent();
        }

        //Gets all the current Requests from the Class and displays them in DataGridView for the user to see.
        private void DoctorRequestMenu_Load(object sender, EventArgs e)
        {
            requests.LoadCurrentRequests();
            dataGridViewRequestsView.DataSource = requests.currentRequests.Tables[0];
        }

        //Opens the RespondToRequest window and closes this one
        private void buttonRespondToRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorRespondToRequest doctorRespondToRequest = new DoctorRespondToRequest();
            doctorRespondToRequest.Show();
        }

        //Opens the ViewRequest window and closes this one
        private void buttonViewRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorViewSpecificRequest doctorViewSpecificRequest = new DoctorViewSpecificRequest();
            doctorViewSpecificRequest.Show();
        }

        //Opens the DeleteRequest window and closes this one
        private void buttonDeleteRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDeleteRequest doctorDeleteRequest = new DoctorDeleteRequest();
            doctorDeleteRequest.Show();
        }

        /*The following functions do the same thing. They show a message box to the user to confirm they would like to go back. If they press yes
        this window is closed and the previous menu is displayed*/
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


        //Checks the input in the textbox to make sure it is not empty and sends the input to the Requests class and gets the information back which is displayed in the DataGridView to see
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxRequestStatus.Text == "")
            {
                MessageBox.Show("Select a Request Status!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                requests.userSelectedFilter = comboBoxRequestStatus.Text;
                requests.FilterIlnessInformation();
                dataGridViewRequestsView.DataSource = requests.currentRequests.Tables[0];
            }
        }
        //Resets the DataGridView to the original details that are loaded when the menu is first clicked.
        private void buttonReset_Click(object sender, EventArgs e)
        {
            requests.LoadCurrentRequests();
            dataGridViewRequestsView.DataSource = requests.currentRequests.Tables[0];
        }
    }
}
