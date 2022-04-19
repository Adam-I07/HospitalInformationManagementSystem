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
    public partial class DoctorAddIllness : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        public Int64 idNumber;
        public DoctorAddIllness()
        {
            InitializeComponent();
        }

        private void DoctorAddIllness_Load(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select max(TreatmentID) from IllnessInformation";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            idNumber = Convert.ToInt64(dataSet.Tables[0].Rows[0][0]);
            idNumber = idNumber + 1;
            labelTreatmentIDCurrent.Text = idNumber.ToString();

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

            sqlConnection.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string checkedInDate = textBoxDateCheckedIn.Text;
            string checkedOutDate = textBoxDateCheckedOut.Text;
            string notes = textBoxNotes.Text;
            
            if(notes == "")
            {
                notes = "Pending";
            }

            if(checkedOutDate == "  -  -")
            {
                checkedOutDate = "00-00-0000";
            }

            if(comboBoxPatientID.Text == "" || textBoxIllness.Text == "" || textBoxIllnessType.Text == ""|| comboBoxTreatmentStage.Text == "" || textBoxDateCheckedIn.Text == "" || checkedOutDate == ""|| notes == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(checkedInDate.Length != 10 || checkedOutDate.Length != 10)
            {
                MessageBox.Show("Make sure Checked In Date and Checked Out Date are filled in correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "insert into IllnessInformation(TreatmentID,PatientID,Illness,IllnessType,TreatmentStage,DateCheckedIn,DateCheckedOut,Notes) values ('" + idNumber + "', '" + comboBoxPatientID.Text + "','" + textBoxIllness.Text + "','" + textBoxIllnessType.Text + "','" + comboBoxTreatmentStage.Text + "','" + textBoxDateCheckedIn.Text + "','" + textBoxDateCheckedOut.Text + "','" + textBoxNotes.Text + "')";


                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);
                sqlConnection.Close();
                sqlConnection.Close();
                MessageBox.Show("The Patient Illness Information has been added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.None);
                DoctorIllnessMenu doctorIllnessMenu = new DoctorIllnessMenu();
                doctorIllnessMenu.Show();
                this.Close();
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
