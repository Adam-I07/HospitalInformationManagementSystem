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
        UserLoginDetails userLoginDetails = new UserLoginDetails();
        public List<string> idAvailable = new List<string>();
        public AdminDeleteUser()
        {
            InitializeComponent();
        }

        private void AdminDeleteUser_Load(object sender, EventArgs e)
        {

            userLoginDetails.LoadCurrentDetails();
            dataGridViewShowUserDetail.DataSource = userLoginDetails.currentUserDetails.Tables[0];
            userLoginDetails.GetAllCurrentUserIDs();
            idAvailable = userLoginDetails.currentExistingIDs;

        }

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
