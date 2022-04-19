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
    public partial class NurseAddInteractionLog : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        public Int64 idNumber;
        public NurseAddInteractionLog()
        {
            InitializeComponent();
        }

        private void NurseAddInteractionLog_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select max(LogID) from InteractionLog";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);

            idNumber = Convert.ToInt64(dataSet.Tables[0].Rows[0][0]);
            idNumber = idNumber + 1;
            labelLogIDCurrent.Text = idNumber.ToString();

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

            SqlCommand command3 = new SqlCommand();
            command3.Connection = sqlConnection;
            command3.CommandText = "select LogInID from LogInDetails";

            SqlDataAdapter sqlDataAdapted3 = new SqlDataAdapter();
            sqlDataAdapted3.SelectCommand = command3;
            DataTable dataTable2 = new DataTable();
            sqlDataAdapted3.Fill(dataTable2);

            comboBoxLoginID.DataSource = dataTable2;
            comboBoxLoginID.DisplayMember = "LogInID";
            comboBoxLoginID.ValueMember = "LogInID";

            sqlConnection.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string date = textBoxDate.Text;
            if (comboBoxLoginID.Text == "" || textBoxStaffName.Text == "" || comboBoxPatientID.Text == "" || textBoxDate.Text == "" || comboBoxShift.Text == "" || textBoxInteractionNotes.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (date.Length != 10)
            {
                MessageBox.Show("Make sure the Date is filled in correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "insert into InteractionLog(LogID,LogInID,StaffName,PatientID,Date,Shift,InteractionNotes) values ('" + idNumber + "', '" + comboBoxLoginID.Text + "','" + textBoxStaffName.Text + "','" + comboBoxPatientID.Text + "','" + textBoxDate.Text + "','" + comboBoxShift.Text + "','" + textBoxInteractionNotes.Text + "')";


                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);
                sqlConnection.Close();
                sqlConnection.Close();
                MessageBox.Show("The Interaction has been added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.None);
                NurseInteractionLogMenu nurseInteractionLogMenu = new NurseInteractionLogMenu();
                nurseInteractionLogMenu.Show();
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you would like to go back?", "Go Back", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NurseInteractionLogMenu nurseInteractionLogMenu = new NurseInteractionLogMenu();
                nurseInteractionLogMenu.Show();
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
                NurseInteractionLogMenu nurseInteractionLogMenu = new NurseInteractionLogMenu();
                nurseInteractionLogMenu.Show();
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
                NurseInteractionLogMenu nurseInteractionLogMenu = new NurseInteractionLogMenu();
                nurseInteractionLogMenu.Show();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
