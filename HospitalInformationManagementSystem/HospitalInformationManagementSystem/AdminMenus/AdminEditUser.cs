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
    public partial class AdminEditUser : Form
    {
        //Calls and assigns the UserLoginDetails class ready to use
        UserLoginDetails userLoginDetails = new UserLoginDetails();

        //local variables used within this form
        public List<string> idAvailable = new List<string>();

        public AdminEditUser()
        {
            InitializeComponent();
        }


        /*Once the user presses Find the ID inputted is validates and sent to the class if successful. The class
         * gets all the data assosciated with that ID and sends it back which is then displayed for the user to see
         * and edit*/
        private void buttonFindID_Click(object sender, EventArgs e)
        {
            bool userExists = false;
            String userIDInputted = Convert.ToString(textBoxUserID.Text);

            for (int i = 0; i < idAvailable.Count; i++)
            {
                if (userIDInputted == idAvailable[i])
                {
                    userExists = true;
                }
            }

            if (textBoxUserID.Text == "")
            {
                MessageBox.Show("Please enter a User ID to search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBoxUserID.Text == "1" || textBoxUserID.Text == " 1" || textBoxUserID.Text == "  1" || textBoxUserID.Text == "   1" || textBoxUserID.Text == "    1" || textBoxUserID.Text == "     1")
                {
                    MessageBox.Show("You Cannot Edit The Admin!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (userExists == false)
                {
                    MessageBox.Show("The User ID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    userLoginDetails.loginID = textBoxUserID.Text;
                    userLoginDetails.GetUserDetails();
                    comboBoxRole.Text = userLoginDetails.role;
                    textBoxUsername.Text = userLoginDetails.username;
                    textBoxPassword.Text = userLoginDetails.password;
                }
            }
        }

        //Gets all the current ID from the class and stores them in idAvailable list to use
        private void AdminEditUser_Load(object sender, EventArgs e)
        {
            userLoginDetails.GetAllCurrentUserIDs();
            idAvailable = userLoginDetails.currentExistingIDs;
        }


        /*Once the user has edited the information they wish and clicked the update button. The system validates the inputted fields
         * and if successful sends them to the class to update. After doing that this window displays a messagebox letting the user know 
         the information was updated successfully and clears all the fields ready for to edit again.*/
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxUserID.Text == "" || comboBoxRole.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Make sure that all fields are filled in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool userExists = false;
                String userIDInputted = Convert.ToString(textBoxUserID.Text);
                string passCheck = textBoxPassword.Text;
                bool containsDigit = false;
                bool containsUppercaseLetter = false;
                bool containsLowercaseLetter = false;
                for (int i = 0; i < idAvailable.Count; i++)
                {
                    if (userIDInputted == idAvailable[i])
                    {
                        userExists = true;
                    }
                }
                for (int i = 0; i < passCheck.Length; i++)
                {
                    if (char.IsUpper(passCheck[i]))
                    {
                        containsUppercaseLetter = true;
                    }

                    if (char.IsDigit(passCheck[i]))
                    {
                        containsDigit = true;
                    }

                    if (char.IsLower(passCheck[i]))
                    {
                        containsLowercaseLetter = true;
                    }
                }

                if (textBoxUserID.Text == "1")
                {
                    MessageBox.Show("You Cannot Edit The Admin!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (userExists == false)
                {
                    MessageBox.Show("The User ID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (containsDigit != true || containsLowercaseLetter != true || containsUppercaseLetter != true)
                {
                    MessageBox.Show("Your password must contain atleast one uppercase letter, one lowercase letter and a digit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you would like to Edit UserID = " + textBoxUserID.Text + "?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        userLoginDetails.loginID = textBoxUserID.Text;
                        userLoginDetails.role = comboBoxRole.Text;
                        userLoginDetails.username = textBoxUsername.Text;
                        userLoginDetails.password = textBoxPassword.Text;
                        userLoginDetails.EditUser();

                        MessageBox.Show("User details successfully updated. ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.None);
                        textBoxUserID.Text = "";
                        comboBoxRole.ResetText();
                        textBoxUsername.Text = "";
                        textBoxPassword.Text = "";
                    }
                }
            }
        }

        /*This functions shows a message box to the user to confirm they would like to go back. If they press yes
        this window is closed and the previous menu is displayed*/
        private void buttonCancel_Click(object sender, EventArgs e)
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
