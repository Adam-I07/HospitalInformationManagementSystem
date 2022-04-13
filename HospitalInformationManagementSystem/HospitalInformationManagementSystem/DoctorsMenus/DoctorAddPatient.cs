﻿using System;
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
    public partial class DoctorAddPatient : Form
    {
        public Int64 idNumber;
        public DoctorAddPatient()
        {
            InitializeComponent();
        }

        private void DoctorAddPatient_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select max(PatientID) from PatientPersonalInformation";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            idNumber = Convert.ToInt64(dataSet.Tables[0].Rows[0][0]);
            idNumber = idNumber + 1;
            labelPatientIDCurrent.Text = idNumber.ToString();
            sqlConnection.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
            string nhsNumber = textBoxNHSNumber.Text;
            string dateOfBirth = textBoxDateOfBirth.Text;
            string homeNumber = textBoxPhoneNumber.Text;
            string middleName = textBoxMiddleName.Text;
            if (string.IsNullOrEmpty(textBoxMiddleName.Text))
            {
                middleName = "NULL";
            }

            if (string.IsNullOrEmpty(textBoxHomeNumber.Text))
            {
                homeNumber = "NULL";
            }


            if (textBoxNHSNumber.Text == "" || textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxAge.Text == "" || comboBoxGender.Text == "" || textBoxAge.Text == "" || textBoxDateOfBirth.Text == "" || comboBoxCountry.Text == "" || textBoxEmail.Text == "" || textBoxPhoneNumber.Text == "" || textBoxAddress.Text == "" || comboBoxCity.Text == "" || textBoxPostcode.Text == "" || comboBoxBloodType.Text == "" )
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(nhsNumber.Length != 12 || dateOfBirth.Length != 10)
            { 
                MessageBox.Show("Make sure NHS Number, Date of Birth are filled in correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "insert into PatientPersonalInformation(PatientID,NHSNumber,FirstName,MiddleName,LastName,Age,Gender,DateOfBirth,CountryOfBirth,Email,PhoneNumber,HomeNumber,Address,City,Postcode,BloodType) values ('" + idNumber + "', '" + textBoxNHSNumber.Text + "','" + textBoxFirstName.Text + "','" + middleName + "','" + textBoxLastName.Text + "','" + textBoxAge.Text + "','" + comboBoxGender.Text + "','" + textBoxDateOfBirth.Text + "','" + comboBoxCountry.Text + "','" + textBoxEmail.Text + "','" + textBoxPhoneNumber.Text + "','" + homeNumber + "','" + textBoxAddress.Text + "','" + comboBoxCity.Text + "', '" +textBoxPostcode.Text+ "','" + comboBoxBloodType.Text + "')";


                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    sda.Fill(dataSet);
                    sqlConnection.Close();
                    sqlConnection.Close();
                    MessageBox.Show("The Patient has been added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.None);
                    DoctorsPatientPersonalInfoMenu doctorsPatientPersonalMenu = new DoctorsPatientPersonalInfoMenu();
                    doctorsPatientPersonalMenu.Show();
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
                DoctorsPatientPersonalInfoMenu doctorsPatientPersonalMenu = new DoctorsPatientPersonalInfoMenu();
                doctorsPatientPersonalMenu.Show();
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
                DoctorsPatientPersonalInfoMenu doctorsPatientPersonalMenu = new DoctorsPatientPersonalInfoMenu();
                doctorsPatientPersonalMenu.Show();
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
                DoctorsPatientPersonalInfoMenu doctorsPatientPersonalMenu = new DoctorsPatientPersonalInfoMenu();
                doctorsPatientPersonalMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
