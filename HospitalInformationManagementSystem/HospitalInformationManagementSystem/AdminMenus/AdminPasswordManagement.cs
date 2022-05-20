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
        UserLoginDetails userLoginDetails = new UserLoginDetails();

        public AdminPasswordManagement()
        {
            InitializeComponent();
        }

        private void AdminPasswordManagement_Load(object sender, EventArgs e)
        {
            userLoginDetails.LoadCurrentDetails();
            dataGridViewLoginDetails.DataSource = userLoginDetails.currentUserDetails.Tables[0];

        }

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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            userLoginDetails.LoadCurrentDetails();
            dataGridViewLoginDetails.DataSource = userLoginDetails.currentUserDetails.Tables[0];
        }

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

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            AdminAddNewUser adminAddNewUser = new AdminAddNewUser();
            adminAddNewUser.Show();
            this.Close();
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            AdminEditUser adminEditUser = new AdminEditUser();
            adminEditUser.Show();
            this.Close();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            AdminDeleteUser adminDeleteUser = new AdminDeleteUser();
            adminDeleteUser.Show();
            this.Close();
        }
    }
}
