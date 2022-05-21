using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.DoctorsMenus
{
    public partial class DoctorDeleteRequest : Form
    {
        Requests requests = new Requests();
        public List<string> idAvailable = new List<string>();
        public DoctorDeleteRequest()
        {
            InitializeComponent();
        }

        private void DoctorDeleteRequest_Load(object sender, EventArgs e)
        {
            requests.LoadCurrentRequests();
            dataGridViewRequestsView.DataSource = requests.currentRequests.Tables[0];
            requests.GetAllCurrentRequestID();
            idAvailable = requests.currentExistingRequestIDs;
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            String userIDInputted = textBoxRequestID.Text.ToString();
            bool isValidUserID = false;
            for (int i = 0; i < idAvailable.Count(); i++)
            {
                if (idAvailable[i] == userIDInputted)
                {
                    isValidUserID = true;
                    break;
                }
            }

            if (textBoxRequestID.Text == "")
            {
                MessageBox.Show("Please enter a RequestID to delete!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isValidUserID == false)
            {
                MessageBox.Show("The ID entered does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you would like to delete Request = " + textBoxRequestID.Text + "?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    requests.requestID = textBoxRequestID.Text;
                    requests.DeleteRequest();
                    MessageBox.Show("Request Deleted Successfully", "Interaction Log Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    DoctorRequestMenu doctorRequestMenu = new DoctorRequestMenu();
                    doctorRequestMenu.Show();
                }
            }
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DoctorRequestMenu doctorRequestMenu = new DoctorRequestMenu();
                doctorRequestMenu.Show();
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
                DoctorRequestMenu doctorRequestMenu = new DoctorRequestMenu();
                doctorRequestMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
