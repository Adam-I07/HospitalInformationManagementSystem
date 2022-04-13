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
    public partial class AdminMainMenu : Form
    {
        public AdminMainMenu()
        {
            InitializeComponent();
        }


        private void labelLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void pictureBoxLogOutLogo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void pictureBoxLoginDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPasswordManagement adminPasswordManagement = new AdminPasswordManagement();
            adminPasswordManagement.Show();
        }

        private void labelLoginDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPasswordManagement adminPasswordManagement = new AdminPasswordManagement();
            adminPasswordManagement.Show();
        }
    }
}
