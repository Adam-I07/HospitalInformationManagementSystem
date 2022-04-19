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
    public partial class NurseSubmitRequest : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        public double maximumIDNumber;
        public NurseSubmitRequest()
        {
            InitializeComponent();
        }

        private void NurseSubmitRequest_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select max(RequestID) from Requests";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            maximumIDNumber = Convert.ToInt64(dataSet.Tables[0].Rows[0][0]);
            maximumIDNumber = maximumIDNumber + 1;
            labelRequestIDInput.Text = maximumIDNumber.ToString();

            SqlCommand command2 = new SqlCommand();
            command2.Connection = sqlConnection;
            command2.CommandText = "select LogInID from LogInDetails";

            SqlDataAdapter sqlDataAdapted2 = new SqlDataAdapter();
            sqlDataAdapted2.SelectCommand = command2;
            DataTable dataTable = new DataTable();
            sqlDataAdapted2.Fill(dataTable);

            comboBoxUserID.DataSource = dataTable;
            comboBoxUserID.DisplayMember = "LogInID";
            comboBoxUserID.ValueMember = "LogInID";

            sqlConnection.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(comboBoxUserID.Text == "" || textBoxRequest.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string date = DateTime.UtcNow.ToString("dd-MM-yyyy");
                string requestStatus = "Pending";
                string requestResponse = "Pending";
                try
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "insert into Requests(RequestID,UserID,RequestDate,RequestStatus,Request,RequestResponse) values ('" + maximumIDNumber + "', '" + comboBoxUserID.Text + "','" + date + "','" + requestStatus + "','" + textBoxRequest.Text + "','" + requestResponse + "')";


                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    sda.Fill(dataSet);
                    sqlConnection.Close();

                    MessageBox.Show("The Request has been successfully Submitted", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.None);
                    NurseRequestMenu nurseRequestMenu = new NurseRequestMenu();
                    nurseRequestMenu.Show();
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NurseRequestMenu nurseRequestMenu = new NurseRequestMenu();
                nurseRequestMenu.Show();
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
                NurseRequestMenu nurseRequestMenu = new NurseRequestMenu();
                nurseRequestMenu.Show();
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
                NurseRequestMenu nurseRequestMenu = new NurseRequestMenu();
                nurseRequestMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
