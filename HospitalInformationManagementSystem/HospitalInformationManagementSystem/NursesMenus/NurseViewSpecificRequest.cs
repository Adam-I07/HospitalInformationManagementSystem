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

namespace HospitalInformationManagementSystem.NursesMenus
{
    public partial class NurseViewSpecificRequest : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        public double maximumIDNumber;
        public NurseViewSpecificRequest()
        {
            InitializeComponent();
        }

        private void NurseViewSpecificRequest_Load(object sender, EventArgs e)
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
                    labelRequestStatusInput.Text = dataSet.Tables[0].Rows[0][3].ToString();
                    textBoxRequestInput.Text = dataSet.Tables[0].Rows[0][4].ToString();
                    textBoxRequestResponseInput.Text = dataSet.Tables[0].Rows[0][5].ToString();
                }
            }
        }

        private void buttonNewSearch_Click(object sender, EventArgs e)
        {
            textBoxRequestID.Text = "";
            labelUserIDInput.Text = "";
            labelRequestDateInput.Text = "";
            labelRequestStatusInput.Text = "";
            textBoxRequestInput.Text = "";
            textBoxRequestResponseInput.Text = "";
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NurseViewExistingRequests nurseViewExistingRequests = new NurseViewExistingRequests();
                nurseViewExistingRequests.Show();
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
                NurseViewExistingRequests nurseViewExistingRequests = new NurseViewExistingRequests();
                nurseViewExistingRequests.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
