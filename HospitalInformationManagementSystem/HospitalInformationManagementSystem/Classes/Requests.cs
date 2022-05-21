using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem
{
    class Requests
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        string _requestID;
        string _userID;
        string _requestDate;
        string _requestStatus;
        string _request;
        string _requestResponse;
        public DataSet currentRequests = new DataSet();
        public string userSelectedFilter;
        public List<String> currentExistingRequestIDs = new List<string>();
        public DataTable currentExistingLoginIDs = new DataTable();

        public Requests()
        {
            _requestID = "";
            _userID = "";
            _requestDate = "";
            _requestStatus = "";
            _request = "";
            _requestResponse = "";
        }

        public Requests(string requestID, string userID, string requestDate, string requestStatus, string request, string requestResponse)
        {
            _requestID = requestID;
            _userID = userID;
            _requestDate = requestDate;
            _requestStatus = requestStatus;
            _request = request;
            _requestResponse = requestResponse;
        }
        public string requestID
        {
            get
            {
                return _requestID;
            }
            set
            {
                _requestID = value;
            }
        }
        public string userID
        {
            get
            {
                return _userID;
            }
            set
            {
                _userID = value;
            }
        }
        public string requestDate
        {
            get
            {
                return _requestDate;
            }
            set
            {
                _requestDate = value;
            }
        }
        public string requestStatus
        {
            get
            {
                return _requestStatus;
            }
            set
            {
                _requestStatus = value;
            }
        }
        public string request
        {
            get
            {
                return _request;
            }
            set
            {
                _request = value;
            }
        }
        public string requestResponse
        {
            get
            {
                return _requestResponse;
            }
            set
            {
                _requestResponse = value;
            }
        }
        public bool LoadCurrentRequests()
        {
            currentRequests.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from Requests";
            SqlDataAdapter sda = new SqlDataAdapter(command);

            sda.Fill(currentRequests);
            sqlConnection.Close();
            return true;
        }
        public bool FilterIlnessInformation()
        {
            currentRequests.Clear();
            sqlConnection.Open();
            string query = "select * from Requests where RequestStatus = '" + userSelectedFilter + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Fill(currentRequests);
            sqlConnection.Close();
            return true;
        }
        public bool GetAllCurrentRequestID()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select RequestID from Requests";
            command.Connection.Open();
            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                currentExistingRequestIDs.Add(sqlDataReader.GetValue(0).ToString());
            }

            sqlConnection.Close();
            return true;
        }
        public bool SubmitRequest()
        {
            string date = DateTime.UtcNow.ToString("dd-MM-yyyy");
            string requestStatus = "Pending";
            string requestResponse = "Pending";

            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "insert into Requests(RequestID,UserID,RequestDate,RequestStatus,Request,RequestResponse) values ('" + requestID + "', '" + userID + "','" + date + "','" + requestStatus + "','" + request + "','" + requestResponse + "')";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
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
        public bool GetRequest()
        {

            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select * from Requests where RequestID = " + requestID + "";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            userID = dataSet.Tables[0].Rows[0][1].ToString();
            requestDate = dataSet.Tables[0].Rows[0][2].ToString();
            requestStatus = dataSet.Tables[0].Rows[0][3].ToString();
            request = dataSet.Tables[0].Rows[0][4].ToString();
            requestResponse = dataSet.Tables[0].Rows[0][5].ToString();

            sqlConnection.Close();
            return true;
        }

        public bool RespondToRequest()
        {
            sqlConnection.Open();
            string query = "UPDATE Requests SET UserID = '" + userID + "', RequestDate = '" + requestDate + "', RequestStatus = '" + requestStatus + "', Request = '" + request + "', RequestResponse = '" + requestResponse + "' where RequestID = '" + requestID + "'";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        public string DeleteRequest()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "delete from Requests where RequestID = '" + requestID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            sqlConnection.Close();
            return "Success";
        }
    }
}
