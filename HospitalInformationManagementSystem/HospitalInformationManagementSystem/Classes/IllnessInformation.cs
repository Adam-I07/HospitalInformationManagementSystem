using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalInformationManagementSystem
{
    class IllnessInformation
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        string _treatmentID;
        string _patientID;
        string _illness;
        string _illnessType;
        string _treatmentStage;
        string _dateCheckedIn;
        string _dateCheckedOut;
        string _notes;
        public DataSet currentIllnessInformation = new DataSet();
        public string userSelectedPatientID;
        public List<string> currentExistingTreatmentIDs = new List<string>();
        public DataTable currentExistingPatientIDs = new DataTable();

        public IllnessInformation()
        {
            _treatmentID = "";
            _patientID = "";
            _illness = "";
            _illnessType = "";
            _treatmentStage = "";
            _dateCheckedIn = "";
            _dateCheckedOut = "";
            _notes = "";
        }

        public IllnessInformation(string treatmentID, string patientID, string illness, string illnessType, string treatmentStage, string dateCheckedIn, string dateCheckedOut, string notes)
        {
            _treatmentID = treatmentID;
            _patientID = patientID;
            _illness = illness;
            _illnessType = illnessType;
            _treatmentStage = treatmentStage;
            _dateCheckedIn = dateCheckedIn;
            _dateCheckedOut = dateCheckedOut;
            _notes = notes;
        }

        public string treatmentID
        {
            get
            {
                return _treatmentID;
            }
            set
            {
                _treatmentID = value;
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
        public string illness
        {
            get
            {
                return _illness;
            }
            set
            {
                _illness = value;
            }
        }
        public string illnessType
        {
            get
            {
                return _illnessType;
            }
            set
            {
                _illnessType = value;
            }
        }
        public string treatmentStage
        {
            get
            {
                return _treatmentStage;
            }
            set
            {
                _treatmentStage = value;
            }
        }
        public string dateCheckedIn
        {
            get
            {
                return _dateCheckedIn;
            }
            set
            {
                _dateCheckedIn = value;
            }
        }
        public string dateCheckedOut
        {
            get
            {
                return _dateCheckedOut;
            }
            set
            {
                _dateCheckedOut = value;
            }
        }
        public string notes
        {
            get
            {
                return _notes;
            }
            set
            {
                _notes = value;
            }
        }

        public bool LoadCurrentDetails()
        {
            currentIllnessInformation.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from IllnessInformation";
            SqlDataAdapter sda = new SqlDataAdapter(command);

            sda.Fill(currentIllnessInformation);
            sqlConnection.Close();
            return true;
        }

        public bool FilterIlnessInformation()
        {
            currentIllnessInformation.Clear();
            sqlConnection.Open();
            string query = "select * from IllnessInformation where PatientID = " + userSelectedPatientID + "";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Fill(currentIllnessInformation);
            sqlConnection.Close();
            return true;
        }
        public bool GetAllCurrentTreatmentIDs()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select TreatmentID from IllnessInformation";
            command.Connection.Open();
            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                currentExistingTreatmentIDs.Add(sqlDataReader.GetValue(0).ToString());
            }

            sqlConnection.Close();
            return true;
        }
        public bool GetAllCurrentPateintIDs()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select PatientID from PatientPersonalInformation";
            command.Connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(currentExistingPatientIDs);
            return true;
        }

        public string AddIllnessInformation()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "insert into IllnessInformation(TreatmentID,PatientID,Illness,IllnessType,TreatmentStage,DateCheckedIn,DateCheckedOut,Notes) values ('" + treatmentID + "', '" + patientID + "','" + illness + "','" + illnessType + "','" + treatmentStage + "','" + dateCheckedIn + "','" + dateCheckedOut + "','" + notes + "')";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            sqlConnection.Close();
            return "Successful";
        }
        public bool EditIllnessInformation()
        {
            sqlConnection.Open();
            string query = "UPDATE IllnessInformation SET PatientID = '" + patientID + "', Illness = '" + illness + "', IllnessType = '" + illnessType + "', TreatmentStage = '" + treatmentStage + "', DateCheckedIn = '" + dateCheckedIn + "', DateCheckedOut = '" + dateCheckedOut + "', Notes = '" + notes + "' where TreatmentID = '" + treatmentID + "'";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }

        public bool GetIllnessInformation()
        {

            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select * from IllnessInformation where TreatmentID = " + treatmentID + "";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            patientID = dataSet.Tables[0].Rows[0][1].ToString();
            illness = dataSet.Tables[0].Rows[0][2].ToString();
            illnessType = dataSet.Tables[0].Rows[0][3].ToString();
            treatmentStage = dataSet.Tables[0].Rows[0][4].ToString();
            dateCheckedIn = dataSet.Tables[0].Rows[0][5].ToString();
            dateCheckedOut = dataSet.Tables[0].Rows[0][6].ToString();
            notes = dataSet.Tables[0].Rows[0][7].ToString();

            sqlConnection.Close();
            return true;
        }
        public string DeleteIllnessInformation()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "delete from IllnessInformation where TreatmentID = '" + treatmentID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            sqlConnection.Close();
            return "Success";
        }
    }
}
