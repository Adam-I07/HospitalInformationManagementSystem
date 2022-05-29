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
        //Calls and assigns the Requests class ready to use
        Requests requests = new Requests();

        //local variables used within this form
        public List<string> idAvailable = new List<string>();
        public Int64 idNumber;
        public NurseSubmitRequest()
        {
            InitializeComponent();
        }


        /*When the window is first loaded the system gets all the current ID's in the database and assigns them to the id available list, which then assigns the next available ID the user can use
        Also gets all the LogIn ID used and enters them into the combo box for User ID*/
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


        /*When the User clicks the Submit button the system validates all the fields to make sure they are corrent.
        * If the fields are correct they are sent to the class to add to the database. If this is all done successfully
        * the user is returned back to the menu before*/
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


        /*The following functions do the same thing. They show a message box to the user to confirm they would like to go back. If they press yes
          this window is closed and the previous menu is displayed*/
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
