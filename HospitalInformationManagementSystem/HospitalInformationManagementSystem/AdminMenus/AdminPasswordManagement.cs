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
    public partial class AdminPasswordManagement : Form
    {
        //Calls and assigns the UserLoginDetails class ready to use
        UserLoginDetails userLoginDetails = new UserLoginDetails();

        public AdminPasswordManagement()
        {
            InitializeComponent();
        }

        //Gets all the current Login Details from the UserLoginDetail class as soon as this window is opened and displayed for the user to see in a DataGridView
        private void AdminPasswordManagement_Load(object sender, EventArgs e)
        {
            userLoginDetails.LoadCurrentDetails();
            dataGridViewLoginDetails.DataSource = userLoginDetails.currentUserDetails.Tables[0];

        }


        //Checks the input in the combo box to make sure it is not empty and sends the input to the UserLoginDetail class and gets the information back which is displayed in the DataGridView to see
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(comboBoxRoleFilter.Text == "")
            {
                MessageBox.Show("Select a Role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                userLoginDetails.userAddedFilter = comboBoxRoleFilter.Text;
                userLoginDetails.FilterUserDetails();
                dataGridViewLoginDetails.DataSource = userLoginDetails.currentUserDetails.Tables[0];
            }
        }

        //Resets the DataGridView to the original details that are loaded when the menu is first clicked.
        private void buttonReset_Click(object sender, EventArgs e)
        {
            userLoginDetails.LoadCurrentDetails();
            dataGridViewLoginDetails.DataSource = userLoginDetails.currentUserDetails.Tables[0];
        }

        //Shows a message box to the user to confirm if they want to go back and if they select yes it loads the adminMainMenu and closes this window
        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                AdminMainMenu adminMainMenu = new AdminMainMenu();
                adminMainMenu.Show();
            }
            else
            {
                this.Show();
            }
        }

        //Shows a message box to the user to confirm if they want to go back and if they select yes it loads the adminMainMenu and closes this window
        private void labelGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                AdminMainMenu adminMainMenu = new AdminMainMenu();
                adminMainMenu.Show();
            }
            else
            {
                this.Show();
            }
        }

        //Opens the Admin Add New User window
        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            AdminAddNewUser adminAddNewUser = new AdminAddNewUser();
            adminAddNewUser.Show();
            this.Close();
        }

        //Opens the Admin Edit User window
        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            AdminEditUser adminEditUser = new AdminEditUser();
            adminEditUser.Show();
            this.Close();
        }

        //Opens the Admin Delete User window
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            AdminDeleteUser adminDeleteUser = new AdminDeleteUser();
            adminDeleteUser.Show();
            this.Close();
        }
    }
}
