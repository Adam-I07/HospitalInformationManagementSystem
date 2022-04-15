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
    
    public partial class DoctorViewSpecificInformationLog : Form
    {
        public double maximumIDNumber;
        public DoctorViewSpecificInformationLog()
        {
            InitializeComponent();
        }

        private void DoctorViewSpecificInformationLog_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select max(LogID) from InteractionLog";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            maximumIDNumber = Convert.ToInt64(dataSet.Tables[0].Rows[0][0]);
            sqlConnection.Close();
        }

        private void buttonFindID_Click(object sender, EventArgs e)
        {
            if (textBoxLogID.Text == "")
            {
                MessageBox.Show("Please enter a Patient ID to search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Double logIDInputted = Convert.ToDouble(textBoxLogID.Text);
                if (logIDInputted > maximumIDNumber || logIDInputted <= 0)
                {
                    MessageBox.Show("The Log ID you have entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "select * from InteractionLog where LogID = " +  textBoxLogID.Text + "";

                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    sda.Fill(dataSet);
                    sqlConnection.Close();

                    labelLogInIDInsert.Text = dataSet.Tables[0].Rows[0][1].ToString();
                    labelStaffNameInsert.Text = dataSet.Tables[0].Rows[0][2].ToString();
                    labelPatientIDInsert.Text = dataSet.Tables[0].Rows[0][3].ToString();
                    labelDateInsert.Text = dataSet.Tables[0].Rows[0][4].ToString();
                    labelShiftInsert.Text = dataSet.Tables[0].Rows[0][5].ToString();
                    textBoxInteractionNotes.Text = dataSet.Tables[0].Rows[0][6].ToString();

                }
            }
        }

        private void buttonNewSearch_Click(object sender, EventArgs e)
        {
            textBoxLogID.Text = "";
            labelLogInIDInsert.Text = "";
            labelStaffNameInsert.Text = "";
            labelPatientIDInsert.Text = "";
            labelDateInsert.Text = "";
            labelShiftInsert.Text = "";
            textBoxInteractionNotes.Text = "";
        }

        private void pictureBoxGoBack_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DoctorInteractionLogMenu doctorInteractionLogMenu = new DoctorInteractionLogMenu();
                doctorInteractionLogMenu.Show();
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
                DoctorInteractionLogMenu doctorInteractionLogMenu = new DoctorInteractionLogMenu();
                doctorInteractionLogMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
