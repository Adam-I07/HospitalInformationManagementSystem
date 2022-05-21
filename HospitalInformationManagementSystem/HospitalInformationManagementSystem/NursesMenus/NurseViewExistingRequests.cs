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

namespace HospitalInformationManagementSystem.NursesMenus
{
    public partial class NurseViewExistingRequests : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        Requests requests = new Requests();

        public NurseViewExistingRequests()
        {
            InitializeComponent();
        }

        private void NurseViewExistingRequests_Load(object sender, EventArgs e)
        {
            requests.LoadCurrentRequests();
            dataGridViewRequestsView.DataSource = requests.currentRequests.Tables[0];
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxRequestStatus.Text == "")
            {
                MessageBox.Show("Select a Request Status!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                requests.userSelectedFilter = comboBoxRequestStatus.Text;
                requests.FilterIlnessInformation();
                dataGridViewRequestsView.DataSource = requests.currentRequests.Tables[0];
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            requests.LoadCurrentRequests();
            dataGridViewRequestsView.DataSource = requests.currentRequests.Tables[0];
        }

        private void buttonViewSpecificRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseViewSpecificRequest nurseViewSpecificRequest = new NurseViewSpecificRequest();
            nurseViewSpecificRequest.Show();
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NurseRequestMenu nurseRequestMenu = new NurseRequestMenu();
                nurseRequestMenu.Show();
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
                NurseRequestMenu nurseRequestMenu = new NurseRequestMenu();
                nurseRequestMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
