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
using HospitalInformationManagementSystem.DoctorsMenus;

namespace HospitalInformationManagementSystem
{
    public partial class DoctorEditInteractionLog : Form
    {
        public double maximumIDNumber;
        public DoctorEditInteractionLog()
        {
            InitializeComponent();
        }

        private void DoctorEditInteractionLog_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select max(LogID) from InteractionLog";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            maximumIDNumber = Convert.ToInt64(dataSet.Tables[0].Rows[0][0]);

            SqlCommand command2 = new SqlCommand();
            command2.Connection = sqlConnection;
            command2.CommandText = "select PatientID from PatientPersonalInformation";

            SqlDataAdapter sqlDataAdapted2 = new SqlDataAdapter();
            sqlDataAdapted2.SelectCommand = command2;
            DataTable dataTable = new DataTable();
            sqlDataAdapted2.Fill(dataTable);

            comboBoxPatientID.DataSource = dataTable;
            comboBoxPatientID.DisplayMember = "PatientID";
            comboBoxPatientID.ValueMember = "PatientID";

            SqlCommand command3 = new SqlCommand();
            command3.Connection = sqlConnection;
            command3.CommandText = "select LogInID from LogInDetails";

            SqlDataAdapter sqlDataAdapted3 = new SqlDataAdapter();
            sqlDataAdapted3.SelectCommand = command3;
            DataTable dataTable2 = new DataTable();
            sqlDataAdapted3.Fill(dataTable2);

            comboBoxLogInID.DataSource = dataTable2;
            comboBoxLogInID.DisplayMember = "LogInID";
            comboBoxLogInID.ValueMember = "LogInID";

            sqlConnection.Close();
        }

        private void buttonFindID_Click(object sender, EventArgs e)
        {
            if (textBoxLogID.Text == "")
            {
                MessageBox.Show("Please enter a Patient ID to search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Double logIDInputted = Convert.ToDouble(textBoxLogID.Text);
                if (logIDInputted > maximumIDNumber || logIDInputted <= 0)
                {
                    MessageBox.Show("The Log ID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "select * from InteractionLog where LogID = " + textBoxLogID.Text + "";

                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    sda.Fill(dataSet);
                    sqlConnection.Close();

                    comboBoxLogInID.Text = dataSet.Tables[0].Rows[0][1].ToString();
                    textBoxStaffName.Text = dataSet.Tables[0].Rows[0][2].ToString();
                    comboBoxPatientID.Text = dataSet.Tables[0].Rows[0][3].ToString();
                    textBoxDate.Text = dataSet.Tables[0].Rows[0][4].ToString();
                    comboBoxShift.Text = dataSet.Tables[0].Rows[0][5].ToString();
                    textBoxInteractionNotes.Text = dataSet.Tables[0].Rows[0][6].ToString();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string date = textBoxDate.Text;
            if (comboBoxLogInID.Text == "" || textBoxStaffName.Text == "" || comboBoxPatientID.Text == "" || textBoxDate.Text == "" || comboBoxShift.Text == "" || textBoxInteractionNotes.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (date.Length != 10)
            {
                MessageBox.Show("Make sure the Date is filled in correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you would like to Edit Log = " + textBoxLogID.Text + "'s Information?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
                    sqlConnection.Open();
                    string query = "UPDATE InteractionLog SET LogInID = '" + comboBoxLogInID.Text + "', StaffName = '" + textBoxStaffName.Text + "', PatientID = '" + comboBoxPatientID.Text + "', Date = '" + textBoxDate.Text + "', Shift = '" + comboBoxShift.Text + "', InteractionNotes = '" + textBoxInteractionNotes.Text + "' where LogID = '" + textBoxLogID.Text + "'";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Interaction Log Information successfully updated. ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.None);
                    textBoxLogID.Text = "";
                    comboBoxLogInID.Text = "";
                    textBoxStaffName.Text = "";
                    comboBoxPatientID.Text = "";
                    textBoxDate.ResetText();
                    comboBoxShift.Text = "";
                    textBoxInteractionNotes.Text = "";
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DoctorInteractionLogMenu doctorInteractionLogMenu = new DoctorInteractionLogMenu();
                doctorInteractionLogMenu.Show();
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
                DoctorInteractionLogMenu doctorInteractionLogMenu = new DoctorInteractionLogMenu();
                doctorInteractionLogMenu.Show();
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
                DoctorInteractionLogMenu doctorInteractionLogMenu = new DoctorInteractionLogMenu();
                doctorInteractionLogMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
