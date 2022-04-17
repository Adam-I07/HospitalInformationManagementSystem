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
    public partial class NurseViewSpecificPatientInfo : Form
    {
        public double maximumIDNumber;
        public NurseViewSpecificPatientInfo()
        {
            InitializeComponent();
        }

        private void NurseViewSpecificPatientInfo_Load(object sender, EventArgs e)
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

                labelNHSNumberInput.Text = dataSet.Tables[0].Rows[0][1].ToString();
                labelFirstNameInput.Text = dataSet.Tables[0].Rows[0][2].ToString();
                labelMiddleNameInput.Text = dataSet.Tables[0].Rows[0][3].ToString();
                labelLastNameInput.Text = dataSet.Tables[0].Rows[0][4].ToString();
                labelAgeInput.Text = dataSet.Tables[0].Rows[0][5].ToString();
                labelGenderInput.Text = dataSet.Tables[0].Rows[0][6].ToString();
                labelDateOfBirthInput.Text = dataSet.Tables[0].Rows[0][7].ToString();
                labelCountryOfBirthInput.Text = dataSet.Tables[0].Rows[0][8].ToString();
                labelEmailInput.Text = dataSet.Tables[0].Rows[0][9].ToString();
                labelPhoneNumberInput.Text = dataSet.Tables[0].Rows[0][10].ToString();
                labelHomeNumberInput.Text = dataSet.Tables[0].Rows[0][11].ToString();
                labelAddressInput.Text = dataSet.Tables[0].Rows[0][12].ToString();
                labelCityInput.Text = dataSet.Tables[0].Rows[0][13].ToString();
                labelPostcodeInput.Text = dataSet.Tables[0].Rows[0][14].ToString();
                labelBloodTypeInput.Text = dataSet.Tables[0].Rows[0][15].ToString();

            }
        }

        private void buttonNewSearch_Click(object sender, EventArgs e)
        {
            textBoxPatientID.Text = "";
            labelNHSNumberInput.Text = "";
            labelFirstNameInput.Text = "";
            labelMiddleNameInput.Text = "";
            labelLastNameInput.Text = "";
            labelAgeInput.Text = "";
            labelGenderInput.Text = "";
            labelDateOfBirthInput.Text = "";
            labelCountryOfBirthInput.Text = "";
            labelEmailInput.Text = "";
            labelPhoneNumberInput.Text = "";
            labelHomeNumberInput.Text = "";
            labelAddressInput.Text = "";
            labelCityInput.Text = "";
            labelPostcodeInput.Text = "";
            labelBloodTypeInput.Text = "";
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NursePatientPersonalInfoForm nursePatientPersonalInfoForm = new NursePatientPersonalInfoForm();
                nursePatientPersonalInfoForm.Show();
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
                NursePatientPersonalInfoForm nursePatientPersonalInfoForm = new NursePatientPersonalInfoForm();
                nursePatientPersonalInfoForm.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

    }
}
