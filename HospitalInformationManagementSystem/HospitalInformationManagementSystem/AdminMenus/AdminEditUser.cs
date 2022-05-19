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
        User user = new User();
        public List<string> idAvailable = new List<string>();

        public AdminEditUser()
        {
            InitializeComponent();
        }

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
                    user.loginID = textBoxUserID.Text;
                    user.GetUserDetails();
                    comboBoxRole.Text = user.role;
                    textBoxUsername.Text = user.username;
                    textBoxPassword.Text = user.password;
                }
            }
        }

        private void AdminEditUser_Load(object sender, EventArgs e)
        {
            user.GetAllCurrentUserIDs();
            idAvailable = user.currentExistingIDs;
        }
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
                        user.loginID = textBoxUserID.Text;
                        user.role = comboBoxRole.Text;
                        user.username = textBoxUsername.Text;
                        user.password = textBoxPassword.Text;
                        user.EditUser();

                        MessageBox.Show("User details successfully updated. ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.None);
                        textBoxUserID.Text = "";
                        comboBoxRole.ResetText();
                        textBoxUsername.Text = "";
                        textBoxPassword.Text = "";
                    }
                }
            }
        }

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
