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
            
            if (textBoxPatientID.Text == "")
            {
                MessageBox.Show("Please enter a Patient ID to search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Double userIDInputted = Convert.ToDouble(textBoxPatientID.Text);
                if (userIDInputted > maximumIDNumber || userIDInputted <= 0)
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string nhsNumber = textBoxNHSNumber.Text;
            string dateOfBirth = textBoxDateOfBirth.Text;

            if (textBoxNHSNumber.Text == "" || textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxAge.Text == "" || comboBoxGender.Text == "" || textBoxAge.Text == "" || textBoxDateOfBirth.Text == "" || comboBoxCountry.Text == "" || textBoxEmail.Text == "" || textBoxPhoneNumber.Text == "" || textBoxAddress.Text == "" || comboBoxCity.Text == "" || textBoxPostcode.Text == "" || comboBoxBloodType.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nhsNumber.Length != 12 || dateOfBirth.Length != 10)
            {
                MessageBox.Show("Make sure NHS Number, Date of Birth are filled in correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Double userIDInputted = Convert.ToDouble(textBoxPatientID.Text);
                if (userIDInputted > maximumIDNumber || userIDInputted <= 0)
                {
                    MessageBox.Show("The Patient ID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you would like to Edit PatientID = " + textBoxPatientID.Text + "?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
                        sqlConnection.Open();
                        string query = "UPDATE PatientPersonalInformation SET NHSNumber = '" + textBoxNHSNumber.Text + "', FirstName = '" + textBoxFirstName.Text + "', MiddleName = '" + textBoxMiddleName.Text + "', LastName = '" + textBoxLastName.Text + "', Age = '" + textBoxAge.Text + "', Gender = '" + comboBoxGender.Text + "', DateOfBirth = '" + textBoxDateOfBirth.Text + "', CountryOfBirth = '" + comboBoxCountry.Text + "', Email = '" + textBoxEmail.Text + "', PhoneNumber = '" + textBoxPhoneNumber.Text + "', HomeNumber = '" + textBoxHomeNumber.Text + "', Address = '" + textBoxAddress.Text + "', City = '" + comboBoxCity.Text + "', Postcode = '" + textBoxPostcode.Text + "', BloodType = '" + comboBoxBloodType.Text + "' where PatientID = '" + textBoxPatientID.Text + "'";
                        SqlCommand command = new SqlCommand(query, sqlConnection);
                        command.ExecuteNonQuery();
                        sqlConnection.Close();
                        MessageBox.Show("Patient details successfully updated. ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.None);
                        textBoxPatientID.Text = "";
                        textBoxNHSNumber.Text = "";
                        textBoxFirstName.Text = "";
                        textBoxMiddleName.Text = "";
                        textBoxLastName.Text = "";
                        textBoxAge.Text = "";
                        comboBoxGender.ResetText();
                        textBoxDateOfBirth.Text = "";
                        comboBoxCountry.ResetText();
                        textBoxEmail.Text = "";
                        textBoxPhoneNumber.Text = "";
                        textBoxHomeNumber.Text = "";
                        textBoxAddress.Text = "";
                        comboBoxCity.ResetText();
                        textBoxPostcode.Text = "";
                        comboBoxBloodType.ResetText();
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
                DoctorsPatientPersonalInfoMenu doctorsPatientPersonalInfoMenu = new DoctorsPatientPersonalInfoMenu();
                doctorsPatientPersonalInfoMenu.Show();
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
                DoctorsPatientPersonalInfoMenu doctorsPatientPersonalInfoMenu = new DoctorsPatientPersonalInfoMenu();
                doctorsPatientPersonalInfoMenu.Show();
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
                DoctorsPatientPersonalInfoMenu doctorsPatientPersonalInfoMenu = new DoctorsPatientPersonalInfoMenu();
                doctorsPatientPersonalInfoMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
