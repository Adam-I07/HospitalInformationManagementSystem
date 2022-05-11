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
    public partial class AdminAddNewUser : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
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

                    if(char.IsLower(passCheck[i]))
                    {
                        containsLowercaseLetter = true;
                    }
                }

                if (containsDigit == true && containsUppercaseLetter == true && containsLowercaseLetter == true)
                {
                    try
                    {
                        SqlCommand command = new SqlCommand();
                        command.Connection = sqlConnection;
                        command.CommandText = "insert into LogInDetails (LogInID,Role,Username,Password) values ('" + idNumber + "', '" + comboBoxRole.Text + "','" + textBoxUsername.Text + "','" + textBoxPassword.Text + "')";

                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        sda.Fill(dataSet);
                        sqlConnection.Close();
                        MessageBox.Show("The User has been added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.None);
                        AdminPasswordManagement adminPasswordManagement = new AdminPasswordManagement();
                        adminPasswordManagement.Show();
                        this.Close();
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
                else
                {
                    MessageBox.Show("Your password must contain atleast one uppercase letter, one lowercase letter and a digit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AdminAddNewUser_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select max(LogInID) from LogInDetails";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            idNumber = Convert.ToInt64(dataSet.Tables[0].Rows[0][0]);
            idNumber = idNumber + 1;
            labelUserIDCurrent.Text = idNumber.ToString();
            sqlConnection.Close();
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
