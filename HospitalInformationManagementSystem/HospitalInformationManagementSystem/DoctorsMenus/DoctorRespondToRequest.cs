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
    public partial class DoctorRespondToRequest : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        public double maximumIDNumber;
        public DoctorRespondToRequest()
        {
            InitializeComponent();
        }

        private void DoctorRespondToRequest_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select max(RequestID) from Requests";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            maximumIDNumber = Convert.ToInt64(dataSet.Tables[0].Rows[0][0]);


            sqlConnection.Close();
        }

        private void buttonFindID_Click(object sender, EventArgs e)
        {
            if (textBoxRequestID.Text == "")
            {
                MessageBox.Show("Please enter a RequestID to search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Double requestIDInputted = Convert.ToDouble(textBoxRequestID.Text);
                if (requestIDInputted > maximumIDNumber || requestIDInputted <= 0)
                {
                    MessageBox.Show("The RequestID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "select * from Requests where RequestID = " + textBoxRequestID.Text + "";

                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    sda.Fill(dataSet);
                    sqlConnection.Close();

                    labelUserIDInput.Text = dataSet.Tables[0].Rows[0][1].ToString();
                    labelRequestDateInput.Text = dataSet.Tables[0].Rows[0][2].ToString();
                    comboBoxRequestStatus.Text = dataSet.Tables[0].Rows[0][3].ToString();
                    textBoxRequest.Text = dataSet.Tables[0].Rows[0][4].ToString();
                    textBoxRequestResponse.Text = dataSet.Tables[0].Rows[0][5].ToString();
                }
            }
        }

        private void buttonRespond_Click(object sender, EventArgs e)
        {
            if (textBoxRequestID.Text == "" || labelUserIDInput.Text == "" || labelRequestDateInput.Text == "" || comboBoxRequestStatus.Text == "" || textBoxRequest.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sqlConnection.Open();
                string query = "UPDATE Requests SET UserID = '" + labelUserIDInput.Text + "', RequestDate = '" + labelRequestDateInput.Text + "', RequestStatus = '" + comboBoxRequestStatus.Text + "', Request = '" + textBoxRequest.Text + "', RequestResponse = '" + textBoxRequestResponse.Text + "' where RequestID = '" + textBoxRequestID.Text + "'";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Response successfully updated. ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.None);
                textBoxRequestID.Text = "";
                labelUserIDInput.Text = "";
                labelRequestDateInput.Text = "";
                comboBoxRequestStatus.Text = "";
                textBoxRequest.Text = "";
                textBoxRequestResponse.Text = "";
               
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
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
