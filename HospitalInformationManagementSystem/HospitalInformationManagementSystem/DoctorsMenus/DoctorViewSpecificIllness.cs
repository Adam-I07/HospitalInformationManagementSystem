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
    public partial class DoctorViewSpecificIllness : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        public double maximumIDNumber;
        public List<string> idAvailable = new List<string>();
        public DoctorViewSpecificIllness()
        {
            InitializeComponent();
        }

        private void DoctorViewSpecificIllness_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select TreatmentID from IllnessInformation";

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
                Double treatmentIDInputted = Convert.ToDouble(textBoxTreatmentID.Text);
                if (treatmentIDInputted > maximumIDNumber || treatmentIDInputted <= 0)
                {
                    MessageBox.Show("The Patient ID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "select * from IllnessInformation where TreatmentID = " + textBoxTreatmentID.Text + "";

                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    sda.Fill(dataSet);
                    sqlConnection.Close();

                    labelPatientIDInsert.Text = dataSet.Tables[0].Rows[0][1].ToString();
                    labelIllnessInsert.Text = dataSet.Tables[0].Rows[0][2].ToString();
                    labelIllnessTypeInsert.Text = dataSet.Tables[0].Rows[0][3].ToString();
                    labelTreatmentStageInsert.Text = dataSet.Tables[0].Rows[0][4].ToString();
                    labelDateCheckedInInsert.Text = dataSet.Tables[0].Rows[0][5].ToString();
                    labelDateCheckedOutInsert.Text = dataSet.Tables[0].Rows[0][6].ToString();
                    textBoxNotesInsert.Text = dataSet.Tables[0].Rows[0][7].ToString();

                }
            }
        }

        private void buttonNewSearch_Click(object sender, EventArgs e)
        {
            textBoxTreatmentID.Text = "";
            labelPatientIDInsert.Text = "";
            labelIllnessInsert.Text = "";
            labelIllnessTypeInsert.Text = "";
            labelTreatmentStageInsert.Text = "";
            labelDateCheckedInInsert.Text = "";
            labelDateCheckedOutInsert.Text = "";
            textBoxNotesInsert.Text = "";
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
    }
}
