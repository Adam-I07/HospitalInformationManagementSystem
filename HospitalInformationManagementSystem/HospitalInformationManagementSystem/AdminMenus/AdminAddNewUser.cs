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
    public partial class AdminAddNewUser : Form
    {
        UserLoginDetails userLoginDetails = new UserLoginDetails();
        public List<string> idAvailable = new List<string>();
        public Int64 idNumber;
        public AdminAddNewUser()
        {
            InitializeComponent();
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxRole.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string passCheck = textBoxPassword.Text;
                bool containsDigit = false;
                bool containsUppercaseLetter = false;
                bool containsLowercaseLetter = false;
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

                if (containsDigit == true && containsUppercaseLetter == true && containsLowercaseLetter == true)
                {
                    userLoginDetails.loginID = labelUserIDCurrent.Text;
                    userLoginDetails.role = comboBoxRole.Text;
                    userLoginDetails.username = textBoxUsername.Text;
                    userLoginDetails.password = textBoxPassword.Text;
                    userLoginDetails.AddUser();
                    MessageBox.Show("The User has been added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.None);
                    AdminPasswordManagement adminPasswordManagement = new AdminPasswordManagement();
                    adminPasswordManagement.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Your password must contain atleast one uppercase letter, one lowercase letter and a digit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AdminAddNewUser_Load(object sender, EventArgs e)
        {
            userLoginDetails.GetAllCurrentUserIDs();
            idAvailable = userLoginDetails.currentExistingIDs;
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
            labelUserIDCurrent.Text = idNumber.ToString();
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
    }
}
