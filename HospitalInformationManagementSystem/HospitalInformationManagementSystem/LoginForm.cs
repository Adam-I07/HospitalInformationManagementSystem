using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalInformationManagementSystem.DoctorsMenus;

namespace HospitalInformationManagementSystem
{
    public partial class LoginForm : Form
    {
        //calls the login class
        Login login = new Login();
        public LoginForm()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        /*When the user presses the login button the system validates to make sure the fields are filled in. If the fields are filled
         * the system sends the credentials to the Login class to dealwith. Depending on the response will display an invalid details 
         * message box or load the appropriate menu according to what role the user holds*/
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(comboBoxRole.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool loginCheck = false;
                login.role = comboBoxRole.Text;
                login.username = textBoxUsername.Text;
                login.password = textBoxPassword.Text;
                login.CheckLoginCredentials();
                loginCheck = login.userDetailsCorrect;
                if (loginCheck == true)
                {
                    if (comboBoxRole.Text == "Admin")
                    {
                        AdminMainMenu adminMainMenu = new AdminMainMenu();
                        adminMainMenu.Show();
                        this.Hide();
                    }
                    else if (comboBoxRole.Text == "Doctor")
                    {
                        DoctorsMainMenu doctorsMainMenu = new DoctorsMainMenu();
                        doctorsMainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        NurseMainMenu nurseMainMenu = new NurseMainMenu();
                        nurseMainMenu.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid login details! Try Again!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPassword.Clear();
                }
            }

        }

        //When the user presses the exit button a message box is displayed to make sure the user wants to exit, if they do it will close the application
        private void buttonExitApplication_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }


        //Shows the password field if this box is checked
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPassword.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }


    }
}
