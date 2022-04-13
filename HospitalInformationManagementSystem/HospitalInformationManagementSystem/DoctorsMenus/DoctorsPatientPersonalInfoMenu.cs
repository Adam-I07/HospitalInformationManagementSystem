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
    public partial class DoctorsPatientPersonalInfoMenu : Form
    {
        public DoctorsPatientPersonalInfoMenu()
        {
            InitializeComponent();
        }

        private void DoctorsPatientPersonalInfoMenu_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from PatientPersonalInformation";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            dataGridViewLoginDetails.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                DoctosMainMenu doctosMainMenu = new DoctosMainMenu();
                doctosMainMenu.Show();
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
                DoctosMainMenu doctosMainMenu = new DoctosMainMenu();
                doctosMainMenu.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void buttonAddNewPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorAddPatient doctorAddPatient = new DoctorAddPatient();
            doctorAddPatient.Show();
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
