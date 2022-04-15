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
    public partial class DoctorEditIllness : Form
    {
        public double maximumIDNumber;
        public DoctorEditIllness()
        {
            InitializeComponent();
        }

        private void DoctorEditIllness_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select max(TreatmentID) from IllnessInformation";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            maximumIDNumber = Convert.ToInt64(dataSet.Tables[0].Rows[0][0]);
            sqlConnection.Close();
        }

        private void buttonFindID_Click(object sender, EventArgs e)
        {

            if (textBoxTreatmentID.Text == "")
            {
                MessageBox.Show("Please enter a Patient ID to search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Double userIDInputted = Convert.ToDouble(textBoxTreatmentID.Text);
                if (userIDInputted > maximumIDNumber || userIDInputted <= 0)
                {
                    MessageBox.Show("The Patient ID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "select * from IllnessInformation where TreatmentID = " + textBoxTreatmentID.Text + "";

                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    sda.Fill(dataSet);
                    sqlConnection.Close();

                    labelPatientIDInsert.Text = dataSet.Tables[0].Rows[0][1].ToString();
                    textBoxIllness.Text = dataSet.Tables[0].Rows[0][2].ToString();
                    textBoxIllnessType.Text = dataSet.Tables[0].Rows[0][3].ToString();
                    comboBoxTreatmentStage.Text = dataSet.Tables[0].Rows[0][4].ToString();
                    textBoxDateCheckedIn.Text = dataSet.Tables[0].Rows[0][5].ToString();
                    textBoxDateCheckedOut.Text = dataSet.Tables[0].Rows[0][6].ToString();
                    textBoxNotes.Text = dataSet.Tables[0].Rows[0][7].ToString();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string checkedInDate = textBoxDateCheckedIn.Text;
            string checkedOutDate = textBoxDateCheckedOut.Text;
            string notes = textBoxNotes.Text;

            if (notes == "")
            {
                notes = "Pending";
            }

            if (checkedOutDate == "  -  -")
            {
                checkedOutDate = "00-00-0000";
            }

            if (labelPatientIDInsert.Text == "" || textBoxIllness.Text == "" || textBoxIllnessType.Text == "" || comboBoxTreatmentStage.Text == "" || textBoxDateCheckedIn.Text == "" || checkedOutDate == "" || notes == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkedInDate.Length != 10 || checkedOutDate.Length != 10)
            {
                MessageBox.Show("Make sure Checked In Date and Checked Out Date are filled in correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you would like to Edit PatientID = " + labelPatientIDInsert.Text + "'s Illness Information?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
                    sqlConnection.Open();
                    string query = "UPDATE IllnessInformation SET PatientID = '" + labelPatientIDInsert.Text + "', Illness = '" + textBoxIllness.Text + "', IllnessType = '" + textBoxIllnessType.Text + "', TreatmentStage = '" + comboBoxTreatmentStage.Text + "', DateCheckedIn = '" + textBoxDateCheckedIn.Text + "', DateCheckedOut = '" + textBoxDateCheckedOut.Text + "', Notes = '" + textBoxNotes.Text + "' where TreatmentID = '" + textBoxTreatmentID.Text + "'";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Patient Illness Information details successfully updated. ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.None);
                    textBoxTreatmentID.Text = "";
                    labelPatientIDInsert.Text = "";
                    textBoxIllness.Text = "";
                    textBoxIllnessType.Text = "";
                    comboBoxTreatmentStage.ResetText();
                    textBoxDateCheckedIn.Text = "";
                    textBoxDateCheckedOut.Text = "";
                    textBoxNotes.Text = "";
                }
            }
        }

        private void labelGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DoctorIllnessMenu doctorIllnessMenu = new DoctorIllnessMenu();
                doctorIllnessMenu.Show();
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
                DoctorIllnessMenu doctorIllnessMenu = new DoctorIllnessMenu();
                doctorIllnessMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DoctorIllnessMenu doctorIllnessMenu = new DoctorIllnessMenu();
                doctorIllnessMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
