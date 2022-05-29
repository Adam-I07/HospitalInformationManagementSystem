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
    public partial class NurseViewExistingRequests : Form
    {
        //Calls and assigns the Requests class ready to use
        Requests requests = new Requests();

        public NurseViewExistingRequests()
        {
            InitializeComponent();
        }

        //Gets all the current Requests from the Class and displays them in DataGridView for the user to see.
        private void NurseViewExistingRequests_Load(object sender, EventArgs e)
        {
            requests.LoadCurrentRequests();
            dataGridViewRequestsView.DataSource = requests.currentRequests.Tables[0];
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

        //Displays the ViewSpecificRequest Window
        private void buttonViewSpecificRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseViewSpecificRequest nurseViewSpecificRequest = new NurseViewSpecificRequest();
            nurseViewSpecificRequest.Show();
        }

        /*The following functions do the same thing. They show a message box to the user to confirm they would like to go back. If they press yes
        this window is closed and the previous menu is displayed*/
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
    }
}
