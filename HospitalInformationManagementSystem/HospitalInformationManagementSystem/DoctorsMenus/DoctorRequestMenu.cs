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
    public partial class DoctorRequestMenu : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");

        public DoctorRequestMenu()
        {
            InitializeComponent();
        }

        private void DoctorRequestMenu_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from Requests";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            dataGridViewRequestsView.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }

        private void buttonRespondToRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorRespondToRequest doctorRespondToRequest = new DoctorRespondToRequest();
            doctorRespondToRequest.Show();
        }

        private void buttonViewRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorViewSpecificRequest doctorViewSpecificRequest = new DoctorViewSpecificRequest();
            doctorViewSpecificRequest.Show();
        }

        private void buttonDeleteRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDeleteRequest doctorDeleteRequest = new DoctorDeleteRequest();
            doctorDeleteRequest.Show();
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                DoctorsMainMenu doctorsMainMenu = new DoctorsMainMenu();
                doctorsMainMenu.Show();
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
                DoctorsMainMenu doctorsMainMenu = new DoctorsMainMenu();
                doctorsMainMenu.Show();
            }
            else
            {
                this.Show();
            }
        }
    }
}
