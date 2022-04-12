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

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
            if (comboBoxRole.Text == "Select Role" || textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "insert into LogInDetails (Role,Username,Password) values ('" + comboBoxRole.Text + "','" + textBoxUsername.Text + "','" + textBoxPassword.Text + "')";

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
        }

        private void AdminAddNewUser_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select max(LogInID) from LogInDetails";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            Int64 idNumber = Convert.ToInt64(dataSet.Tables[0].Rows[0][0]);
            labelUserIDCurrent.Text = (idNumber+1).ToString();
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
