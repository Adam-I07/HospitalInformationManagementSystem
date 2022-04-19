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
    public partial class NurseIllnessMenu : Form
    {
        public List<string> idAvailable = new List<string>();
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");

        public NurseIllnessMenu()
        {
            InitializeComponent();
        }

        private void NurseIllnessMenu_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from IllnessInformation";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            dataGridViewDisplayIllnessInfo.DataSource = dataSet.Tables[0];
            sqlConnection.Close();

            foreach (DataGridViewRow item in dataGridViewDisplayIllnessInfo.Rows)
            {
                idAvailable.Add(item.Cells[1].Value.ToString());
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String patientIDInputted = textBoxSearchPatient.Text.ToString();
            bool isValidUserID = false;
            for (int i = 0; i < idAvailable.Count(); i++)
            {
                if (idAvailable[i] == patientIDInputted)
                {
                    isValidUserID = true;
                    break;
                }
            }

            if (textBoxSearchPatient.Text == "")
            {
                MessageBox.Show("Please enter a Patient ID to search!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isValidUserID == false)
            {
                MessageBox.Show("The ID entered does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;

                command.CommandText = "select * from IllnessInformation where PatientID = " + textBoxSearchPatient.Text + "";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);

                dataGridViewDisplayIllnessInfo.DataSource = dataSet.Tables[0];
                sqlConnection.Close();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from IllnessInformation";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            dataGridViewDisplayIllnessInfo.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }

        private void buttonViewSpecificIllnessInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseViewSpecificIllness nurseViewSpecificIllness = new NurseViewSpecificIllness();
            nurseViewSpecificIllness.Show();
        }

        private void pictureBoxGoBackArrow_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NurseMainMenu nurseMainMenu = new NurseMainMenu();
                nurseMainMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void labeBackText_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NurseMainMenu nurseMainMenu = new NurseMainMenu();
                nurseMainMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}