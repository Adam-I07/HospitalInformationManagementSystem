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

namespace HospitalInformationManagementSystem.DoctorsMenus
{
    public partial class DoctorDeleteRequest : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        public List<string> idAvailable = new List<string>();
        public DoctorDeleteRequest()
        {
            InitializeComponent();
        }

        private void DoctorDeleteRequest_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from Requests";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            dataGridViewRequestsView.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
            foreach (DataGridViewRow item in dataGridViewRequestsView.Rows)
            {
                idAvailable.Add(item.Cells[0].Value.ToString());
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            String userIDInputted = textBoxRequestID.Text.ToString();
            bool isValidUserID = false;
            for (int i = 0; i < idAvailable.Count(); i++)
            {
                if (idAvailable[i] == userIDInputted)
                {
                    isValidUserID = true;
                    break;
                }
            }

            if (textBoxRequestID.Text == "")
            {
                MessageBox.Show("Please enter a RequestID to delete!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isValidUserID == false)
            {
                MessageBox.Show("The ID entered does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you would like to delete Request = " + textBoxRequestID.Text + "?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;

                    command.CommandText = "delete from Requests where RequestID '" + textBoxRequestID.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    sda.Fill(dataSet);
                    sqlConnection.Close();
                    this.Close();
                    DoctorRequestMenu doctorRequestMenu = new DoctorRequestMenu();
                    doctorRequestMenu.Show();
                    MessageBox.Show("Request Deleted Successfully", "Interaction Log Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DoctorRequestMenu doctorRequestMenu = new DoctorRequestMenu();
                doctorRequestMenu.Show();
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
                DoctorRequestMenu doctorRequestMenu = new DoctorRequestMenu();
                doctorRequestMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
