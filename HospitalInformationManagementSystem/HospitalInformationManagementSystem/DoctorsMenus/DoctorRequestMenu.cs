using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HospitalInformationManagementSystem.DoctorsMenus
{
    public partial class DoctorRequestMenu : Form
    {
        Requests requests = new Requests();
        public DoctorRequestMenu()
        {
            InitializeComponent();
        }

        private void DoctorRequestMenu_Load(object sender, EventArgs e)
        {
            requests.LoadCurrentRequests();
            dataGridViewRequestsView.DataSource = requests.currentRequests.Tables[0];
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
    }
}
