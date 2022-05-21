using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HospitalInformationManagementSystem
{
    class InteractionLog
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        string _logID;
        string _loginID;
        string _staffName;
        string _patientID;
        string _date;
        string _shift;
        string _interactionNotes;
        public string userSelectedPatientID;
        public DataSet currentInteractionLogDetails = new DataSet();
        public List<string> currentExistingLogIDs = new List<string>();
        public DataTable currentExistingPatientIDs = new DataTable();
        public DataTable currentExistingLoginIDs = new DataTable();

        public InteractionLog()
        {
            _logID = "";
            _loginID = "";
            _staffName = "";
            _patientID = "";
            _date = "";
            _shift = "";
            _interactionNotes = "";
        }
        public InteractionLog(string logID, string loginID, string staffName, string patientID, string date, string shift, string interactionNotes)
        {
            _logID = logID;
            _loginID = loginID;
            _staffName = staffName;
            _patientID = patientID;
            _date = date;
            _shift = shift;
            _interactionNotes = interactionNotes;
        }
        public string logID
        {
            get
            {
                return _logID;
            }
            set
            {
                _logID = value;
            }
        }
        public string loginID
        {
            get
            {
                return _loginID;
            }
            set
            {
                _loginID = value;
            }
        }
        public string staffName
        {
            get
            {
                return _staffName;
            }
            set
            {
                _staffName = value;
            }
        }
        public string patientID
        {
            get
            {
                return _patientID;
            }
            set
            {
                _patientID = value;
            }
        }
        public string date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        public string shift
        {
            get
            {
                return _shift;
            }
            set
            {
                _shift = value;
            }
        }
        public string interactionNotes
        {
            get
            {
                return _interactionNotes;
            }
            set
            {
                _interactionNotes = value;
            }
        }
        public bool LoadCurrentDetails()
        {
            currentInteractionLogDetails.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from InteractionLog";
            SqlDataAdapter sda = new SqlDataAdapter(command);

            sda.Fill(currentInteractionLogDetails);
            sqlConnection.Close();
            return true;
        }
        public bool GetAllCurrentPatientIDs()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select PatientID from PatientPersonalInformation";
            command.Connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(currentExistingPatientIDs);
            sqlConnection.Close();
            return true;
        }
        public bool FilterIlnessInformation()
        {
            currentInteractionLogDetails.Clear();
            sqlConnection.Open();
            string query = "select * from InteractionLog where PatientID = " + userSelectedPatientID + "";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Fill(currentInteractionLogDetails);
            sqlConnection.Close();
            return true;
        }
        public bool GetAllCurrentlogIDs()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select LogID from InteractionLog";
            command.Connection.Open();
            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                currentExistingLogIDs.Add(sqlDataReader.GetValue(0).ToString());
            }

            sqlConnection.Close();
            return true;
        }

        public bool GetAllCurrentLoginIDs()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select LogInID from LogInDetails";
            command.Connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(currentExistingLoginIDs);
            sqlConnection.Close();
            return true;
        }

        public string AddInteractionLog()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "insert into InteractionLog(LogID,LogInID,StaffName,PatientID,Date,Shift,InteractionNotes) values ('" + logID + "', '" + loginID + "','" + staffName + "','" + patientID + "','" + date + "','" + shift + "','" + interactionNotes + "')";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            sqlConnection.Close();
            return "Successful";
        }

        public bool GetInteractionLog()
        {

            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select * from InteractionLog where LogID = " + logID + "";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            loginID = dataSet.Tables[0].Rows[0][1].ToString();
            staffName = dataSet.Tables[0].Rows[0][2].ToString();
            patientID = dataSet.Tables[0].Rows[0][3].ToString();
            date = dataSet.Tables[0].Rows[0][4].ToString();
            shift = dataSet.Tables[0].Rows[0][5].ToString();
            interactionNotes = dataSet.Tables[0].Rows[0][6].ToString();

            sqlConnection.Close();
            return true;
        }
        public bool EditIllnessInformation()
        {
            sqlConnection.Open();
            string query = "UPDATE InteractionLog SET LogInID = '" + loginID + "', StaffName = '" + staffName + "', PatientID = '" + patientID + "', Date = '" + date + "', Shift = '" + shift + "', InteractionNotes = '" + interactionNotes + "' where LogID = '" + logID + "'";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        public string DeleteIlnteractionLog()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "delete from InteractionLog where LogID = '" + logID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            sqlConnection.Close();
            return "Success";
        }

    }
}
