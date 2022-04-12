using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalInformationManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string windowToLoad = comboBoxRole.Text;
            if(comboBoxRole.Text == "Select Role" || textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "SELECT * FROM LogInDetails WHERE Role = '" + comboBoxRole.Text + "' AND Username = '" + textBoxUsername.Text + "' AND Password = '" + textBoxPassword.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        sqlConnection.Close();
                        if (windowToLoad == "Admin")
                        {
                            AdminMainMenu adminMainMenu = new AdminMainMenu();
                            adminMainMenu.Show();
                            this.Hide();
                        }
                        else if(windowToLoad == "Doctor")
                        {
                            DoctosMainMenu doctosMainMenu = new DoctosMainMenu();
                            doctosMainMenu.Show();
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
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPassword.Clear();
                    }

                }
                catch
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    sqlConnection.Close();
                }
            }

        }

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
