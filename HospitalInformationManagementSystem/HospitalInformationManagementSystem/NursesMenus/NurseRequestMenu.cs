using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem.NursesMenus
{
    public partial class NurseRequestMenu : Form
    {
        public NurseRequestMenu()
        {
            InitializeComponent();
        }
        private void buttonSubmitRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseSubmitRequest nurseSubmitRequest = new NurseSubmitRequest();
            nurseSubmitRequest.Show();
        }

        private void buttonViewRequests_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseViewExistingRequests nurseViewExistingRequests = new NurseViewExistingRequests();
            nurseViewExistingRequests.Show();
        }
        private void pictureBoxGoBack_Click(object sender, EventArgs e)
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

        private void labelGoBack_Click(object sender, EventArgs e)
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
