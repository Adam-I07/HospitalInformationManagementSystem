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
    public partial class AdminEditUser : Form
    {
        public double maximumIDNumber;
        public AdminEditUser()
        {
            InitializeComponent();
        }

        private void buttonFindID_Click(object sender, EventArgs e)
        {
            
            if (textBoxUserID.Text == "")
            {
                MessageBox.Show("Please enter a User ID to search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Double userIDInputted = Convert.ToDouble(textBoxUserID.Text);
                if (textBoxUserID.Text == "1" || textBoxUserID.Text == " 1" || textBoxUserID.Text == "  1" || textBoxUserID.Text == "   1" || textBoxUserID.Text == "    1" || textBoxUserID.Text == "     1")
                {
                    MessageBox.Show("You Cannot Edit The Admin!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (userIDInputted > maximumIDNumber || userIDInputted <= 0)
                {
                    MessageBox.Show("The User ID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "select * from LogInDetails where LogInID = " + textBoxUserID.Text + "";

                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    sda.Fill(dataSet);
                    sqlConnection.Close();

                    comboBoxRole.Text = dataSet.Tables[0].Rows[0][1].ToString();
                    textBoxUsername.Text = dataSet.Tables[0].Rows[0][2].ToString();
                    textBoxPassword.Text = dataSet.Tables[0].Rows[0][3].ToString();
                }
            }
        }

        private void AdminEditUser_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select max(LogInID) from LogInDetails";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            Int64 idNumber = Convert.ToInt64(dataSet.Tables[0].Rows[0][0]);
            maximumIDNumber = idNumber;
            sqlConnection.Close();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {


            if (textBoxUserID.Text == "" || comboBoxRole.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Make sure that all fields are filled in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxUserID.Text == "1")
            {
                MessageBox.Show("You Cannot Edit The Admin!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Double userIDInputted = Convert.ToDouble(textBoxUserID.Text);
                if (userIDInputted > maximumIDNumber || userIDInputted <= 0)
                {
                    MessageBox.Show("The User ID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you would like to Edit UserID = " + textBoxUserID.Text + "?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
                        sqlConnection.Open();
                        string query = "UPDATE LogInDetails SET Role = '" + comboBoxRole.Text + "', Username = '" + textBoxUsername.Text + "', Password = '" + textBoxPassword.Text + "' where LogInID = '" + textBoxUserID.Text + "'";
                        SqlCommand command = new SqlCommand(query, sqlConnection);
                        command.ExecuteNonQuery();
                        sqlConnection.Close();
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
