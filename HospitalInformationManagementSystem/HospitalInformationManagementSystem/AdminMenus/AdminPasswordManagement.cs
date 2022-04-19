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
    public partial class AdminPasswordManagement : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        public AdminPasswordManagement()
        {
            InitializeComponent();
        }

        private void AdminPasswordManagement_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from LogInDetails";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            dataGridViewLoginDetails.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(comboBoxRoleFilter.Text == "")
            {
                MessageBox.Show("Select a Role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sqlConnection.Open();
                string query = "select * from LogInDetails where Role = '" + comboBoxRoleFilter.SelectedItem.ToString() + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridViewLoginDetails.DataSource = dataSet.Tables[0];
                sqlConnection.Close();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxRoleFilter.Text = "";
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from LogInDetails";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            dataGridViewLoginDetails.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
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
