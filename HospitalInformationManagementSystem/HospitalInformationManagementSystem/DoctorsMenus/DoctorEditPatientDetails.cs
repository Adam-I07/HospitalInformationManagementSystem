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
    public partial class DoctorEditPatientDetails : Form
    {
        public double maximumIDNumber;
        public DoctorEditPatientDetails()
        {
            InitializeComponent();
        }

        private void DoctorEditPatientDetails_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select max(PatientID) from PatientPersonalInformation";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            maximumIDNumber = Convert.ToInt64(dataSet.Tables[0].Rows[0][0]);
            sqlConnection.Close();
        }

        private void buttonFindID_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Double userIDInputted = Convert.ToDouble(textBoxPatientID.Text);
            if (textBoxPatientID.Text == "")
            {
                MessageBox.Show("Please enter a Patient ID to search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (userIDInputted > maximumIDNumber || userIDInputted <= 0)
            {
                MessageBox.Show("The Patient ID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "select * from PatientPersonalInformation where PatientID = " + textBoxPatientID.Text + "";

                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);
                sqlConnection.Close();

                textBoxNHSNumber.Text = dataSet.Tables[0].Rows[0][1].ToString();
                textBoxFirstName.Text = dataSet.Tables[0].Rows[0][2].ToString();
                textBoxMiddleName.Text = dataSet.Tables[0].Rows[0][3].ToString();
                textBoxLastName.Text = dataSet.Tables[0].Rows[0][4].ToString();
                textBoxAge.Text = dataSet.Tables[0].Rows[0][5].ToString();
                comboBoxGender.Text = dataSet.Tables[0].Rows[0][6].ToString();
                textBoxDateOfBirth.Text = dataSet.Tables[0].Rows[0][7].ToString();
                comboBoxCountry.Text = dataSet.Tables[0].Rows[0][8].ToString();
                textBoxEmail.Text = dataSet.Tables[0].Rows[0][9].ToString();
                textBoxPhoneNumber.Text = dataSet.Tables[0].Rows[0][10].ToString();
                textBoxHomeNumber.Text = dataSet.Tables[0].Rows[0][11].ToString();
                textBoxAddress.Text = dataSet.Tables[0].Rows[0][12].ToString();
                comboBoxCity.Text = dataSet.Tables[0].Rows[0][13].ToString();
                textBoxPostcode.Text = dataSet.Tables[0].Rows[0][14].ToString();
                comboBoxBloodType.Text = dataSet.Tables[0].Rows[0][15].ToString();
            }
        }
    }
}
