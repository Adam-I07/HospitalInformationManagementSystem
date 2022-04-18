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
    public partial class NursePatientPersonalInfoMenu : Form
    {
        public List<string> idAvailable = new List<string>();
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        public NursePatientPersonalInfoMenu()
        {
            InitializeComponent();
        }

        private void NursePatientPersonalInfoMenu_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from PatientPersonalInformation";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            dataGridViewLoginDetails.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
            foreach (DataGridViewRow item in dataGridViewLoginDetails.Rows)
            {
                idAvailable.Add(item.Cells[2].Value.ToString());
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String firstNameIDInputted = textBoxSearchFirstName.Text.ToString();
            bool isValidUserID = false;
            for (int i = 0; i < idAvailable.Count(); i++)
            {
                if (idAvailable[i] == firstNameIDInputted)
                {
                    isValidUserID = true;
                    break;
                }
            }

            if (textBoxSearchFirstName.Text == "")
            {
                MessageBox.Show("Please enter a First Name to search!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isValidUserID == false)
            {
                MessageBox.Show("The First Name entered does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;

                command.CommandText = "select * from PatientPersonalInformation where [FirstName] = '" + textBoxSearchFirstName.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);

                dataGridViewLoginDetails.DataSource = dataSet.Tables[0];
                sqlConnection.Close();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from PatientPersonalInformation";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            dataGridViewLoginDetails.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }

        private void buttonViewSpecificPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseViewSpecificPatientInfo nurseViewSpecificPatientInfo = new NurseViewSpecificPatientInfo();
            nurseViewSpecificPatientInfo.Show();
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
