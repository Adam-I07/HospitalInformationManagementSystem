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
    public partial class AdminDeleteUser : Form
    {
        //Calls and assigns the UserLoginDetails class ready to use
        UserLoginDetails userLoginDetails = new UserLoginDetails();

        //local variables used within this form
        public List<string> idAvailable = new List<string>();
        public AdminDeleteUser()
        {
            InitializeComponent();
        }

        /*Gets all the current Requests from the Class and displays them in DataGridView for the user to see.
        * While also getting all the current IDs used and stores them in the idAvailable list*/
        private void AdminDeleteUser_Load(object sender, EventArgs e)
        {

            userLoginDetails.LoadCurrentDetails();
            dataGridViewShowUserDetail.DataSource = userLoginDetails.currentUserDetails.Tables[0];
            userLoginDetails.GetAllCurrentUserIDs();
            idAvailable = userLoginDetails.currentExistingIDs;

        }


        /*When the User presses the Delete button the system validates the ID. If it passes the validation the ID
         * is sent to the class to delete. Once successfully deleted the system closes this window and displays the previous one*/
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            String userIDInputted = textBoxUserID.Text.ToString();
            bool isValidUserID = false;
            for (int i = 0; i < idAvailable.Count(); i++)
            {
                if (idAvailable[i] == userIDInputted)
                {
                    isValidUserID = true;
                    break;
                }
            }

            if (textBoxUserID.Text == "")
            {
                MessageBox.Show("Please enter a User ID to delete!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxUserID.Text == "1" || textBoxUserID.Text == " 1" || textBoxUserID.Text == "  1" || textBoxUserID.Text == "   1" || textBoxUserID.Text == "    1" || textBoxUserID.Text == "     1")
            {
                MessageBox.Show("You Cannot Delete The Admin!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (isValidUserID == false)
            {
                MessageBox.Show("The ID entered does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you would like to delete UserID = " + textBoxUserID.Text + "?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    userLoginDetails.loginID = textBoxUserID.Text;
                    userLoginDetails.DeleteExistingUser();
                    this.Close();
                    AdminPasswordManagement adminPasswordManagement = new AdminPasswordManagement();
                    adminPasswordManagement.Show();
                    MessageBox.Show("User Deleted Successfully", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }


        /*The following functions do the same thing. They show a message box to the user to confirm they would like to go back. If they press yes
        this window is closed and the previous menu is displayed*/
        private void labelGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                AdminPasswordManagement adminPasswordManagement = new AdminPasswordManagement();
                adminPasswordManagement.Show();
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
                AdminPasswordManagement adminPasswordManagement = new AdminPasswordManagement();
                adminPasswordManagement.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
