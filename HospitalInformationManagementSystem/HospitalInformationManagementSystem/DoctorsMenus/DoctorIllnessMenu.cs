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
    public partial class DoctorIllnessMenu : Form
    {
        public DoctorIllnessMenu()
        {
            InitializeComponent();
        }

        private void DoctorIllnessMenu_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from IllnessInformation";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            dataGridViewDisplayIllnessInfo.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }

        private void buttonAddNewIllness_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorAddIllness doctorAddIllness = new DoctorAddIllness();
            doctorAddIllness.Show();
        }

        private void buttonEditIllnessInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorEditIllness doctorEditIllness = new DoctorEditIllness();
            doctorEditIllness.Show();
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

        private void buttonDeleteIllnessInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDeleteIllness doctorDeleteIllness = new DoctorDeleteIllness();
            doctorDeleteIllness.Show();
        }

        private void buttonSpecificIllnessInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorViewSpecificIllness doctorViewSpecificIllness = new DoctorViewSpecificIllness();
            doctorViewSpecificIllness.Show();
        }
    }
}
