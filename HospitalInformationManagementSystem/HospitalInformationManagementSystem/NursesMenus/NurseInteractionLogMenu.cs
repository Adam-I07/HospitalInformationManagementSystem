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

namespace HospitalInformationManagementSystem.DoctorsMenus
{
    public partial class NurseInteractionLogMenu : Form
    {
        public List<string> idAvailable = new List<string>();
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");

        public NurseInteractionLogMenu()
        {
            InitializeComponent();
        }

        private void NurseInteractionLogMenu_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from InteractionLog";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            dataGridViewDisplayInteractionLoginfo.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
            foreach (DataGridViewRow item in dataGridViewDisplayInteractionLoginfo.Rows)
            {
                idAvailable.Add(item.Cells[3].Value.ToString());
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

                command.CommandText = "select * from InteractionLog where PatientID = " + textBoxSearchPatient.Text + "";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);

                dataGridViewDisplayInteractionLoginfo.DataSource = dataSet.Tables[0];
                sqlConnection.Close();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from InteractionLog";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            dataGridViewDisplayInteractionLoginfo.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }

        private void buttonViewSpecificInteractionLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseViewSpecificInteractionLog nurseViewSpecificInteractionLog = new NurseViewSpecificInteractionLog();
            nurseViewSpecificInteractionLog.Show();
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                NurseMainMenu nurseMainMenu = new NurseMainMenu();
                nurseMainMenu.Show();
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
                this.Close();
                NurseMainMenu nurseMainMenu = new NurseMainMenu();
                nurseMainMenu.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void buttonAddInteraction_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseAddInteractionLog nurseAddInteractionLog = new NurseAddInteractionLog();
            nurseAddInteractionLog.Show();
        }
    }
}