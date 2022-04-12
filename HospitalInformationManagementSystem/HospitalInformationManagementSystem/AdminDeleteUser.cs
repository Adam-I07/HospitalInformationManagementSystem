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
    public partial class AdminDeleteUser : Form
    {
        public List<string> idAvailable = new List<string>();
        public AdminDeleteUser()
        {
            InitializeComponent();
        }

        private void AdminDeleteUser_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from LogInDetails";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            dataGridViewShowUserDetail.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
            
            foreach(DataGridViewRow item in dataGridViewShowUserDetail.Rows)
            {
                idAvailable.Add(item.Cells[0].Value.ToString());
            }

        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {


            String userIDInputted = textBoxUserID.Text.ToString();
            bool isValidUserID = false;
            for (int i = 0; i < idAvailable.Count(); i++)
            {
                if(idAvailable[i] == userIDInputted)
                {
                    isValidUserID = true;
                    break;
                }
            }


            if (textBoxUserID.Text == "")
            {
                MessageBox.Show("Please enter a User ID to delete!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isValidUserID == false)
            {
                MessageBox.Show("The ID entered does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxUserID.Text == "1")
            {
                MessageBox.Show("You Cannot Delete The Admin!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;

                command.CommandText = "delete from LogInDetails where LogInID = '" + textBoxUserID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);
                sqlConnection.Close();
                this.Close();
                AdminPasswordManagement adminPasswordManagement = new AdminPasswordManagement();
                adminPasswordManagement.Show();
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
